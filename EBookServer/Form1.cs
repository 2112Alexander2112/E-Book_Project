using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.Net;
using EBookLib01.BasicacModels;
using EBookLib01.Services;
using EBookLib01.ServiceModels;
using EBookServer.EF_ORM;
//using System.Runtime.CompilerServices;
using System.IO;
using System.Runtime.InteropServices.ComTypes;


namespace EBookServer
{
    public partial class Form1 : Form
    {
        private readonly int _numberOfUsers;
        private int _port;
        private string _clientMessage;

        private IPAddress _ipAdress;
        private IPEndPoint _ep;
        private TcpListener _tcpListener;
        private Thread _listenerThread;

        private ModelManager _modelManager;
        private JSONSender _jsonSender;
        public Form1()
        {
            InitializeComponent();
            _port = 9001;
            _ipAdress = IPAddress.Parse("127.0.0.1");
            _ep = new IPEndPoint(_ipAdress, _port);
            _modelManager = new ModelManager();
            _numberOfUsers = 20;
            _jsonSender = new JSONSender(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tcpListener = new TcpListener(_ep);
            _tcpListener.Start();

            _listenerThread.IsBackground = true;
            _listenerThread.Start();    
        }
        private void MainLoop()
        {
            try
            {
                while (true)
                {
                    TcpClient client = _tcpListener.AcceptTcpClient();
                    NetworkStream ns = client.GetStream();
                    StreamReader sr = new StreamReader(ns);
                    _clientMessage = sr.ReadLine();
                    ClientMessage clientMessage = _jsonSender.ClientMessageDeserialize(_clientMessage);

                    switch (clientMessage.Header)
                    {
                        case "SHOWBOOK":
                            var searchbook = _modelManager.Books
                                .Where(b => b.BookName == clientMessage.SeacrhingBook).FirstOrDefault();
                            if(searchbook == null)
                            {
                                var serverMessage = new ServerMessage()
                                {
                                    Messagge = "NOTFINDED"
                                };
                                var response = _jsonSender.ServerMessageSerialize(serverMessage);
                                StreamWriter sw = new StreamWriter(ns);
                                sw.Flush();

                                sw.Close();
                                sr.Close();
                                ns.Close();
                            }
                            else
                            {
                                var findedBookMessage = new ServerMessage()
                                {
                                    Messagge = "BOOKFOUNDED",
                                    FindedBook = searchbook
                                };
                                var findedBook = _jsonSender.ServerMessageSerialize(findedBookMessage);
                                StreamWriter sw = new StreamWriter(ns);
                                sw.Flush();

                                sw.Close();
                                sr.Close();
                                ns.Close();
                            }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

using EBookLib01;
using EBookLib01.HelperModels.TransitModels;
using EBookServer.EF_ORM;
using EBookLib01.HelperModels;


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

        private NewDataModel _shopDb;
        private JSONSender _jsonSender;
        public Form1()
        {
            InitializeComponent();
            _port = 9001;
            _ipAdress = IPAddress.Parse("127.0.0.1");
            _ep = new IPEndPoint(_ipAdress, _port);
            _shopDb = new NewDataModel();
            _numberOfUsers = 20;
            _jsonSender = new JSONSender();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tcpListener = new TcpListener(_ep);
            _tcpListener.Start();

            _listenerThread = new Thread(new ThreadStart(MainLoop));
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
                            var searchbook = _shopDb.Books
                                .Where(b => b.BookName == clientMessage.SeacrhingBook).FirstOrDefault();
                            if(searchbook == null)
                            {
                                var serverMessage = new ServerMessage()
                                {
                                    Messagge = "NOTFINDED"
                                };
                                var response = _jsonSender.ServerMessageSerialize(serverMessage);
                                StreamWriter sw = new StreamWriter(ns);
                                sw.WriteLine(response);
                                sw.Flush();

                                sw.Close();
                                sr.Close();
                                ns.Close();
                            }
                            else
                            {
                                var genre = _shopDb.Genres.Where(g => g.Id == searchbook.Id).First();
                                var publisher = _shopDb.Publishers.Where(p => p.Id == searchbook.PublisherId).First();
                                var autor = _shopDb.Authors.Where(a => a.Id == searchbook.AuthorId).First();
                                var infoaboutbook = new AboutBookModel()
                                {
                                    Price = Convert.ToString(searchbook.Price),
                                    Genre = genre.GenreName,
                                    AlterName = searchbook.AlterName,
                                    Publisher = publisher.PublisherName,
                                    Published = Convert.ToString(searchbook.Published),
                                    Author = autor.AuthorName
                                };
                                var findedBookMessage = new ServerMessage()
                                {
                                    Messagge = "BOOKFOUNDED",
                                    
                                };
                                var findedBook = _jsonSender.ServerMessageSerialize(findedBookMessage);
                                StreamWriter sw = new StreamWriter(ns);
                                sw.WriteLine(findedBook);
                                sw.Flush();

                                sw.Close();
                                sr.Close();
                                ns.Close();
                            }
                        break;
                        case "REG_USER":
                            break;
                        case "GET_USER":
                            break;
                        case "GET_BOOK":
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

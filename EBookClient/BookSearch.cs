using EBookLib01.HelperModels.TransitModels;
using EBookLib01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace EBookClient
{
    public partial class BookSearch : Form
    {
        private JSONSender _jsonsender;
        public IPAddress AddrDTO { get; set; }
        public int PortDTO { get; set; }
        public string JsonstringSearchBookMessage { get; set; }
        public BookSearch()
        {
            InitializeComponent();
        _jsonsender = new JSONSender();
    }

        private void button1_Click(object sender, EventArgs e)
        {
            var messageToServer = new ClientMessage()
            {
                Header = "SHOWBOOK",
                SeacrhingBook = BookSerch.Text
            };
            JsonstringSearchBookMessage = _jsonsender.ClientMessageSerialize(messageToServer);

            var client = new TcpClient();

            client.Connect(AddrDTO, PortDTO);

            NetworkStream ns = client.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine(messageToServer);
            sw.Flush();

            StreamReader sr = new StreamReader(ns);
            var serverMessage = new ServerMessage();

            serverMessage.Messagge = sr.ReadLine();

            if (serverMessage.Messagge == "BOOKFOUNDED")
            {
                BookSerch.Text = serverMessage.About.Price.ToString();
                AuthorField.Text = serverMessage.About.Author;
                GenreField.Text = serverMessage.About.Genre;
                PublisherField.Text = serverMessage.About.Publisher;
                Published.Text = serverMessage.About.Published;
                AlterName.Text = serverMessage.About.AlterName;
            }
            else
            {
                MessageBox.Show("Книжка не знайдена", "Повідомлення",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearField_Click(object sender, EventArgs e)
        {

        }
    }
}

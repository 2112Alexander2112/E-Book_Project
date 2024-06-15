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
using System.Text.Json;
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
            try
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
                sw.WriteLine(JsonstringSearchBookMessage);
                sw.Flush();



                StreamReader sr = new StreamReader(ns);
                var serverMessage = sr.ReadLine();
                //var serverMessage2 = new ServerMessage();
                var serverMessage2 = _jsonsender.ServerMessageDeserialize(serverMessage);



                if (serverMessage2.Messagge == "BOOKFOUNDED")
                {
                    BookSerch.Text = serverMessage2.About.Price.ToString();
                    AuthorField.Text = serverMessage2.About.Author;
                    GenreField.Text = serverMessage2.About.Genre;
                    PublisherField.Text = serverMessage2.About.Publisher;
                    Published.Text = serverMessage2.About.Published;
                    AlterName.Text = serverMessage2.About.AlterName;
                }
                else
                {
                    MessageBox.Show("Книжка не знайдена", "Повідомлення",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Нажаль сталась помилка:{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearField_Click(object sender, EventArgs e)
        {

        }
    }
}

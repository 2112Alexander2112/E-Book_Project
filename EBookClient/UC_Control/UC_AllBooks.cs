using EBookLib01.BasicModels;
using EBookLib01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EBookLib01.HelperModels.TransitModels;
using System.IO;
using System.Net.Sockets;

namespace EBookClient.UC_Control
{
    public partial class UC_AllBooks : UserControl
    {
        private int currentPage = 0;
        private int totalPages = 0;
        private int booksPerPage = 12;
        private UC_MYLIBRARYBOOK[] booksElements;

        private static List<Book> allBooks = new List<Book>();
        private static List<Book> books = new List<Book>();
        private Image img = Properties.Resources.No_Image_Available;
        private JSONSender _jsonsender;
        public User currentUser;
        public IPAddress AddrDTO { get; set; }
        public int PortDTO { get; set; }
        public string JsonstringServerMessage { get; set; }

        int totalBooks = 0;
        public UC_AllBooks()
        {
            InitializeComponent();
        }

        void UC_Book_Click(object sender, EventArgs e)
        {
            var obj = (UC_Book)sender;
        }


        private void ShowCurrentPage()
        {
            flowLayoutPanel1.Controls.Clear();
            int startIndex = currentPage * booksPerPage;

            int remainingBooks = books.Count - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = books.Count;
            totalPages = (totalBooks + booksPerPage - 1) / booksPerPage;
            booksElements = new UC_MYLIBRARYBOOK[booksToShow];

            for (int i = 0; i < booksElements.Length; i++)
            {
                booksElements[i] = new UC_MYLIBRARYBOOK();
                booksElements[i].Titles = books[startIndex + i].BookName;
                booksElements[i].Date = books[startIndex + 1].Published.ToString("yyyy-MM-dd");
                booksElements[i].Abouts = books[startIndex + i].Author.AuthorName;
                booksElements[i].UserId = currentUser.Id;
                booksElements[i].BookId = books[startIndex + i].Id;
                booksElements[i].Icon = img;
                booksElements[i].AddrDTO = AddrDTO;
                booksElements[i].PortDTO = PortDTO;
                booksElements[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(booksElements[i]);
            }
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            ButtonUp.Enabled = (currentPage > 0);
            ButtonDown.Enabled = (currentPage > 0);

            textBox1.Text = (currentPage + 1).ToString();
        }

        private void ButtonUp_Click(object sender, EventArgs e)
        {
            currentPage--;
            ShowCurrentPage();
        }

        private void ButtonDown_Click(object sender, EventArgs e)
        {
            currentPage++;
            ShowCurrentPage();
        }

        public void GetBooksFromServer()
        {
            try
            {
                _jsonsender = new JSONSender();
                var messageToServer = new ClientMessage()
                {
                    Header = "GET_MYLIBRARY",
                    UserId = currentUser.Id,
                };
                JsonstringServerMessage = _jsonsender.ClientMessageSerialize(messageToServer);

                var client = new TcpClient();

                client.Connect(AddrDTO, PortDTO);

                NetworkStream ns = client.GetStream();
                StreamWriter sw = new StreamWriter(ns);
                sw.WriteLine(JsonstringServerMessage);
                sw.Flush();

                StreamReader sr = new StreamReader(ns);
                var serverMessage = sr.ReadLine();
                var serverMessage2 = _jsonsender.ServerMessageDeserialize(serverMessage);

                if (serverMessage2.Messagge == "GET_MYLIBRARY:OK")
                {
                    books = serverMessage2.AllBooks;
                    allBooks = serverMessage2.AllBooks;
                    ShowCurrentPage();
                }
                else
                {
                    books = new List<Book>();
                    MessageBox.Show("No books were found", "Повідомлення",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Нажаль сталась помилка:{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

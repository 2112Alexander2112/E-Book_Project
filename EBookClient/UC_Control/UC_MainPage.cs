﻿using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using EBookLib01.HelperModels.TransitModels;
using EBookLib01;
using System.IO;
using System.Net.Sockets;
using System.Security.Policy;
using System.Net;
using System.Net.Http;
using System.Web.UI.WebControls.WebParts;
using System.Threading;

namespace EBookClient.UC_Control
{
    public partial class UC_MainPage : UserControl
    {

        private int currentPage = 0;
        private int totalPages = 0;
        private int booksPerPage = 12;
        private UC_Book[] booksElements;

        static List<Book> books;
        static List<Book> allBooks;
        static List<Image> icons;
        private JSONSender _jsonsender; 
        public IPAddress AddrDTO { get; set; }
        public int PortDTO { get; set; }
        public string JsonstringSearchBookMessage { get; set; }
        
        public User currentUser { get; set; }

        int totalBooks = 0;


        public UC_MainPage()
        {
            InitializeComponent();
        }

        void UC_Book_Click(object sender, EventArgs e)
        {
            var obj = (UC_Book)sender;
        }

        private void UC_MainPage_Load(object sender, EventArgs e)
        {
            _jsonsender = new JSONSender();
        }

        private void ShowCurrentPage()
        {
            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * booksPerPage;

            int remainingBooks = books.Count - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = books.Count;
            totalPages = (totalBooks + booksPerPage - 1) / booksPerPage;
            booksElements = new UC_Book[booksToShow];

            for (int i = 0; i < booksElements.Length; i++)
            {
                booksElements[i] = new UC_Book(false);
                booksElements[i].Title = books[startIndex + i].BookName;
                booksElements[i].Author = books[startIndex + i].Author.AuthorName;
                booksElements[i].Icon = icons[startIndex + i];
                booksElements[i].Price = books[startIndex + i].Price.ToString();
                booksElements[i].Click += new System.EventHandler(this.UC_Book_Click);
                booksElements[i].AddrDTO = AddrDTO;
                booksElements[i].PortDTO = PortDTO;
                booksElements[i].BookId = books[startIndex + i].Id;
                booksElements[i].UserId = currentUser.Id;

                flowLayoutPanel1.Controls.Add(booksElements[i]);
            }
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            buttonPreviousPage.Enabled = (currentPage > 0);
            buttonBack.Enabled = (currentPage > 0);

            buttonNext.Enabled = (currentPage < (books.Count - 1) / booksPerPage);
            buttonNextFast.Enabled = (currentPage < (books.Count - 1) / booksPerPage);
            textBox1.Text = (currentPage + 1).ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage = 0;
                ShowCurrentPage();
            }
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            ShowCurrentPage();
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            ShowCurrentPage();
        }

        private void buttonNextFast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages - 1;
            ShowCurrentPage();
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            string query = SearchField.Text.ToLower();

            List<Book> filteredBooks = SearchBooks(books, query);

            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * booksPerPage;

            int remainingBooks = filteredBooks.Count - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = filteredBooks.Count;
            totalPages = (totalBooks + booksPerPage - 1) / booksPerPage;
            booksElements = new UC_Book[booksToShow];

            for (int i = 0; i < booksElements.Length; i++)
            {
                booksElements[i] = new UC_Book(false);
                booksElements[i].Title = filteredBooks[startIndex + i].BookName;
                booksElements[i].Author = filteredBooks[startIndex + i].Author.AuthorName;
                booksElements[i].Icon = icons[startIndex + i];
                booksElements[i].Price = books[startIndex + i].Price.ToString();
                booksElements[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(booksElements[i]);
            }
            UpdateNavigationButtons();
        }

        static List<Book> SearchBooks(List<Book> books, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return books;
            }

            searchTerm = searchTerm.ToLower();

            return books.Where(book => 
            book.BookName.ToLower().Contains(searchTerm) ||
            (book.AlterName != null && book.AlterName.ToLower().Contains(searchTerm)) || 
            book.Author.AuthorName.ToLower().Contains(searchTerm)
            ).ToList();
        }

        public void GetBooksFromServer()
        {
            try
            {
                _jsonsender = new JSONSender();
                var messageToServer = new ClientMessage()
                {
                    Header = "GET_ALL_BOOKS",
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
                var serverMessage2 = _jsonsender.ServerMessageDeserialize(serverMessage);

                if (serverMessage2.Messagge == "ALL_BOOKS_LIST")
                {
                    books = serverMessage2.AllBooks;
                    allBooks = serverMessage2.AllBooks;
                    icons = CreateIconArray(books.Count);
                    ShowCurrentPage();
                }
                else
                {
                    MessageBox.Show("No books were found", "Повідомлення",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Нажаль сталась помилка:{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltersButton_Click(object sender, EventArgs e)
        {
            var bookSearch = new ListBookSearch();
            bookSearch.filteredBooks = allBooks;
            if(bookSearch.ShowDialog() == DialogResult.OK)
            {
                books = bookSearch.filteredBooks;
                ShowCurrentPage();
                SearchField.Text = string.Empty;
            }
        }

        //TODO: Delete Later
        public static List<Image> CreateIconArray(int numberOfIcons)
        {
            List <Image> images = new List<Image>();
            for (int i = 0; i < numberOfIcons; i++)
            {
                images.Add(Properties.Resources.No_Image_Available);
            }
            return images;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
        }
    }
}
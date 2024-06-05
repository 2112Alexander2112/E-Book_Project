using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EBookClient.UC_Control
{
    public partial class UC_MainPage : UserControl
    {

        private int currentPage = 0; 
        private int totalPages = 0; 
        private int booksPerPage = 12; 
        private UC_Book[] books;

        List<string> titles = new List<string> { "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист",
                "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист",
                "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист",
                "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист"};

        List<string> authors = new List<string> { "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex",
                "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex",
                "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex",
                "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex"};
        int totalBooks = 0;


        System.Drawing.Image[] icons = new System.Drawing.Image[48] {Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available,
            Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available, Properties.Resources.No_Image_Available };
        public UC_MainPage()
        {
            InitializeComponent();
        }

        void UC_Book_Click(object sender, EventArgs e)
        {
            var obj =(UC_Book)sender;
        }

        private void UC_MainPage_Load(object sender, EventArgs e)
        {
            ShowCurrentPage();
        }

        private void ShowCurrentPage()
        {
            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * booksPerPage;

            int remainingBooks = titles.Count - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = titles.Count;
            totalPages = (totalBooks + booksPerPage - 1) / booksPerPage;
            books = new UC_Book[booksToShow];

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new UC_Book();
                books[i].Title = titles[startIndex + i];
                books[i].Author = authors[startIndex + i];
                books[i].Icon = icons[startIndex + i];
                books[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(books[i]);
            }
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            buttonPreviousPage.Enabled = (currentPage > 0);
            buttonBack.Enabled = (currentPage > 0);

            buttonNext.Enabled = (currentPage < (titles.Count - 1) / booksPerPage);
            buttonNextFast.Enabled = (currentPage < (titles.Count - 1) / booksPerPage);
            textBox1.Text = (currentPage + 1).ToString();
        }

        /*
        private void UpdateBookList(List<Book> books)
        { 
            flowLayoutPanel1.Controls.Clear();

            foreach (var book in books)
            {        
                var bookControl = new UC_Book();
                bookControl.Title = 
                bookControl.Author = book.Author;
                bookControl.Icon = book.I; 

                flowLayoutPanel1.Controls.Add(bookControl);
            }
            
        }
        */

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

            List<string> filteredBooks = SearchItems(titles, query);
            List<string> filteredAuthors = SearchItems(titles, query);

            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * booksPerPage;

            int remainingBooks = filteredBooks.Count - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = filteredBooks.Count;
            totalPages = (totalBooks + booksPerPage - 1) / booksPerPage;
            books = new UC_Book[booksToShow];

            for (int i = 0; i < books.Length; i++)
            {
                books[i] = new UC_Book();
                books[i].Title = filteredBooks[startIndex + i];
                books[i].Author = filteredAuthors[startIndex + i];
                books[i].Icon = icons[startIndex + i];
                books[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(books[i]);
            }
            UpdateNavigationButtons();
        }

        static List<string> SearchItems(List<string> items, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return items;
            }

            searchTerm = searchTerm.ToLower();

            return items.Where(item => item.ToLower().Contains(searchTerm)).ToList();
        }
    }
    
}

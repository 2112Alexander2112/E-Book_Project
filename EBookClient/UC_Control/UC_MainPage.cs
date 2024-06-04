using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EBookClient.UC_Control
{
    public partial class UC_MainPage : UserControl
    {

        private int currentPage = 0; 
        private int totalPages = 0; 
        private int booksPerPage = 12; 
        private UC_Book[] books;

        string[] titles = new string[48] { "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист",
                "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист",
                "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист",
                "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист", "Самолет", "Автомат", "Битва", "Стрелок", "Парашутист"};

        string[] authors = new string[48] { "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex", "Dred", "John", "Tom", "Bob", "Alex",
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

            int remainingBooks = titles.Length - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = titles.Length;
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

            buttonNext.Enabled = (currentPage < (titles.Length - 1) / booksPerPage);
            buttonNextFast.Enabled = (currentPage < (titles.Length - 1) / booksPerPage);
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

            //List<Book> filteredBooks = allBooks.Where(book => book.Title.ToLower().Contains(query)).ToList();

            //UpdateBookList(filteredBooks);
        }
    }
    
}

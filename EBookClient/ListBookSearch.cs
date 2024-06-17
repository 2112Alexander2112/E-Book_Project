using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EBookClient
{
    public partial class ListBookSearch : Form
    {
        public List<Book> filteredBooks = new List<Book>();
        public ListBookSearch()
        {
            InitializeComponent();
            Published.Value = DateTime.Now.AddYears(-100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenreTextBox.Text = string.Empty;
            AuthorTextBox.Text = string.Empty;
            PriceTextBox.Text = string.Empty;
            PublisherTextBox.Text = string.Empty; 
            Published.Value = DateTime.Now.AddYears(-100);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (PriceTextBox.Text != string.Empty)
            {
                try
                {
                    decimal result = decimal.Parse(PriceTextBox.Text);
                    filteredBooks = filteredBooks.Where(book => book.Price < result).ToList();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid price.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }

            DateTime hundredYearsAgo = DateTime.Now.AddYears(-100);
            if (Published.Value != hundredYearsAgo)
            {
                filteredBooks = filteredBooks
                .Where(book => book.Published > Published.Value)
                .ToList();
            }

            string authorName = AuthorTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(authorName))
            {
                filteredBooks = filteredBooks
                .Where(book => book.Author.AuthorName.IndexOf(authorName, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            }
            string genreName = GenreTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(genreName))
            {
                filteredBooks = filteredBooks
                    .Where(book => book.Genre.GenreName.IndexOf(genreName, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            string publisherName = PublisherTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(publisherName))
            {
                filteredBooks = filteredBooks
                .Where(book => book.Publisher.PublisherName.IndexOf(publisherName, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

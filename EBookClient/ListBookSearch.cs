using EBookLib01;
using EBookLib01.BasicModels;
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
using static Guna.UI2.Native.WinApi;

namespace EBookClient
{
    public partial class ListBookSearch : Form
    {
        public List<Book> filteredBooks = new List<Book>();
        public ListBookSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenreTextBox.Text = string.Empty;
            AuthorTextBox.Text = string.Empty;
            PriceTextBox.Text = string.Empty;
            PublisherTextBox.Text = string.Empty;
            Published.Text = string.Empty;
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
                    // Optional: Log the exception or handle other types of exceptions if necessary
                    MessageBox.Show("An unexpected error occurred: " + ex.Message);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookClient
{
    public partial class AddBookForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=EBookServer.EF_ORM.DataManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_EBookServer_EF_ORM_DataManagerDataSet5.BookInfoes". При необходимости она может быть перемещена или удалена.
            this.bookInfoesTableAdapter.Fill(this._EBookServer_EF_ORM_DataManagerDataSet5.BookInfoes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_EBookServer_EF_ORM_DataManagerDataSet4.Publishers". При необходимости она может быть перемещена или удалена.
            this.publishersTableAdapter.Fill(this._EBookServer_EF_ORM_DataManagerDataSet4.Publishers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_EBookServer_EF_ORM_DataManagerDataSet3.Genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this._EBookServer_EF_ORM_DataManagerDataSet3.Genres);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_EBookServer_EF_ORM_DataManagerDataSet2.Authors". При необходимости она может быть перемещена или удалена.
            this.authorsTableAdapter.Fill(this._EBookServer_EF_ORM_DataManagerDataSet2.Authors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_EBookServer_EF_ORM_DataManagerDataSet1.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter1.Fill(this._EBookServer_EF_ORM_DataManagerDataSet1.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_EBookServer_EF_ORM_DataManagerDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this._EBookServer_EF_ORM_DataManagerDataSet.Categories);

            genresField.DisplayMember = "GenreName"; // Назва жанру
            genresField.ValueMember = "Id"; // Ідентифікатор жанру

            categoryField.DisplayMember = "CategoryName"; // Назва категорії
            categoryField.ValueMember = "Id"; // Ідентифікатор категорії

            authorField.DisplayMember = "AuthorName"; // Ім'я автора
            authorField.ValueMember = "Id"; // Ідентифікатор автора

            publishedField.DisplayMember = "PublisherName"; // Назва видавця
            publishedField.ValueMember = "Id"; // Ідентифікатор видавця

            bookInfoField.DisplayMember = "Info"; // Інформація про книгу
            bookInfoField.ValueMember = "Id";

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text) ||
               genresField.SelectedIndex < 0 ||
               categoryField.SelectedIndex < 0 ||
               authorField.SelectedIndex < 0 ||
               string.IsNullOrEmpty(publishedDateField.Text) ||
               publishedField.SelectedIndex < 0 ||
               string.IsNullOrEmpty(priceField.Text) ||
               string.IsNullOrEmpty(iconPathField.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int genreId = (int)genresField.SelectedValue;
                int categoryId = (int)categoryField.SelectedValue;
                int authorId = (int)authorField.SelectedValue;
                string bookName = nameField.Text;
                string alterName = alterNameField.Text;
                DateTime pubDate = DateTime.Parse(publishedDateField.Text);
                int publishedId = (int)publishedField.SelectedValue;
                int bookInfoId = (int)bookInfoField.SelectedValue;
                decimal price = decimal.Parse(priceField.Text);
                string iconPath = iconPathField.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Books (BookName, AlterName, Published, GenreId, CategoryId, AuthorId, PublisherId, BookInfoId, Price, IconPath) " +
                                   "VALUES (@BookName, @AlterName, @Published, @GenreId, @CategoryId, @AuthorId, @PublisherId, @BookInfoId, @Price, @IconPath)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookName", bookName);
                        command.Parameters.AddWithValue("@AlterName", alterName);
                        command.Parameters.AddWithValue("@Published", pubDate);
                        command.Parameters.AddWithValue("@GenreId", genreId);
                        command.Parameters.AddWithValue("@CategoryId", categoryId);
                        command.Parameters.AddWithValue("@AuthorId", authorId);
                        command.Parameters.AddWithValue("@PublisherId", publishedId);
                        command.Parameters.AddWithValue("@BookInfoId", bookInfoId);
                        command.Parameters.AddWithValue("@Price", price);
                        command.Parameters.AddWithValue("@IconPath", iconPath);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Книга успішно додана!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при додаванні книги: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

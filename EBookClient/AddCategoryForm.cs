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
    public partial class AddCategoryForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=EBookServer.EF_ORM.DataManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = categoryField.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO Categories (CategoryName) VALUES (@Name)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Name", categoryName);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Категорію додано успішно.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            categoryField.Clear();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Помилка додавання.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ви не ввели назву категорії.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

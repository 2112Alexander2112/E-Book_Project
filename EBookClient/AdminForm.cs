using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookClient
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var addCategoryForm = new AddCategoryForm();
            addCategoryForm.ShowDialog();
        }
    }
}

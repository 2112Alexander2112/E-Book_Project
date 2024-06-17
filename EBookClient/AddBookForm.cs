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
    public partial class AddBookForm : Form
    {
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

        }
    }
}

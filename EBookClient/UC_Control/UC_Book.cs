﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookClient.UC_Control
{
    public partial class UC_Book : UserControl
    {
        public UC_Book()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labes & Picture

        private Image _icon;
        private string _title;
        private string _author;
        private string _price;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ImageBox.Image = value; }
        }
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; TitleLabel.Text = value; }

        }
        [Category("Custom Props")]
        public string Author
        {
            get { return _author; }
            set { _author = value; AuthorLabel.Text = value; }
            //#endregion
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; PriceLabel.Text = value; }
            #endregion
        }

        #region Hover Effect
        private void UC_Book_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void UC_Book_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
        #endregion

        private void ImageBox_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void ImageBox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void AddToWishlistButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The book has been successfully added to your wishlist", "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The book has been successfully added to your order", "Message",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

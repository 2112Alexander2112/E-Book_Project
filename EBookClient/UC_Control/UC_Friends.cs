using System;
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
    public partial class UC_Friends : UserControl
    {
        public UC_Friends()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labes & Picture

        private Image _icon;
        private string _friendName;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ImageBox.Image = value; }
        }
        [Category("Custom Props")]
        public string Friend_Name
        {
            get { return _friendName; }
            set { _friendName = value; FriendNameLabel.Text = value; }
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

        private void Remove_Friend_Button_Click(object sender, EventArgs e)
        {

        }
    }
}

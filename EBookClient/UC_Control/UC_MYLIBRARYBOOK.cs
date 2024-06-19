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

namespace EBookClient.UC_Control
{
    public partial class UC_MYLIBRARYBOOK : UserControl
    {
        public IPAddress AddrDTO { get; set; }
        public int PortDTO { get; set; }

        public int BookId { get; set; }

        public int UserId { get; set; }
        public string JsonstringMessage { get; set; }
        public UC_MYLIBRARYBOOK()
        {
            InitializeComponent();
        }

        #region Getter & Setter For Labes & Picture

        private Image _icon;
        private string _title;
        private string _about;
        private string _date;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ImageBox.Image = value; }
        }
        [Category("Custom Props")]
        public string Titles
        {
            get { return _title; }
            set { _title = value; TitleLebel.Text = value; }

        }

        [Category("Custom Props")]
        public string Abouts
        {
            get { return _about; }
            set { _about = value; AboutLabel.Text = value; }

        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; DateLabel.Text = value; }

        }

        #endregion
    }
}

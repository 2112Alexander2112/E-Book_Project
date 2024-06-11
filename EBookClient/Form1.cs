using EBookLib01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace EBookClient
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                var auth = new AuthForm();
                if (auth.ShowDialog() == DialogResult.OK)
                {

                }
                this.Close();
        }

        private void AboutBook_Click(object sender, EventArgs e)
        {
        }
    }
}

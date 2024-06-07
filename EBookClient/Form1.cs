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
        private int _port;
        private IPAddress _ipAddres;
        private IPEndPoint _ep;
        private TcpClient _tcpClient;
        private JSONSender _jsonSender;
        public Form1()
        {
            InitializeComponent();
           
            _port = 9001;
            _ipAddres = IPAddress.Parse("127.0.0.1");
            _tcpClient = new TcpClient();
            _ep = new IPEndPoint(_ipAddres, _port);
            _jsonSender = new JSONSender();

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
            var searchForm = new BookSearch()
            {
                PortDTO = _port,
                AddrDTO = _ipAddres,
            };
            if (searchForm.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}

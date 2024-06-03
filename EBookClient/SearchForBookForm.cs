using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using EBookLib01.ServiceModels;
using EBookLib01.BasicacModels;
using EBookLib01.Services;


namespace EBookClient
{
    public partial class SearchForBookForm : Form
    {
        private int _port;
        private IPAddress _ipAddres;
        private IPEndPoint _ep;
        private TcpClient _tcpClient;
        
        private JSONSender _jsonSender;

        private string _login;
        private string _password;   
        public SearchForBookForm()
        {
            InitializeComponent();
            _jsonSender = new JSONSender();

            _port = 9001;
            _tcpClient = new TcpClient();
            _ep = new IPEndPoint(_ipAddres, _port);

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

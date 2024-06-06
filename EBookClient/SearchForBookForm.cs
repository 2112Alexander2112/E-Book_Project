using System;
using System.Windows.Forms;
using EBookLib01;
using System.Net.Sockets;
using System.Net;


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

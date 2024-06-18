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
using System.Windows.Forms;
using EBookLib01.HelperModels.TransitModels;
using EBookLib01.HelperModels;
using System.IO;
using System.Web.UI.WebControls;

using EBookLib01.BasicModels;
namespace EBookClient
{
    public partial class AuthForm : Form
    {

        private int _port;
        private IPAddress _ipAddres;
        private IPEndPoint _ep;
        private TcpClient _tcpClient;
        private JSONSender _jsonSender;
        public AuthForm()
        {
            InitializeComponent();

            _port = 9001;
            _ipAddres = IPAddress.Parse("127.0.0.1");
            _tcpClient = new TcpClient();
            _ep = new IPEndPoint(_ipAddres, _port);
            _jsonSender = new JSONSender();
        }

        private async void AuthButton_Click(object sender, EventArgs e)
        {
            string Login = LoginField.Text;
            string Password = PassField.Text;

            if (Login == "admin")
            {
                var adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
            else
            {
                if (string.IsNullOrEmpty(Login))
                {

            }
            else
            {
                if(string.IsNullOrEmpty(Password) )
                {
                    label2.Text = "Ви не ввели пароль";
                }
                else
                {
                    string hashPass = EBookLib01.HashManager.GetHash(Password);
                    var authUser = new User()
                    {
                        UserLogin = Login,
                        Password = hashPass,                      
                    };
                    var message = new ClientMessage()
                    {
                        Header = "AUTH_USER",
                        AuthUser = authUser
                    };
                    var jsonstring = _jsonSender.ClientMessageSerialize(message);
                    _tcpClient.Connect(_ipAddres, _port);

                    NetworkStream ns = _tcpClient.GetStream();
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(jsonstring);
                    sw.Flush();

                    StreamReader sr = new StreamReader(ns);
                    var serverMessage = sr.ReadLine();
                    var serverMessageDes = _jsonSender.ServerMessageDeserialize(serverMessage);

                    if (serverMessageDes.Messagge == "YESAUTH")
                    {
                        MessageBox.Show("Вітаю ви успішно увійшли",
                            "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        var Menu = new Menu(authUser.UserLogin);
                        Menu.currentUser = serverMessageDes.User;
                        Menu.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ви ввели не правильно логін або пароль",
                            "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    this.DialogResult = DialogResult.OK;

                }
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reg = new RegForm();
            reg.ShowDialog();
            this.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var reset = new PassResetForm();
            reset.ShowDialog();
            this.Show();
        }
    }
}

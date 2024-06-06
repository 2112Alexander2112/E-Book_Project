using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EBookLib01;
using EBookLib01.BasicModels;
using EBookLib01.TCPQueries;

namespace EBookClient
{
    public partial class AuthForm : Form
    {
        public readonly TcpQuery _query;
        public readonly IPEndPoint _ep;

        private Label[] labelsToClear;
        public AuthForm()
        {
            InitializeComponent();
            _query = new TcpQuery();
            _ep = new IPEndPoint(IPAddress.Any, 0);
            labelsToClear = new Label[] { label1, label2};
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string Login = LoginField.Text;
            string Password = PassField.Text;

            if (string.IsNullOrEmpty(Login) )
            {
                label1.Text = "Ви не ввели логін";
                timer1.Start();
            }
            else
            {
                if (string.IsNullOrEmpty(Password))
                {
                    label2.Text = "Ви не ввели пароль";
                    timer1.Start();
                }
                else
                {
                    var hashPass = HashManager.GetHash(Password);
                    var auth = new User()
                    {
                        Id = 0,
                        UserLogin = Login,
                        Email = "",
                        Password = hashPass,
                        RegDate = DateTime.Now,
                        PublicsherId = 0,
                        RoleId = 0,

                    };
                    var menu = new Menu();
                    /*var serverMess = _query.AuthUserTCP(auth, _ep);
                    switch(serverMess.Header)
                    {
                        case "OK":
                            this.Hide();
                            menu.ShowDialog();
                            break;
                        case "LOGIN_FAILED":
                            label1.Text = serverMess.Messagge;
                            timer1.Start();
                            break;
                        case "PASS_FAILED":
                            label1.Text = serverMess.Messagge;
                            timer1.Start();
                            break;
                    }*/
                    this.Hide();
                    menu.ShowDialog();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var label in labelsToClear)
            {
                label.Text = string.Empty;
            }

            timer1.Stop();
        }
    }
}

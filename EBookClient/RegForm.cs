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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using EBookLib01.HelperModels;
using EBookLib01.HelperModels.TransitModels;
using System.IO;

namespace EBookClient
{
    public partial class RegForm : Form
    {
        private int _port;
        private IPAddress _ipAddres;
        private IPEndPoint _ep;
        private TcpClient _tcpClient;
        private JSONSender _jsonSender;

        private Label[] labelsToClear;
        public EBookLib01.BasicModels.User RegModel;
        public RegForm()
        {
            InitializeComponent();
            labelsToClear = new Label[] { label1, label2, label3, label4, label5 };

            _port = 9001;
            _ipAddres = IPAddress.Parse("127.0.0.1");
            _tcpClient = new TcpClient();
            _ep = new IPEndPoint(_ipAddres, _port);
            _jsonSender = new JSONSender();
        }

        private void toggleSwitch1_CheckedChanged(object sender)
        {
            if(!toggleSwitch1.Checked)
            {
                RegButton.Enabled = false;
            }
            else
            {
                RegButton.Enabled = true;
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            string emai = EmailField.Text;
            string pass = PassField.Text;

            string copyEmail = CopyEmailField.Text;
            string copyPass = CopyPassField.Text;
            if(string.IsNullOrWhiteSpace(login) )
            {
                label1.Text = "Ви не заповнили поле Логін!";
                timer1.Start();
            }
            else
            {
                if(string.IsNullOrWhiteSpace(emai) )
                {
                    label2.Text = "Ви не заповнили поле Email!";
                    timer1.Start();
                }
                else
                {
                    if(copyEmail != emai)
                    {
                        label3.Text = "Email не збігається!";
                        timer1.Start();
                    }
                    else
                    {
                        if(string.IsNullOrWhiteSpace(pass) )
                        {
                            label4.Text = "Ви не заповнили поле Паролю!";
                            timer1.Start();
                        }
                        else
                        {
                            if (copyPass != pass)
                            {
                                label5.Text = "Пароль не збігається!";
                                timer1.Start();
                            }
                            else
                            {
                                string hashPass = EBookLib01.HashManager.GetHash(pass);
                                var data = new RegFormTransData()
                                {
                                    UserLogin = login,
                                    Password = hashPass,
                                    Email = emai,
                                    RegDate = DateTime.Now,
                                    PublisherId = 1
                                };
                                var message = new ClientMessage()
                                {
                                    Header = "REG_USER",
                                    RegTrans = data
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

                                if(serverMessageDes.Messagge == "YESREG")
                                {
                                    MessageBox.Show("Вітаю ви успішно зареєструвались",
                                        "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Реєстрація провалена! Користувач з таким логіном вже існує",
                                        "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                //string regMess = $"REG_USER:{login}:{emai}:{hashPass}:{DateTime.Now}:{1}";
                                //byte[] reguser = Encoding.UTF8.GetBytes(regMess);
                                this.DialogResult = DialogResult.OK;
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var label in labelsToClear)
            {
                label.Text = string.Empty;
            }

            timer1.Stop();
        }

        private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

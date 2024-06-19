using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using EBookLib01;
using EBookLib01.BasicModels;
using EBookLib01.HelperModels.TransitModels;

namespace EBookClient
{
    public partial class PassResetForm : Form
    {
        private int _port;
        private IPAddress _ipAddres;
        private IPEndPoint _ep;
        private TcpClient _tcpClient;
        private JSONSender _jsonSender;
        public PassResetForm()
        {
            InitializeComponent();
            _port = 9001;
            _ipAddres = IPAddress.Parse("127.0.0.1");
            _tcpClient = new TcpClient();
            _ep = new IPEndPoint(_ipAddres, _port);
            _jsonSender = new JSONSender();
        }
    

        private void ResetPassButton_Click(object sender, EventArgs e)
        {
            string email = EmailField.Text;
            if(string.IsNullOrWhiteSpace(email) )
            {
                label1.Text = "Ви не ввели email";
            }
            else
            {
                string pass = NewPassField.Text;
                if (string.IsNullOrWhiteSpace(pass) )
                {
                    label2.Text = "Ви не ввели новий пароль";
                }
                else
                {
                    string copyPass = CopyNewPassField.Text;
                    if (copyPass == pass)
                    {
                        label3.Text = "Ваш пароль не совпадает";
                    }
                    else
                    {

                        string hashPass = EBookLib01.HashManager.GetHash(copyPass);
                        var resetPass = new User()
                        {
                            Email = email,
                            Password = hashPass,
                        };
                        var message = new ClientMessage()
                        {
                            Header = "RESET_PASS",
                            AuthUser = resetPass
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

                        if (serverMessageDes.Messagge == "RESET_PASSWORD:OK")
                        {
                            MessageBox.Show("Вітаю ви успішно змінили пароль",
                                "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;

                        }
                        if (serverMessageDes.Messagge == "RESET_PASSWORD:FALSE")
                        {
                            MessageBox.Show("Користувача з таким email не знайдено!",
                                "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            label1.Text = "Користувач з таким Email не існує";
                        }
                        if (serverMessageDes.Messagge == "RESET_PASSWORD:ERROR")
                        {
                            MessageBox.Show("Трапилась помилка на сервері!",
                                    "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void PassResetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

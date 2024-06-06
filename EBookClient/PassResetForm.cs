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
using EBookLib01;
using EBookLib01.TCPQueries;

namespace EBookClient
{
    public partial class PassResetForm : Form
    {
        public readonly TcpQuery _query;
        public readonly IPEndPoint _ep;

        private Label[] labelsToClear;
        public PassResetForm()
        {
            InitializeComponent();
            _query = new TcpQuery();
            _ep = new IPEndPoint(IPAddress.Any, 0);
            labelsToClear = new Label[] { label1, label2, label3 };
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
                string copyPass = CopyNewPassField.Text;
                if (string.IsNullOrWhiteSpace(pass) )
                {
                    label2.Text = "Ви не ввели новий пароль";
                }
                else
                {
                    if (copyPass != pass)
                    {
                        label3.Text = "Ваш пароль не совпадает";
                    }
                    else
                    {
                        string hashPass = HashManager.GetHash(copyPass);
                        string resetMess = $"{email}#{hashPass}";
                        var serverMess = _query.ResetPassTCP(resetMess, _ep);
                        switch (serverMess.Header)
                        {
                            case "OK":
                                this.DialogResult = DialogResult.OK;
                                break;
                            case "FAILED":
                                label1.Text = serverMess.Messagge;
                                break;
                        }
                    }
                }
            }
        }

        private void PassResetForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using EBookLib01.BasicacModels;

namespace EBookClient
{
    public partial class RegForm : Form
    {
        private Label[] labelsToClear;
        public EBookLib01.BasicModels.User RegModel;
        public RegForm()
        {
            InitializeComponent();
            labelsToClear = new Label[] { label1, label2, label3, label4, label5 };     
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
                                string regMess = $"REG_USER:{login}:{emai}:{hashPass}:{DateTime.Now}:{1}";
                                byte[] reguser = Encoding.UTF8.GetBytes(regMess);
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

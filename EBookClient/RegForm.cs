using EBookLIb.Models;
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
using EBookLIb.Models;

namespace EBookClient
{
    public partial class RegForm : Form
    {
        private Label[] labelsToClear;
        public User RegModel;
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
                            if(copyPass != pass )
                            {
                                label5.Text = "Пароль не збігається!";
                                timer1.Start();
                            }
                            else
                            {
                                RegModel = new User()
                                {
                                    Id = 0, UserLogin = login, Email = emai, Password = pass, RegDate = DateTime.Now, RoleId = 1
                                };
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
    }
}

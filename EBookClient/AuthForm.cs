using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookClient
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string Login = LoginField.Text;
            string Password = PassField.Text;

            if (string.IsNullOrEmpty(Login) )
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

                    string mess = "";
                    string[] path = mess.Split(':');
                    if ("AUTH_OK" == path[0])
                    {
                        //label2.Text = path[1];
                    }
                    else
                    {
                        this.Hide();
                        var Menu = new Menu();
                        Menu.ShowDialog();
                        this.Hide();
                        
                    }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var reset = new PassResetForm();
            reset.ShowDialog();
            this.Show();
        }
    }
}

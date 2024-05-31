using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EBookClient.Controls;
using EBookLIb;
using EBookLIb.Models;
using EBookLIb.Packages;

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
                }
                else
                {
                    string hashPass = HashManager.GetHash(Password);
                    var mess = Login + ":" + hashPass;
                    byte[] bytes = Encoding.UTF8.GetBytes(mess);
                    var bag = new Package()
                    {
                        Host = "GET_AUTH",
                        Message = bytes
                    };
                }
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            var reg = new RegForm();
            var modelReg = new User();
            if(reg.ShowDialog() == DialogResult.OK)
            {
                modelReg = reg.RegModel;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reset = new PassResetForm();
            if(reset.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

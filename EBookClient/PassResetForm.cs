using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EBookLib01;

namespace EBookClient
{
    public partial class PassResetForm : Form
    {
        public PassResetForm()
        {
            InitializeComponent();
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
                        string hashPass = HashManager.GetHash(copyPass);
                        string resetMess = $"RESET_PASS:{email}:{hashPass}";
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

using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookClient.UC_Control
{
    public partial class UC_MyProfile : UserControl
    {
        User currentUser = new User
        {
            Id = 1,
            UserLogin = "sampleUser",
            Email = "sampleUser@example.com",
            Password = "password123",
            RegDate = DateTime.Now,
            RoleId = 1,
            PublisherId = 1,
            Friends = new List<Friend>(),
            Role = new Role { Id = 1, RoleName = "Admin" },
            Publisher = new Publisher { Id = 1, PublisherName = "Sample Publisher" }
        };
        public UC_MyProfile(string userLogin)
        {
            InitializeComponent();
            currentUser.UserLogin = userLogin;
        }

        private void UC_MyProfile_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Text = currentUser.UserLogin;
            UsernameTextBox.Enabled = false;
            EmailTextBox.Text = currentUser.Email;
            EmailTextBox.Enabled = false;
            PasswordTextBox.Text = currentUser.Password;
            PasswordTextBox.Enabled = false;
            dateTimePicker1.Value = currentUser.RegDate;
            dateTimePicker1.Enabled = false;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));
            bool hasMinLength = password.Length >= 8;

            return hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && hasMinLength;
        }
        


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Text == "Change")
            {
                button1.Text = "Save";
                PasswordTextBox.Enabled = true;
                dateTimePicker1.Enabled = true;
                EmailTextBox.Enabled = true;
                UsernameTextBox.Enabled = true;
            }
            else
            {
                if (IsValidPassword(PasswordTextBox.Text) && IsValidEmail(EmailTextBox.Text))
                {
                    button1.Text = "Change";
                    PasswordTextBox.Enabled = false;
                    currentUser.Password = PasswordTextBox.Text;
                    dateTimePicker1.Enabled = false;
                    currentUser.RegDate = dateTimePicker1.Value;
                    EmailTextBox.Enabled = false;
                    currentUser.Email = EmailTextBox.Text;
                    UsernameTextBox.Enabled = false;
                    currentUser.UserLogin = UsernameTextBox.Text;
                    MessageBox.Show("Data successfuly updated");
                }
                else
                {
                    MessageBox.Show("Please enter valid password");
                }
            }
        }
    }
}

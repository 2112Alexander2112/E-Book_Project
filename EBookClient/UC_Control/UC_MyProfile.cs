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
            Wishlist = new List<Wishlist>(),
            MyLibraries = new List<MyLibrary>(),
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
            GenderComboBox.Enabled = false;
        }

        private void ChangeUsernameButton_Click(object sender, EventArgs e)
        {
            if(ChangeUsernameButton.Text == "Change")
            {
                ChangeUsernameButton.Text = "Save";
                UsernameTextBox.Enabled = true;
            }
            else
            {
                ChangeUsernameButton.Text = "Change";
                UsernameTextBox.Enabled = false;
                MessageBox.Show("Username changed to " + UsernameTextBox.Text);
                currentUser.UserLogin = UsernameTextBox.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChangeEmailButton.Text == "Change")
            {
                ChangeEmailButton.Text = "Save";
                EmailTextBox.Enabled = true;
            }
            else
            {
                if (IsValidEmail(EmailTextBox.Text))
                {
                    ChangeEmailButton.Text = "Change";
                    EmailTextBox.Enabled = false;
                    MessageBox.Show("Email changed to " + EmailTextBox.Text);
                    currentUser.Email = EmailTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Please enter valid email");
                }
            }
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
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (ChangePasswordButton.Text == "Change")
            {
                ChangePasswordButton.Text = "Save";
                PasswordTextBox.Enabled = true;
            }
            else
            {
                if (IsValidPassword(PasswordTextBox.Text))
                {
                    ChangePasswordButton.Text = "Change";
                    PasswordTextBox.Enabled = false;
                    MessageBox.Show("Password changed to " + PasswordTextBox.Text);
                    currentUser.Password = PasswordTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Please enter valid password");
                }
            }
        }

        private void ChangeDateOfBirthButton_Click(object sender, EventArgs e)
        {
            if (ChangeDateOfBirthButton.Text == "Change")
            {
                ChangeDateOfBirthButton.Text = "Save";
                dateTimePicker1.Enabled = true;
            }
            else
            {
                ChangeDateOfBirthButton.Text = "Change";
                dateTimePicker1.Enabled = false;
                MessageBox.Show("DateOfBirth changed to " + dateTimePicker1.Value);
                currentUser.RegDate = dateTimePicker1.Value;
            }
        }
    }
}

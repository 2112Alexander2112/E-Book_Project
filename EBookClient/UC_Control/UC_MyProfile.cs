using EBookLib01;
using EBookLib01.BasicModels;
using EBookLib01.HelperModels.TransitModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace EBookClient.UC_Control
{
    public partial class UC_MyProfile : UserControl
    {
        public User currentUser { get; set; }
        private JSONSender _jsonsender;
        public IPAddress AddrDTO { get; set; }
        public int PortDTO { get; set; }
        public string JsonstringUpdateUserMessage { get; set; }

        public UC_MyProfile(string userLogin)
        {
            InitializeComponent();
        }

        private void UC_MyProfile_Load(object sender, EventArgs e)
        {
            
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
        public void FillData()
        {
            UsernameTextBox.Text = currentUser.UserLogin;
            UsernameTextBox.Enabled = false;
            EmailTextBox.Text = currentUser.Email;
            EmailTextBox.Enabled = false;
            PasswordTextBox.Text = "";
            PasswordTextBox.Enabled = false;
            dateTimePicker1.Value = currentUser.RegDate;
            dateTimePicker1.Enabled = false;
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
                if ((IsValidPassword(PasswordTextBox.Text) || PasswordTextBox.Text == "") && IsValidEmail(EmailTextBox.Text))
                {
                    try
                    {
                        if(PasswordTextBox.Text != "")
                        {
                            currentUser.Password = ComputeMD5Hash(PasswordTextBox.Text);
                        }
                        currentUser.UserLogin = UsernameTextBox.Text;
                        currentUser.Email = EmailTextBox.Text;
                        currentUser.RegDate = dateTimePicker1.Value;
                        _jsonsender = new JSONSender();
                        var messageToServer = new ClientMessage()
                        {
                            Header = "UPDATE_USER",
                            AuthUser = currentUser,
                        };
                        JsonstringUpdateUserMessage = _jsonsender.ClientMessageSerialize(messageToServer);

                        var client = new TcpClient();
                        client.Connect(AddrDTO, PortDTO);

                        NetworkStream ns = client.GetStream();
                        StreamWriter sw = new StreamWriter(ns);
                        sw.WriteLine(JsonstringUpdateUserMessage);
                        sw.Flush();


                        StreamReader sr = new StreamReader(ns);
                        var serverMessage = sr.ReadLine();
                        var serverMessage2 = _jsonsender.ServerMessageDeserialize(serverMessage);

                        if (serverMessage2.Messagge == "UPDATE_USER:OK")
                        {
                            button1.Text = "Change";
                            PasswordTextBox.Enabled = false;
                            dateTimePicker1.Enabled = false;
                            EmailTextBox.Enabled = false;
                            UsernameTextBox.Enabled = false;
                            MessageBox.Show("Data successfuly updated");
                        }
                        else
                        {
                            MessageBox.Show(serverMessage2.Messagge);
                            MessageBox.Show("Error was encountered", "Повідомлення",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Нажаль сталась помилка:{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid email or password");
                }
            }
        }
        public static string ComputeMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }


}

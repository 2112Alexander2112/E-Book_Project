using EBookLib01.HelperModels.TransitModels;
using EBookLib01;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace EBookClient.UC_Control
{
    public partial class UC_Book : UserControl
    {

        public IPAddress AddrDTO { get; set; }
        public int PortDTO { get; set; }
        private JSONSender _jsonsender;

        public int BookId { get; set; }

        public int UserId { get; set; }
        public string JsonstringMessage { get; set; }
        public UC_Book(bool isWishlisted)
        {
            InitializeComponent();
            if(isWishlisted)
            {
                AddToWishlistButton.Text = "Remove from wishlist";
            }
            else
            {
                AddToWishlistButton.Text = "Add to wishlist";
            }
        }

        #region Getter & Setter For Labes & Picture

        private Image _icon;
        private string _title;
        private string _author;
        private string _price;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ImageBox.Image = value; }
        }
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; TitleLabel.Text = value; }

        }
        [Category("Custom Props")]
        public string Author
        {
            get { return _author; }
            set { _author = value; AuthorLabel.Text = value; }
            //#endregion
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; PriceLabel.Text = value; }
            #endregion
        }

        #region Hover Effect
        private void UC_Book_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void UC_Book_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
        #endregion

        private void ImageBox_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242);
        }

        private void ImageBox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void AddToWishlistButton_Click(object sender, EventArgs e)
        {
            if (AddToWishlistButton.Text == "Add to wishlist")
            {
                try
                {
                    _jsonsender = new JSONSender();
                    var messageToServer = new ClientMessage()
                    {
                        Header = "ADD_WHISHLIST",
                        UserId = UserId,
                        BookId = BookId,
                    };
                    JsonstringMessage = _jsonsender.ClientMessageSerialize(messageToServer);

                    var client = new TcpClient();

                    client.Connect(AddrDTO, PortDTO);

                    NetworkStream ns = client.GetStream();
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(JsonstringMessage);
                    sw.Flush();


                    StreamReader sr = new StreamReader(ns);
                    var serverMessage = sr.ReadLine();
                    var serverMessage2 = _jsonsender.ServerMessageDeserialize(serverMessage);

                    if (serverMessage2.Messagge == "WISHLIST:OK")
                    {
                        MessageBox.Show("The book has been successfully added to your wishlist", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Occured", "Warning",
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
                try
                {
                    _jsonsender = new JSONSender();
                    var messageToServer = new ClientMessage()
                    {
                        Header = "REMOVE_WHISHLIST",
                        UserId = UserId,
                        BookId = BookId
                    };
                    JsonstringMessage = _jsonsender.ClientMessageSerialize(messageToServer);

                    var client = new TcpClient();
                    client.Connect(AddrDTO, PortDTO);

                    NetworkStream ns = client.GetStream();
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(JsonstringMessage);
                    sw.Flush();


                    StreamReader sr = new StreamReader(ns);
                    var serverMessage = sr.ReadLine();
                    var serverMessage2 = _jsonsender.ServerMessageDeserialize(serverMessage);

                    if (serverMessage2.Messagge == "WISHLIST:OK")
                    {
                        MessageBox.Show("The book has been successfully removed from your wishlist", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error Occured", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Нажаль сталась помилка:{ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void AddToOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                _jsonsender = new JSONSender();
                var messageToServer = new ClientMessage()
                {
                    Header = "ADD_ORDER",
                    UserId = UserId,
                    BookId = BookId,
                };
                JsonstringMessage = _jsonsender.ClientMessageSerialize(messageToServer);

                using (var client = new TcpClient())
                {
                    await client.ConnectAsync(AddrDTO, PortDTO);

                    using (NetworkStream ns = client.GetStream())
                    using (StreamWriter sw = new StreamWriter(ns))
                    using (StreamReader sr = new StreamReader(ns))
                    {
                        await sw.WriteLineAsync(JsonstringMessage);
                        await sw.FlushAsync();

                        var serverMessage = await sr.ReadLineAsync();
                        var serverMessage2 = _jsonsender.ServerMessageDeserialize(serverMessage);

                        if (serverMessage2.Messagge == "ADD_ORDER:OK")
                        {
                            MessageBox.Show("The book was successfully purchased", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error Occurred", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Нажаль сталась помилка: {ex.Message}", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

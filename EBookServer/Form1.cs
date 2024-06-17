using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

using EBookLib01;
using EBookLib01.HelperModels.TransitModels;
using EBookServer.EF_ORM;
using EBookLib01.HelperModels;
using EBookLib01.BasicModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace EBookServer
{
    public partial class Form1 : Form
    {
        private readonly int _numberOfUsers;
        private int _port;
        private string _clientMessage;

        private IPAddress _ipAdress;
        private IPEndPoint _ep;
        private TcpListener _tcpListener;
        private Thread _listenerThread;

        private DataManager _shopDb;
        private JSONSender _jsonSender;
        public Form1()
        {
            InitializeComponent();
            _port = 9001;
            _ipAdress = IPAddress.Parse("127.0.0.1");
            _ep = new IPEndPoint(_ipAdress, _port);
            _shopDb = new DataManager();
            _numberOfUsers = 20;
            _jsonSender = new JSONSender();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tcpListener = new TcpListener(_ep);
            _tcpListener.Start(_numberOfUsers);

            _listenerThread = new Thread(new ThreadStart(MainLoop));
            _listenerThread.IsBackground = true;
            _listenerThread.Start();
        }
        private async void MainLoop()
        {
            //try
            //{
            while (true)
            {
                TcpClient client = _tcpListener.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                StreamReader sr = new StreamReader(ns);
                _clientMessage = sr.ReadLine();
                ClientMessage clientMessage = _jsonSender.ClientMessageDeserialize(_clientMessage);

                switch (clientMessage.Header)
                {
                    /*
                    case "SHOWBOOK":
                        var searchbook = _shopDb.Books
                            .Where(b => b.BookName == clientMessage.SeacrhingBook).FirstOrDefault();
                        if (//searchbook == null)
                        {
                            var serverMessage = new ServerMessage()
                            {
                                Messagge = "NOTFINDED"
                            };
                            var response = _jsonSender.ServerMessageSerialize(serverMessage);
                            StreamWriter streaWriter = new StreamWriter(ns);

                            streaWriter.WriteLine(response);
                            streaWriter.Flush();

                            sw.Close();
                            sr.Close();
                            ns.Close();
                        }
                        else
                        {
                            var genre = _shopDb.Genres.Where(g => g.Id == searchbook.GenreId).First();
                            var publisher = _shopDb.Publishers.Where(p => p.Id == searchbook.PublisherId).First();
                            var autor = _shopDb.Authors.Where(a => a.Id == searchbook.AuthorId).First();
                            var infoaboutbook = new AboutBookModel()
                            {
                                Price = Convert.ToString(searchbook.Price),
                                Genre = genre.GenreName,
                                AlterName = searchbook.AlterName,
                                Publisher = publisher.PublisherName,
                                Published = Convert.ToString(searchbook.Published),
                                Author = autor.AuthorName
                            };
                            var findedBookMessage = new ServerMessage()
                            {
                                Messagge = "BOOKFOUNDED",
                                About = infoaboutbook
                            };
                            var findedBook = _jsonSender.ServerMessageSerialize(findedBookMessage);
                            StreamWriter streaWriter = new StreamWriter(ns);
                            streaWriter.WriteLine(findedBook);
                            streaWriter.Flush();

                            //sw.Close();
                            //sr.Close();
                            //ns.Close();
                        }
                        break;
                    */
                    case "REG_USER":
                        var verUser = _shopDb.Users
                           .Where(b => b.UserLogin == clientMessage.RegTrans.UserLogin).FirstOrDefault();
                        if (verUser != null)
                        {
                            var serverMessage = new ServerMessage()
                            {
                                Messagge = "NOREG"
                            };
                            var response = _jsonSender.ServerMessageSerialize(serverMessage);
                            StreamWriter streamWritter = new StreamWriter(ns);

                            streamWritter.WriteLine(response);
                            streamWritter.Flush();

                            //sw.Close();
                            //sr.Close();
                            //ns.Close();
                        }
                        else
                        {
                            var newUser = new User()
                            {
                                UserLogin = clientMessage.RegTrans.UserLogin,
                                RoleId = 1,
                                RegDate = DateTime.Now,
                                Email = clientMessage.RegTrans.Email,
                                PublisherId = clientMessage.RegTrans.PublisherId,
                                Password = clientMessage.RegTrans.Password,
                            };
                           
                            _shopDb.Users.Add(newUser);
                            _shopDb.SaveChanges();
                               
                           
                            var refMessage = new ServerMessage()
                            {
                                Messagge = "YESREG",
                            };
                            var regOk = _jsonSender.ServerMessageSerialize(refMessage);
                            StreamWriter streaWriter = new StreamWriter(ns);
                            streaWriter.WriteLine(regOk);
                            streaWriter.Flush();

                            //sw.Close();
                            //sr.Close();
                            //ns.Close();
                        }
                        break;
                    case "AUTH_USER":
                        var authUserLogin = _shopDb.Users
                          .Where(b => b.UserLogin == clientMessage.AuthUser.UserLogin).FirstOrDefault();
                        var authUserPassw = _shopDb.Users
                          .Where(b => b.UserLogin == clientMessage.AuthUser.Password).FirstOrDefault();
                        if (authUserLogin != null || authUserPassw != null)
                        {
                            var refMessage = new ServerMessage()
                            {
                                Messagge = "YESAUTH",
                            };
                            var regOk = _jsonSender.ServerMessageSerialize(refMessage);
                            StreamWriter streamWriter = new StreamWriter(ns);
                            streamWriter.WriteLine(regOk);
                            streamWriter.Flush();
                            //sw.Close();
                            //sr.Close();
                            //ns.Close();
                        }
                        else
                        {
                            var serverMessage = new ServerMessage()
                            {
                                Messagge = "NOAUTH"
                            };
                            var response = _jsonSender.ServerMessageSerialize(serverMessage);
                            StreamWriter streamWritter = new StreamWriter(ns);

                            streamWritter.WriteLine(response);
                            streamWritter.Flush();
                        }
                            break;
                    case "GET_BOOK":
                        break;
                    case "GET_ALL_BOOKS":
                        List<Book> allBooks = _shopDb.Books.ToList();
                        var allBooksMessage = new ServerMessage()
                        {
                            Messagge = "ALL_BOOKS_LIST",
                            AllBooks = allBooks
                        };

                        var booksSerialized = _jsonSender.ServerMessageSerialize(allBooksMessage);
                        StreamWriter sw = new StreamWriter(ns);
                        sw.WriteLine(booksSerialized);
                        sw.Flush();
                        break;
                    case "ADD_WHISHLIST":
                        var whishlistMessage = new ServerMessage();
                        try
                        {
                            var newWishlist = new Wishlist
                            {
                                Id = -1,
                                UserId = clientMessage.UserId,
                                BookId = clientMessage.BookId,
                            };
                            _shopDb.Wishlists.Add(newWishlist);
                            _shopDb.SaveChanges();
                            whishlistMessage.Messagge = "WISHLIST:OK";
                        }catch (Exception ex)
                        {
                            whishlistMessage.Messagge = "WISHLIST:ERROR";
                        }
                        

                        var whishlist = _jsonSender.ServerMessageSerialize(whishlistMessage);
                        StreamWriter streamW = new StreamWriter(ns);
                        streamW.WriteLine(whishlist);
                        streamW.Flush();
                        break;
                    case "GET_WHISHLIST":
                        var getWhishlistMessage = new ServerMessage();
                        try
                        {
                            var booksInWishlist = _shopDb.Wishlists
                                          .Where(w => w.UserId == clientMessage.UserId)
                                          .Select(w => w.Book)
                                          .Distinct()
                                          .ToList();

                            getWhishlistMessage.Messagge = "WHISHLIST_BOOKS:OK";
                            getWhishlistMessage.AllBooks = booksInWishlist;

                        }catch (Exception ex)
                        {
                            getWhishlistMessage.Messagge = "WHISHLIST_BOOKS:ERROR";
                        }
                        var wishlistBooks = _jsonSender.ServerMessageSerialize(getWhishlistMessage);
                        StreamWriter stw = new StreamWriter(ns);
                        stw.WriteLine(wishlistBooks);
                        stw.Flush();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

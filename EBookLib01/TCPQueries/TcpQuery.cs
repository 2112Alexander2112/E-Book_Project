using EBookLib01.BasicModels;
using EBookLib01.HelperModels.TransitModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookLib01.TCPQueries
{

        public class TcpQuery
        {
            private TcpListener _tcpListener;
            private Thread _listenerThread;
            JSONSender js = new JSONSender();
            public List<Book> GetBooksFromServer(IPEndPoint ep)
            {
                List<Book> books = new List<Book>();
                ServerMessage response = new ServerMessage();

                TcpClient client = null;
                NetworkStream ns = null;
                StreamWriter sw = null;
                StreamReader sr = null;

                try
                {
                    client = new TcpClient();
                    ClientMessage message = new ClientMessage()
                    {
                        Header = "GET_BOOKS"
                    };
                    string clientMess = js.ClientMessageSerialize(message);
                    client.Connect(ep);

                    ns = client.GetStream();
                    sw = new StreamWriter(ns);
                    sw.WriteLine(clientMess);
                    sw.Flush();

                    sr = new StreamReader(ns);
                    var serverMessage = sr.ReadLine();
                    response = js.ServerMessageDeserialize(serverMessage);

                    sw.Close();
                    sr.Close();
                    ns.Close();

                    client.Close();
                    books = response.Books;
                    return books;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка отримання списку книг: ${ex.Message}", "Повідомлення");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (sr != null) sr.Close();
                    if (ns != null) ns.Close();
                    if (client != null) client.Close();
                }
                return books;
            }

            public ServerMessage RegUserQueryTcp(User model, IPEndPoint ep)
            {
                ServerMessage response = new ServerMessage();
                TcpClient client = null;
                NetworkStream ns = null;
                StreamWriter sw = null;
                StreamReader sr = null;

                try
                {
                    client = new TcpClient();
                    ClientMessage message = new ClientMessage()
                    {
                        Header = "GET_BOOKS",
                        RegUser = model,

                    };
                    string clientMess = js.ClientMessageSerialize(message);
                    client.Connect(ep);

                    ns = client.GetStream();
                    sw = new StreamWriter(ns);
                    sw.WriteLine(clientMess);
                    sw.Flush();

                    sr = new StreamReader(ns);
                    var serverMessage = sr.ReadLine();
                    response = js.ServerMessageDeserialize(serverMessage);

                    sw.Close();
                    sr.Close();
                    ns.Close();

                    client.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка реєстрації користувача: ${ex.Message}", "Повідомлення");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (sr != null) sr.Close();
                    if (ns != null) ns.Close();
                    if (client != null) client.Close();
                }
                return response;
            }

            public ServerMessage AuthUserTCP(User model, IPEndPoint ep)
            {
                ServerMessage response = new ServerMessage();
                TcpClient client = null;
                NetworkStream ns = null;
                StreamWriter sw = null;
                StreamReader sr = null;

                try
                {
                    client = new TcpClient();
                    ClientMessage message = new ClientMessage()
                    {
                        Header = "AUTH_USER",
                        RegUser = model,

                    };
                    string clientMess = js.ClientMessageSerialize(message);
                    client.Connect(ep);

                    ns = client.GetStream();
                    sw = new StreamWriter(ns);
                    sw.WriteLine(clientMess);
                    sw.Flush();

                    sr = new StreamReader(ns);
                    var serverMessage = sr.ReadLine();
                    response = js.ServerMessageDeserialize(serverMessage);

                    sw.Close();
                    sr.Close();
                    ns.Close();

                    client.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка Ауторизації користувача: ${ex.Message}", "Повідомлення");
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (sr != null) sr.Close();
                    if (ns != null) ns.Close();
                    if (client != null) client.Close();
                }
                return response;
            }

        public ServerMessage ResetPassTCP(string mess, IPEndPoint ep)
        {
            ServerMessage response = new ServerMessage();
            TcpClient client = null;
            NetworkStream ns = null;
            StreamWriter sw = null;
            StreamReader sr = null;

            try
            {
                client = new TcpClient();
                ClientMessage message = new ClientMessage()
                {
                    Header = "RESET_PASS",
                    ResetPass = mess,

                };
                string clientMess = js.ClientMessageSerialize(message);
                client.Connect(ep);

                ns = client.GetStream();
                sw = new StreamWriter(ns);
                sw.WriteLine(clientMess);
                sw.Flush();

                sr = new StreamReader(ns);
                var serverMessage = sr.ReadLine();
                response = js.ServerMessageDeserialize(serverMessage);

                sw.Close();
                sr.Close();
                ns.Close();

                client.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка Ауторизації користувача: ${ex.Message}", "Повідомлення");
            }
            finally
            {
                if (sw != null) sw.Close();
                if (sr != null) sr.Close();
                if (ns != null) ns.Close();
                if (client != null) client.Close();
            }
            return response;
        }
    }
}

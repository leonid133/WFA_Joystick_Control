using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace WFA_Joystick_Control
{
    class TcpIpLaurentConnector
    {
        private string m_login;
        private string m_psw;
        private System.Net.IPAddress m_ip_net;
        private string m_ip;
        private int m_port;
        private TcpClient m_Client;
        private Socket m_Sock;

        public TcpIpLaurentConnector()
        {
            m_login = "admin";
            m_psw = "123";
            m_ip = "192.168.0.110";
            m_port = 2424;

            try
            {
                m_ip_net = System.Net.IPAddress.Parse(m_ip);
                m_Client = new TcpClient();
                m_Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
        }

        public void SetPSW(string psw)
        {
            m_psw = psw;
        }
        public void SetLogin(string login)
        {
            m_login = login;
        }
        public void SetIP(string ip)
        {
            m_ip = ip;
            try
            {
                m_ip_net = System.Net.IPAddress.Parse(m_ip);
                // Display the address in standard notation.
                Console.WriteLine("Parsing your input IP string: " + "\"" + m_ip + "\"" + " produces this address (shown in its standard notation): "+ m_ip_net.ToString());
            }

            catch(ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }

            catch(FormatException e)
            {
                Console.WriteLine("FormatException caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
        }
        public void SetPort(int port)
        {
            m_port = port;
        }
        public void SetPort(string port)
        {
            try
            {
                m_port = Convert.ToInt32(port);
            }
            catch(Exception e)
            {
                Console.WriteLine("Cannot convert Port string to int!");
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
        }
        private void Connect(String server, String message, Int32 port)
        {

            try
            {

                TcpClient client = new TcpClient(server, port);
                NetworkStream stream = client.GetStream();
                message += "\r\n";
                Byte[] bytes = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(bytes, 0, bytes.Length);
                
                message = "$KE";
                message += ",PSW,SET,";
                message += m_psw;
                message += "\r\n";
                Byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(bytes2, 0, bytes.Length);

                message = "";
                message += "$KE";
                message += ",REL,";
                message += "1";
                message += ",1";
                message += "\r\n";
                Byte[] bytes3 = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(bytes3, 0, bytes.Length);

                bytes = new Byte[256];
                String responseData = String.Empty;

                Int32 i = stream.Read(bytes, 0, bytes.Length);
                responseData = System.Text.Encoding.UTF8.GetString(bytes, 0, i);
                System.Windows.Forms.MessageBox.Show(responseData, message);
                client.Close();

            }

            catch (Exception e)
            {

                // ошибка соединения

            }

        } // end connection
        public string ConnectToLaurent()
        {
            Connect(m_ip, "$KE;", m_port);
            if (m_Client.Connected)
                Disconnect();
            string result="";
            //string connection_string = "$KE";
            string connection_string = "GET / HTTP/1.1";
            byte[] remdata = { };
           
            try
            {
                m_Client.Connect(m_ip_net, m_port);
                m_Sock = m_Client.Client;
                
                //m_Sock.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.Type, SocketType.Unknown);
                //m_Sock.SetSocketOption(SocketOptionLevel.Tcp, SocketOptionName.ReceiveTimeout, 1000);
                /*
                m_Sock.Send(Encoding.ASCII.GetBytes(connection_string), Encoding.ASCII.GetBytes(connection_string).Length, SocketFlags.None );
                m_Sock.Receive(remdata, m_Sock.Available, SocketFlags.None);
                result = System.Text.Encoding.UTF8.GetString(remdata).TrimEnd('\0');
                */
               Stream networkStream = m_Client.GetStream();
               StreamReader clientStremReader = new StreamReader(networkStream);
               StreamWriter clientStremWriter = new StreamWriter(networkStream);
               clientStremWriter.Write(connection_string);
           
               result = clientStremReader.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Cannot connect to remote host!");
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
                return "Cannot connect to remote host!";
            }
           
            
            return result;
        }
        public string LoginToLaurent()
        {
            string connection_string = "$KE";
            connection_string += ",PSW,SET,";
            connection_string += m_psw;
            byte[] remdata = { };
            
            //m_Sock = m_Client.Client;
            try
            {
                m_Sock.Send(Encoding.ASCII.GetBytes(connection_string));
            }
            catch
            {
                Console.WriteLine("Cannot connect to remote host!");
                return "Cannot connect to remote host!";
            }
            m_Sock.Receive(remdata);
            
            string result;
            result = System.Text.Encoding.UTF8.GetString(remdata).TrimEnd('\0');
            return result;
        }

        public string OnRel(string rele_number_string)
        {
            string connection_string = "";
            connection_string += "$KE";
            connection_string += ",REL,";
            connection_string += rele_number_string;
            connection_string += ",1";
            byte[] remdata = { };

            //m_Sock = m_Client.Client;
            try
            {
                m_Sock.Send(Encoding.ASCII.GetBytes(connection_string));
            }
            catch
            {
                Console.WriteLine("Cannot connect to remote host!");
                return "Cannot connect to remote host!";
            }
            m_Sock.Receive(remdata);

            string result;
            result = System.Text.Encoding.UTF8.GetString(remdata).TrimEnd('\0');
            return result;
        }

        public string OffRel(string rele_number_string)
        {
            string connection_string = "";
            connection_string += "$KE";
            connection_string += ",REL,";
            connection_string += rele_number_string;
            connection_string += ",1";
            byte[] remdata = { };

            //m_Sock = m_Client.Client;
            try
            {
                m_Sock.Send(Encoding.ASCII.GetBytes(connection_string));
            }
            catch
            {
                Console.WriteLine("Cannot connect to remote host!");
                return "Cannot connect to remote host!";
            }
            m_Sock.Receive(remdata);

            string result;
            result = System.Text.Encoding.UTF8.GetString(remdata).TrimEnd('\0');
            return result;
        }
        public void Disconnect()
        {
            if (m_Client.Connected)
            {
                if (m_Sock.Connected)
                    m_Sock.Close();
                m_Client.Close();
            }
        }
        ~TcpIpLaurentConnector()
        {
            if (m_Client.Connected)
            {
                if (m_Sock.Connected)
                    m_Sock.Close();
                m_Client.Close();
            }
        }
        
    }
}

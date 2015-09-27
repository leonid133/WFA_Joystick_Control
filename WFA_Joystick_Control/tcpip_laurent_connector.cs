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

        public TcpIpLaurentConnector()
        {
            m_login = "admin";
            m_psw = "123";
            m_ip = "192.168.0.110";
            m_port = 2424;

            try
            {
                m_ip_net = System.Net.IPAddress.Parse(m_ip);
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
        private String Connect(String server, String message, Int32 port)
        {
            String result = "";
            try
            {
                TcpClient tcpClient = new TcpClient(server, port);

                // Uses the GetStream public method to return the NetworkStream.
                NetworkStream netStream = tcpClient.GetStream();

                if (netStream.CanWrite)
                {
                    Byte[] sendBytes = Encoding.UTF8.GetBytes(message);
                    netStream.Write(sendBytes, 0, sendBytes.Length);
                }
                else
                {
                    Console.WriteLine("You cannot write data to this stream.");
                    tcpClient.Close();

                    // Closing the tcpClient instance does not close the network stream.
                    netStream.Close();
                    return result;
                }

                if (netStream.CanRead)
                {
                    // Reads NetworkStream into a byte buffer.
                    byte[] bytes = new byte[tcpClient.ReceiveBufferSize];

                    // Read can return anything from 0 to numBytesToRead. 
                    // This method blocks until at least one byte is read.
                    netStream.Read(bytes, 0, (int)tcpClient.ReceiveBufferSize);

                    // Returns the data received from the host to the console.
                    string returndata = Encoding.UTF8.GetString(bytes);
                    returndata += "\r\n";
                   // Console.WriteLine("This is what the host returned to you: " + returndata);
                    result = returndata;
                }
                else
                {
                    Console.WriteLine("You cannot read data from this stream.");
                    tcpClient.Close();

                    // Closing the tcpClient instance does not close the network stream.
                    netStream.Close();
                    return result;
                }
                tcpClient.Close();
                netStream.Close();
                return result;
            }

            catch (Exception e)
            {

                // ошибка соединения
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
                return result;
            }

        } // end connection

        public string ConnectToLaurent()
        {
            return  Connect(m_ip, "$KE\r\n", m_port);
        }
        public string LoginToLaurent()
        {
            string connection_string = "$KE";
            connection_string += ",PSW,SET,";
            connection_string += m_psw;
            connection_string += "\r\n";

            return Connect(m_ip, connection_string, m_port); 
        }

        public string OnRel(string rele_number_string)
        {
            string connection_string = "";
            connection_string += "$KE";
            connection_string += ",REL,";
            connection_string += rele_number_string;
            connection_string += ",1";
            connection_string += "\r\n";
            return Connect(m_ip, connection_string, m_port);
        }

        public string OffRel(string rele_number_string)
        {
            string connection_string = "";
            connection_string += "$KE";
            connection_string += ",REL,";
            connection_string += rele_number_string;
            connection_string += ",0";
            connection_string += "\r\n";
            return Connect(m_ip, connection_string, m_port);
        }
       
        ~TcpIpLaurentConnector()
        {
            
        }
        
    }
}

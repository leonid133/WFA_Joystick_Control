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
        private bool m_connect_succes;
        private TcpClient m_tcpClient;
        private NetworkStream m_netStream;
        private bool m_need_read;

        public TcpIpLaurentConnector()
        {
            m_login = "admin";
            m_psw = "123";
            m_ip = "192.168.0.110";
            m_port = 2424;
            m_connect_succes = false;
            m_need_read = false;

            try
            {
                m_ip_net = System.Net.IPAddress.Parse(m_ip);
                m_tcpClient = new TcpClient();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
        }
        public bool GetConnectionStatus()
        {
            return m_connect_succes;
        }
        public void NeedRead(bool need_read)
        {
            m_need_read = need_read;
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

        private String SendMessage( String message )
        {
            String result = "";
            try
            {
                if (m_connect_succes)
                {
                    if (m_netStream.CanWrite)
                    {
                        Byte[] sendBytes = Encoding.UTF8.GetBytes(message);
                        m_netStream.Write(sendBytes, 0, sendBytes.Length);
                        result += "отправлено:" + message;
                    }
                    else
                    {
                        CloseConnection();
                        return result;
                    }

                    if (m_need_read && m_netStream.CanRead)
                    {
                        // Reads NetworkStream into a byte buffer.
                        byte[] bytes = new byte[m_tcpClient.ReceiveBufferSize];

                        // Read can return anything from 0 to numBytesToRead. 
                        // This method blocks until at least one byte is read.
                        m_netStream.Read(bytes, 0, (int)m_tcpClient.ReceiveBufferSize);

                        // Returns the data received from the host to the console.
                        string returndata = Encoding.UTF8.GetString(bytes);
                        returndata += "\r\n";
                        // Console.WriteLine("This is what the host returned to you: " + returndata);
                        result += "получено:" + returndata;
                    }
                    else
                    {
                        if(m_need_read)
                            CloseConnection();
                        return result;
                    }
                }
                else
                {
                    result = "Подключение отсутствует";
                }
            }

            catch (Exception e)
            {
                // ошибка соединения
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
                result += "Произошла Ошибка \r\n";
                result += " Source : " + e.Source;
                result += " Message : " + e.Message;
                CloseConnection();
                return result;
            }
            return result;
        }

        private String Connect(String server, String message, Int32 port)
        {
            String result = "";
            try
            {
                if (m_connect_succes)
                {
                    result += SendMessage(message);
                }
                else
                {
                    m_tcpClient.Connect(server, port);
                    m_netStream = m_tcpClient.GetStream();

                    m_tcpClient.ReceiveTimeout = 1000;
                    m_tcpClient.SendTimeout = 100;

                    m_connect_succes = true;
                    result += "Успешное подключение.";
                    result += SendMessage(message);
                }
                return result;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
                result += "Произошла Ошибка \r\n";
                result += " Source : " + e.Source;
                result += " Message : " + e.Message;
            }
            
            return result;
        } // end connection

        private string LoginToLaurent()
        {
            string connection_string = "$KE";
            connection_string += ",PSW,SET,";
            connection_string += m_psw;
            connection_string += "\r\n";
            return SendMessage(connection_string);
        }

        public string ConnectToLaurent()
        {
            String answer_message = m_ip + ":" + m_port + ";";
            answer_message += Connect(m_ip, "$KE\r\n", m_port);
            answer_message += LoginToLaurent();
            return answer_message;
        }



        public string OnRel(string rele_number_string)
        {
            string connection_string = "";
            connection_string += "$KE";
            connection_string += ",REL,";
            connection_string += rele_number_string;
            connection_string += ",1";
            connection_string += "\r\n";
            return SendMessage(connection_string);
        }

        public string OffRel(string rele_number_string)
        {
            string connection_string = "";
            connection_string += "$KE";
            connection_string += ",REL,";
            connection_string += rele_number_string;
            connection_string += ",0";
            connection_string += "\r\n";
            return SendMessage(connection_string);
        }
       
        private void CloseConnection()
        {
            m_connect_succes = false;
            try
            {
                m_tcpClient.Close();
                m_netStream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!!!");
                Console.WriteLine("Source : " + e.Source);
                Console.WriteLine("Message : " + e.Message);
            }
        }

        ~TcpIpLaurentConnector()
        {
            if (m_connect_succes)
            {
                CloseConnection();
            }
        }
        
    }
}

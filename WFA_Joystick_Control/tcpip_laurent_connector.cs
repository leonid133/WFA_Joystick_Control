using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

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
            m_Client = new TcpClient();
            m_ip_net = System.Net.IPAddress.Parse(m_ip);
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
            m_ip_net = System.Net.IPAddress.Parse(m_ip);
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
            catch (System.Exception ex)
            {
                Console.WriteLine("Cannot convert Port string to int!");
            }
        }
        public string ConnectToLaurent()
        {
            string connection_string = "$KE";
            byte[] remdata = { };
            try
            {
                if (!m_Client.Connected)
                {
                    m_Client.Connect(m_ip_net, m_port);
                    m_Sock = m_Client.Client;
                }
            }
            catch
            {
                Console.WriteLine("Cannot connect to remote host!");
                return "Cannot connect to remote host!";
            }
            
            m_Sock.Send(Encoding.ASCII.GetBytes(connection_string));
            m_Sock.Receive(remdata);
            string result;
            result = System.Text.Encoding.UTF8.GetString(remdata).TrimEnd('\0');
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
            if (m_Sock.Connected)
                m_Sock.Close();
            if (m_Client.Connected)
                m_Client.Close();
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

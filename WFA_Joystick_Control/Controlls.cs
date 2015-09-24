using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFA_Joystick_Control
{
    class Controlls
    {

        public Controlls()
        {
        }
        public void UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
        }
        public void UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
        }

        public void DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
        }
        public void DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
        }

        public void LeftOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
        }
        public void LeftOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
        }

        public void RightOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
        }
        public void RightOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
        }

        ~Controlls()
        {
        }
    }
}

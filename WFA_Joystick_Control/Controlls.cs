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
            tcp_connectorB.OnRel("1");
        }
        public void UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("1");
        }

        public void DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("2");
        }
        public void DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("2");
        }

        public void LeftOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("8");
        }
        public void LeftOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("8");
        }

        public void RightOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("7");
        }
        public void RightOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("7");
        }
        public void FoldingUpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("9");
        }
        public void FoldingUpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("9");
        }
        public void FoldingDownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("10");
        }
        public void FoldingDownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("10");
        }
        public void FixFoldingUpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorB.OnRel("11");
        }
        public void FixFoldingUpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorB.OffRel("11");
        }
        public void GunUpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("5");
        }
        public void GunUpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("5");
        }

        public void GunDownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("6");
        }
        public void GunDownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("6");
        }

        public void GunLeftOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("4");
        }
        public void GunLeftOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("4");
        }

        public void GunRightOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("3");
        }
        public void GunRightOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("3");
        }
        public void ProjectorOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorB.OnRel("12");
        }
        public void ProjectorOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorB.OffRel("12");
        }
        public void CamOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("12");
        }
        public void CamOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("12");
        }
        public void OptionalEquipment1UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("4");
        }
        public void OptionalEquipment1UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("4");
        }

        public void OptionalEquipment1DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("5");
        }
        public void OptionalEquipment1DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("5");
        }
        public void OptionalEquipment2UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("6");
        }
        public void OptionalEquipment2UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("6");
        }

        public void OptionalEquipment2DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("7");
        }
        public void OptionalEquipment2DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("7");
        }
        public void OptionalEquipment3UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("8");
        }
        public void OptionalEquipment3UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("8");
        }

        public void OptionalEquipment3DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("9");
        }
        public void OptionalEquipment3DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("9");
        }
        public void OptionalEquipment4UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("10");
        }
        public void OptionalEquipment4UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("10");
        }

        public void OptionalEquipment4DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OnRel("1");
            tcp_connectorB.OnRel("11");
        }
        public void OptionalEquipment4DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            tcp_connectorA.OffRel("1");
            tcp_connectorB.OffRel("11");
        }
        ~Controlls()
        {
        }
    }
}

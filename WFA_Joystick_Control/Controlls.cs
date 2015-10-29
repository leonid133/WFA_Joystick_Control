using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFA_Joystick_Control
{
    class Controlls
    {
        public String stateA;
        public String stateB;
        bool[] A;
        bool[] B;

        public Controlls()
        {
            A = new bool[13];
            B = new bool[13];
            for (int i=0; i<13; ++i)
            {
                A[i]=false;
                B[i]=false;
            }
        }
        private bool A1Off_tester()
        {
            if (A[1] && !B[1] && !B[2] && !B[3] && !B[4] && !B[5] && !B[6] && !B[7] && !B[8] && !B[9] && !B[10] && !A[2] && !A[3] && !A[4] && !A[5] && !A[6] && !A[7] && !A[8] && !A[9] && !A[10] && !A[11])
                return true;
            else
                return false;
        }

        public void GetState(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            stateA = tcp_connectorA.GetRDR();
            stateB = tcp_connectorB.GetRDR();
        }
        public void UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[1])
            {
                tcp_connectorB.OnRel("1");
                B[1] = true;
            }
        }
        public void UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[1])
            {
                tcp_connectorB.OffRel("1");
                B[1] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[2])
            {
                tcp_connectorB.OnRel("2");
                B[2] = true;
            }
        }
        public void DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[2])
            {
                tcp_connectorB.OffRel("2");
                B[2] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void LeftOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[8])
            {
                tcp_connectorB.OnRel("8");
                B[8] = true;
            }
        }
        public void LeftOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[8])
            {
                tcp_connectorB.OffRel("8");
                B[8] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void RightOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[7])
            {
                tcp_connectorB.OnRel("7");
                B[7] = true;
            }
        }
        public void RightOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[7])
            {
                tcp_connectorB.OffRel("7");
                B[7] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void FoldingUpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[9])
            {
                tcp_connectorB.OnRel("9");
                B[9] = true;
            }
        }
        public void FoldingUpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[9])
            {
                tcp_connectorB.OffRel("9");
                B[9] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void FoldingDownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[10])
            {
                tcp_connectorB.OnRel("10");
                B[10] = true;
            }
        }
        public void FoldingDownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[10])
            {
                tcp_connectorB.OffRel("10");
                B[10] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void FixFoldingUpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!B[11])
            {
                tcp_connectorB.OnRel("11");
                B[11] = true;
            }
        }
        public void FixFoldingUpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[11])
            {
                tcp_connectorB.OffRel("11");
                B[11] = false;
            }
        }
        public void FoldingLeftOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[2])
            {
                tcp_connectorB.OnRel("2");
                A[2] = true;
            }
        }
        public void FoldingLeftOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[2])
            {
                tcp_connectorB.OffRel("2");
                A[2] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void FoldingRightOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[3])
            {
                tcp_connectorB.OnRel("3");
                A[3] = true;
            }
        }
        public void FoldingRightOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[3])
            {
                tcp_connectorB.OffRel("3");
                A[3] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void GunUpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[5])
            {
                tcp_connectorB.OnRel("5");
                B[5] = true;
            }
        }
        public void GunUpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[5])
            {
                tcp_connectorB.OffRel("5"); 
                B[5] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }

        }

        public void GunDownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[6])
            {
                tcp_connectorB.OnRel("6");
                B[6] = true;
            }
        }
        public void GunDownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[6])
            {
                tcp_connectorB.OffRel("6");
                B[6] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void GunLeftOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[4])
            {
                tcp_connectorB.OnRel("4");
                B[4] = true;
            }
        }
        public void GunLeftOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[4])
            {
                tcp_connectorB.OffRel("4");
                B[4] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void GunRightOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!B[3])
            {
                tcp_connectorB.OnRel("3");
                B[3] = true;
            }
        }
        public void GunRightOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[3])
            {
                tcp_connectorB.OffRel("3");
                B[3] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void ProjectorOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!B[12])
            {
                tcp_connectorB.OnRel("12");
                B[12] = true;
            }
        }
        public void ProjectorOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (B[12])
            {
                tcp_connectorB.OffRel("12");
                B[12] = false;
            }
        }
        public void CamOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[12])
            {
                tcp_connectorA.OnRel("12");
                A[12] = true;
            }
        }
        public void CamOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[12])
            {
                tcp_connectorA.OffRel("12");
                A[12] = false;
            }
        }
        public void OptionalEquipment1UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[4])
            {
                tcp_connectorA.OnRel("4");
                A[4] = true;
            }
        }
        public void OptionalEquipment1UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[4])
            {
                tcp_connectorA.OffRel("4");
                A[4] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void OptionalEquipment1DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[5])
            {
                tcp_connectorA.OnRel("5");
                A[5] = true;
            }
        }
        public void OptionalEquipment1DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[5])
            {
                tcp_connectorA.OffRel("5");
                A[5] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void OptionalEquipment2UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[6])
            {
                tcp_connectorA.OnRel("6");
                A[6] = true;
            }
        }
        public void OptionalEquipment2UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[6])
            {
                tcp_connectorA.OffRel("6");
                A[6] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void OptionalEquipment2DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[7])
            {
                tcp_connectorA.OnRel("7");
                A[7] = true;
            }
        }
        public void OptionalEquipment2DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[7])
            {
                tcp_connectorA.OffRel("7");
                A[7] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void OptionalEquipment3UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[8])
            {
                tcp_connectorA.OnRel("8");
                A[8] = true;
            }
        }
        public void OptionalEquipment3UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[8])
            {
                tcp_connectorA.OffRel("8");
                A[8] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void OptionalEquipment3DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[9])
            {
                tcp_connectorA.OnRel("9");
                A[9] = true;
            }
        }
        public void OptionalEquipment3DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[9])
            {
                tcp_connectorA.OffRel("9");
                A[9] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        public void OptionalEquipment4UpOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[10])
            {
                tcp_connectorA.OnRel("10");
                A[10] = true;
            }
        }
        public void OptionalEquipment4UpOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[10])
            {
                tcp_connectorA.OffRel("10");
                A[10] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }

        public void OptionalEquipment4DownOn(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (!A[1])
            {
                tcp_connectorA.OnRel("1");
                A[1] = true;
            }
            if (!A[11])
            {
                tcp_connectorA.OnRel("11");
                A[11] = true;
            }
        }
        public void OptionalEquipment4DownOff(ref TcpIpLaurentConnector tcp_connectorA, ref TcpIpLaurentConnector tcp_connectorB)
        {
            if (A[11])
            {
                tcp_connectorA.OffRel("11");
                A[11] = false;
            }
            if (A1Off_tester())
            {
                tcp_connectorA.OffRel("1");
                A[1] = false;
            }
        }
        ~Controlls()
        {
        }
    }
}

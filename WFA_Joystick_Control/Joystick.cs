using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.DirectInput;
using System.Windows.Forms;
using System;

namespace WFA_Joystick_Control

{
    class Joystick
    {
          #region param

        private IntPtr hWnd;

        private List<Guid> m_systemJoysticks;

        private Device m_joystickDevice;
        private JoystickState m_state;
        
        public int m_Xaxis; 
        public int m_Yaxis;
        public int m_Zaxis;

        public int m_AXaxis;
        public int m_AYaxis;
        public int m_AZaxis;
        
        public int m_VXaxis;
        public int m_VYaxis;
        public int m_VZaxis;

        public int m_FXaxis;
        public int m_FYaxis;
        public int m_FZaxis;

        public int m_Rx;
        public int m_Ry;
        public int m_Rz;


        public String m_State;

        public bool[] m_buttons;

        private bool[] m_axiss_found;

        #endregion

        public Joystick(IntPtr window_handle)
        {
            hWnd = window_handle;

            m_Xaxis = -1;
        }
 
        public List<Guid> FindJoysticks()
        {
            m_systemJoysticks = new List<Guid>();
            
            try
            {
                // Find all the GameControl devices that are attached.
                DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);

                // check that we have at least one device.
                if (gameControllerList.Count > 0)
                {
                    foreach (DeviceInstance deviceInstance in gameControllerList)
                    {
                        // create a device from this controller so we can retrieve info.
                        m_joystickDevice = new Device(deviceInstance.InstanceGuid);
                        m_joystickDevice.SetCooperativeLevel(hWnd, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);

                        m_systemJoysticks.Add( m_joystickDevice.DeviceInformation.InstanceGuid );

                        //break;
                    }
                }
            }
            catch
            {
                return null;
            }

            return m_systemJoysticks;
        }

        public bool AcquireJoystick( Guid guid )
        {
            
            try
            {
                DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);
                int number_device = 0;
                bool found_J1 = false;

                foreach (DeviceInstance deviceInstance in gameControllerList)
                {

                    if (deviceInstance.InstanceGuid == guid )
                    {
                        found_J1 = true;
                        m_joystickDevice = new Device(deviceInstance.InstanceGuid);
                        m_joystickDevice.SetCooperativeLevel(hWnd, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);
                        break;
                    }
                    
                    number_device++;
                }

                if (!found_J1 )
                    return false;

                m_joystickDevice.SetDataFormat(DeviceDataFormat.Joystick);
                m_joystickDevice.Acquire();

                Poll();
                CheckAxisFound();
                UpdateStatus();
            }
            catch (Exception err)
            {
                return false;
            }

            return true;
        }

        private void CheckAxisFound()
        {
            m_axiss_found = new bool[25];
            int[] extraAxis = m_state.GetSlider();
            if (m_state.X == 0)
                m_axiss_found[0] = false;
            else
                m_axiss_found[0] = true;
            if (m_state.Y == 0)
                m_axiss_found[1] = false;
            else
                m_axiss_found[1] = true;
            if (m_state.Z == 0)
                m_axiss_found[2] = false;
            else
                m_axiss_found[2] = true;

            int[] extraAxisAcceleration = m_state.GetASlider();
            if (m_state.AX == 0)
                m_axiss_found[3] = false;
            else
                m_axiss_found[3] = true;
            if (m_state.AY == 0)
                m_axiss_found[4] = false;
            else
                m_axiss_found[4] = true;
            if (m_state.AZ == 0)
                m_axiss_found[5] = false;
            else
                m_axiss_found[5] = true;

            int[] extraAxisVelocity = m_state.GetVSlider();
            if (m_state.VX == 0)
                m_axiss_found[6] = false;
            else
                m_axiss_found[6] = true;
            if (m_state.VY == 0)
                m_axiss_found[7] = false;
            else
                m_axiss_found[7] = true;
            if (m_state.VZ == 0)
                m_axiss_found[8] = false;
            else
                m_axiss_found[8] = true;

            int[] extraAxisForce = m_state.GetFSlider();
            if (m_state.FX == 0)
                m_axiss_found[9] = false;
            else
                m_axiss_found[9] = true;
            if (m_state.FY == 0)
                m_axiss_found[10] = false;
            else
                m_axiss_found[10] = true;
            if (m_state.FZ == 0)
                m_axiss_found[11] = false;
            else
                m_axiss_found[11] = true;

            if (m_state.Rx == 0)
                m_axiss_found[12] = false;
            else
                m_axiss_found[12] = true;
            if (m_state.Ry == 0)
                m_axiss_found[13] = false;
            else
                m_axiss_found[13] = true;
            if (m_state.Rz == 0)
                m_axiss_found[14] = false;
            else
                m_axiss_found[14] = true;

            if (m_state.ARx == 0)
                m_axiss_found[15] = false;
            else
                m_axiss_found[15] = true;
            if (m_state.ARy == 0)
                m_axiss_found[16] = false;
            else
                m_axiss_found[16] = true;
            if (m_state.ARz == 0)
                m_axiss_found[17] = false;
            else
                m_axiss_found[17] = true;

            
        }

        public void ReleaseJoystick()
        {
            m_joystickDevice.Unacquire();
        }

        public void UpdateStatus()
        {
            Poll();
            
            int[] extraAxis = m_state.GetSlider();
            m_State = " ";

            m_Xaxis = m_state.X; // X+ X-
            if (m_Xaxis == 0 && m_axiss_found[0])
                m_State += "X- ";
            else if (m_Xaxis == 65535)
                m_State += "X+ ";
            m_Yaxis = m_state.Y; // Y+ Y- 
            if (m_Yaxis == 0 && m_axiss_found[1])
                m_State += "Y- ";
            else if (m_Yaxis == 65535)
                m_State += "Y+ ";
            m_Zaxis = m_state.Z; // Z+ Z-
            if (m_Zaxis == 0 && m_axiss_found[2])
                m_State += "Z- ";
            else if (m_Zaxis == 65535)
                m_State += "Z+ ";
            
            int[] extraAxisAcceleration = m_state.GetASlider();
            m_AXaxis = m_state.AX; // AX+ AX-
            if (m_AXaxis == 0 && m_axiss_found[3])
                m_State += "AX- ";
            else if (m_AXaxis == 65535)
                m_State += "AX+ ";
            m_AYaxis = m_state.AY; // AY+ AY-
            if (m_AYaxis == 0 && m_axiss_found[4])
                m_State += "AY- ";
            else if (m_AYaxis == 65535)
                m_State += "AY+ ";
            m_AZaxis = m_state.AZ; // AZ+ AZ-
            if (m_AZaxis == 0 && m_axiss_found[5])
                m_State += "AZ- ";
            else if (m_AZaxis == 65535)
                m_State += "AZ+ ";

            int[] extraAxisVelocity = m_state.GetVSlider();
            m_VXaxis = m_state.VX; // VX+ VX-
            if (m_VXaxis == 0 && m_axiss_found[6])
                m_State += "VX- ";
            else if (m_VXaxis == 65535)
                m_State += "VX+ ";
            m_VYaxis = m_state.VY; // VY+ VY-
            if (m_VYaxis == 0 && m_axiss_found[7])
                m_State += "VY- ";
            else if (m_VYaxis == 65535)
                m_State += "VY+ ";
            m_VZaxis = m_state.VZ; // VZ+ VZ-
            if (m_VZaxis == 0 && m_axiss_found[8])
                m_State += "VZ- ";
            else if (m_VZaxis == 65535)
                m_State += "VZ+ ";

            int[] extraAxisForce = m_state.GetFSlider();
            m_FXaxis = m_state.FX; // FX+ FX-
            if (m_FXaxis == 0 && m_axiss_found[9])
                m_State += "FX- ";
            else if (m_FXaxis == 65535)
                m_State += "FX+ ";
            m_FYaxis = m_state.FY; // FY+ FY-
            if (m_FYaxis == 0 && m_axiss_found[10])
                m_State += "FY- ";
            else if (m_FYaxis == 65535)
                m_State += "FY+ ";
            m_FZaxis = m_state.FZ; // FZ+ FZ-
            if (m_FZaxis == 0 && m_axiss_found[11])
                m_State += "FZ- ";
            else if (m_FZaxis == 65535)
                m_State += "FZ+ ";

            m_Rx = m_state.Rx;
            if (m_Rx == 0 && m_axiss_found[12])
                m_State += "RX- ";
            else if (m_Rx == 65535)
                m_State += "RX+ ";
            m_Ry = m_state.Ry;
            if (m_Ry == 0 && m_axiss_found[13])
                m_State += "RY- ";
            else if (m_Ry == 65535)
                m_State += "RY+ ";
            m_Rz = m_state.Rz;
            if (m_Rz == 0 && m_axiss_found[14])
                m_State += "RZ- ";
            else if (m_Rz == 65535)
                m_State += "RZ+ ";

            if ( m_state.ARx == 0 && m_axiss_found[15])
                m_State += "ARX- ";
            else if (m_state.ARx == 65535)
                m_State += "ARX+ ";
            if (m_state.ARy == 0 && m_axiss_found[16])
                m_State += "ARY- ";
            else if (m_state.ARy == 65535)
                m_State += "ARY+ ";
            if (m_state.ARz == 0 && m_axiss_found[17])
                m_State += "ARZ- ";
            else if (m_Rz == 65535)
                m_State += "ARZ+ ";

            int[] views = m_state.GetPointOfView();
            int[] pofviews_j = new int[views.Length];

            int it_pov = 0;
            foreach (int PofV in views)
            {
                pofviews_j[it_pov] = PofV;
                if (it_pov == 0) 
                { 
                    if(pofviews_j[it_pov] == 0)
                        m_State += "P_Up";
                    else if (pofviews_j[it_pov] == 27000)
                        m_State += "P_Le";
                    else if (pofviews_j[it_pov] == 9000)
                        m_State += "P_Ri";
                    else if (pofviews_j[it_pov] == 18000)
                        m_State += "P_Do";
                }
                ++it_pov;
            }
            
            byte[] jsButtons_J = m_state.GetButtons();
            m_buttons = new bool[jsButtons_J.Length];

            int it_button_J1 = 0; // B#
            foreach (byte button in jsButtons_J)
            {
                m_buttons[it_button_J1] = button >= 128;
                if (m_buttons[it_button_J1])
                {
                    m_State += "B";
                    m_State += it_button_J1;
                    m_State += " ";
                }
                it_button_J1++;
            }
            
        }

        private void Poll()
        {
            try
            {
                m_joystickDevice.Poll();
                m_state = m_joystickDevice.CurrentJoystickState;
            }
            catch
            {
                throw (null);
            }
        }
    }
    }

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
        public bool[] m_buttons;

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

                UpdateStatus();
            }
            catch 
            {
                return false;
            }

            return true;
        }

        public void ReleaseJoystick()
        {
            m_joystickDevice.Unacquire();
        }

        public void UpdateStatus()
        {
            Poll();

            int[] extraAxis_J1 = m_state.GetSlider();
            
            m_Xaxis = m_state.X;
            m_Yaxis = m_state.Y;

            byte[] jsButtons_J1 = m_state.GetButtons();
            m_buttons = new bool[jsButtons_J1.Length];

            int it_button_J1 = 0;
            foreach (byte button in jsButtons_J1)
            {
                m_buttons[it_button_J1] = button >= 128;
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

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX.DirectInput;
using System.Windows.Forms;
using System;

namespace WFA_Joystick_Control
{
    class Keybord
    {
        #region param
        public Microsoft.DirectX.DirectInput.Device m_keyboard_device;
        private IntPtr hWnd;

        #endregion

        public Keybord(IntPtr window_handle)
        {
            hWnd = window_handle;
            
        }
        public void InitializeKeyboard()
        {
            m_keyboard_device = new Microsoft.DirectX.DirectInput.Device(SystemGuid.Keyboard);
            m_keyboard_device.SetCooperativeLevel(hWnd, CooperativeLevelFlags.Background | CooperativeLevelFlags.NonExclusive);
            m_keyboard_device.Acquire();
        }
    }
}

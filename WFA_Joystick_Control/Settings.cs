using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.DirectInput;

using eKey = Microsoft.DirectX.DirectInput.Key;
using System.Text.RegularExpressions;

namespace WFA_Joystick_Control
{
    public partial class Form_Settings : Form
    {
        private eKey m_current_button;
        private KeyboardConfiguration m_kb_config = new KeyboardConfiguration();
        private Keybord m_keybord;

        private JoystickConfiguration m_joy_config = new JoystickConfiguration();
        private Joystick m_joystick;
        private bool[] m_joystickButtons_J1;
        private Joystick m_joystick2;
        private bool[] m_joystickButtons_J2;
        private bool m_joy2_connected;

        public Form_Settings()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }

            m_keybord = new Keybord(this.Handle);
            m_keybord.InitializeKeyboard();

            m_joystick = new Joystick(this.Handle);
            m_joystick2 = new Joystick(this.Handle);
            MessageBox.Show("Внимание! Пожалуйста подключите джойстики и переведите все оси, всех подключенных джойстиков в центральное положение, и не нажимайте кнопок в течении 5 секунд.");
            connectToJoysticks(m_joystick, m_joystick2);
            Refresh();
        }

         private string NiceName(string raw_name)
         {
             if (raw_name.Length == 2 && raw_name[0] == 'D')
                 return raw_name[1].ToString();
             if (raw_name == "DownArrow")
                 return "Down";
             if (raw_name == "LeftArrow")
                 return "Left";
             return raw_name;
         }

        public override void Refresh()
        {
            
            button_w.Text = NiceName(m_kb_config.keyboard_map[eKey.W].ToString())+ " || " + m_joy_config.m_joystick_map[eKey.W];
            button_s.Text = NiceName(m_kb_config.keyboard_map[eKey.S].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.S];
            button_a.Text = NiceName(m_kb_config.keyboard_map[eKey.A].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.A];
            button_d.Text = NiceName(m_kb_config.keyboard_map[eKey.D].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D];

            button_Up.Text = NiceName(m_kb_config.keyboard_map[eKey.Up].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.Up];
            button_Down.Text = NiceName(m_kb_config.keyboard_map[eKey.Down].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.Down];
            button_Left.Text = NiceName(m_kb_config.keyboard_map[eKey.Left].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.Left];
            button_Right.Text = NiceName(m_kb_config.keyboard_map[eKey.Right].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.Right];

            button_Num8.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad8].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.NumPad8];
            button_Num2.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad2].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.NumPad2];
            button_Num4.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad4].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.NumPad4];
            button_Num6.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad6].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.NumPad6];
            button_Num5.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad5].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.NumPad5];

            button_1.Text = NiceName(m_kb_config.keyboard_map[eKey.D1].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D1];
            button_2.Text = NiceName(m_kb_config.keyboard_map[eKey.D2].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D2];
            button_3.Text = NiceName(m_kb_config.keyboard_map[eKey.D3].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D3];
            button_4.Text = NiceName(m_kb_config.keyboard_map[eKey.D4].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D4];
            button_5.Text = NiceName(m_kb_config.keyboard_map[eKey.D5].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D5];
            button_6.Text = NiceName(m_kb_config.keyboard_map[eKey.D6].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D6];
            button_7.Text = NiceName(m_kb_config.keyboard_map[eKey.D7].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D7];
            button_8.Text = NiceName(m_kb_config.keyboard_map[eKey.D8].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D8];
            button_9.Text = NiceName(m_kb_config.keyboard_map[eKey.D9].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D9];
            button_0.Text = NiceName(m_kb_config.keyboard_map[eKey.D0].ToString()) + " || " + m_joy_config.m_joystick_map[eKey.D0];

            base.Refresh();
        }

        private void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
                SetPressedKey_FromTheCurrentButton(new object(), new KeyPressEventArgs(new char()));
            }
        }

        private void SetPressedKey_FromTheCurrentButton(object sender, KeyPressEventArgs e)
        {
            eKey[] keys = m_keybord.m_keyboard_device.GetPressedKeys();

            if (keys.Length > 0)
            {
                m_kb_config.SetKey(m_current_button, keys[0]);
                m_kb_config.Flush();

                Refresh();
            }

            m_current_button = 0;
            label1.Visible = false;
            this.joystick_settings_Timer.Enabled = false;

        }

        private void button_w_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.W;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_s_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.S;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.A;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_d_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Up_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Up;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Down;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Left;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Right;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Num8_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad8;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Num2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad2;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Num4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad4;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Num6_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad6;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_Num5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad5;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D1;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D2;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D3;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D4;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D5;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D6;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D7;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D8;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D9;
            this.joystick_settings_Timer.Enabled = true;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D0;
            this.joystick_settings_Timer.Enabled = true;
        }


        private void connectToJoysticks(Joystick joystick, Joystick joystick2)
        {
            while (true)
            {
                List<Guid> list_sticks = new List<Guid>();
                list_sticks = joystick.FindJoysticks();

                if (list_sticks.Count > 0)
                {

                    if (joystick.AcquireJoystick(list_sticks[0]))
                    {
                        if (list_sticks.Count > 1)
                        {
                            if (joystick2.AcquireJoystick(list_sticks[1]))
                                m_joy2_connected = true;
                            else
                                m_joy2_connected = false;
                        }
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void joystick_settings_Timer_Tick(object sender, EventArgs e)
        {

            try
            {
                m_joystick.UpdateStatus();
                m_joystickButtons_J1 = m_joystick.m_buttons;
                String curren_joy_action = "";
                if (m_joystick.m_State.Length>2)
                {
                    curren_joy_action = m_joystick.m_State.Trim(); 
                }
                if (m_joy2_connected)
                {
                    m_joystick2.UpdateStatus();
                    m_joystickButtons_J2 = m_joystick2.m_buttons;
                    if (m_joystick2.m_State.Length > 2)
                    {
                        String pattern_regex_joystick2 = "\\s+";
                        String replacement = " 2";
                        Regex rgx_joystick2 = new Regex(pattern_regex_joystick2);
                        String joy2_stat = rgx_joystick2.Replace(m_joystick2.m_State, replacement);
                        joy2_stat = joy2_stat.TrimEnd('2');
                        curren_joy_action += joy2_stat.Trim();
                    }
                }
                if (curren_joy_action.Length > 2)
                {
                    m_joy_config.SetJoyAction(m_current_button, curren_joy_action);
                    m_joy_config.Flush();

                    Refresh();
                }
            }
            catch { this.joystick_settings_Timer.Enabled = false; MessageBox.Show("Упали"); }

        }
             
    }
}

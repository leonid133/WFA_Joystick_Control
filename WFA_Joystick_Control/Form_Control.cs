using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Security.Permissions;

using System.Threading;
using System.IO;
using System.Management;

using System.Drawing.Imaging;
using System.Collections;

using Microsoft.DirectX.DirectInput;

using System.Text.RegularExpressions;

namespace WFA_Joystick_Control
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    //[FlagsAttribute]
   
    /*
    [FlagsAttribute]
    [ComVisibleAttribute(true)]
    [TypeConverterAttribute(typeof(KeysConverter))]
    public enum Keys
        */
    public partial class Form_Control : Form
    {
        private TcpIpLaurentConnector laurentA;
        private TcpIpLaurentConnector laurentB;
        private Controlls controlls;
        private Keybord keybord;

        private Joystick joystick;
        private bool[] joystickButtons_J1;

        private Joystick joystick2;
        private bool[] joystickButtons_J2;
        private bool joy2_connected;

        private Form_Settings form_settings;

        private KeyboardConfiguration m_kb_config;

        private JoystickConfiguration m_joy_config;

        //String ADRESS = "http:\\\\192.168.1.163:80";
        public Form_Control()
        {
            InitializeComponent();
            joystick = new Joystick(this.Handle);
            joystick2 = new Joystick(this.Handle);

            m_kb_config = new KeyboardConfiguration();
            m_joy_config = new JoystickConfiguration();

            keybord = new Keybord(this.Handle);
            keybord.InitializeKeyboard();
        }
        //---------------------------------------------------------------------
        void SaveStringConnection(string connectionString)
        {
            string path_connectionfile = @"connection.txt";
            try
            {
                // Create the file.
                using (FileStream fs = File.Create(path_connectionfile))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes(connectionString);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        string ReadStringConnect()
        {
            string connectionString = "";
            string path_connectionfile = @"connection.txt";
            try
            {
                // Open the stream and read it back.
                using (StreamReader sr = File.OpenText(path_connectionfile))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        connectionString = s;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return connectionString;
        }

        private void connectToJoysticks(Joystick joystick, Joystick joystick2)
        {
            while (true)
            {
                List<Guid> list_sticks = new List<Guid>();
                list_sticks = joystick.FindJoysticks();

                if ( list_sticks.Count > 0)
                {

                    if (joystick.AcquireJoystick(list_sticks[0]))
                    {
                        enableTimer();
                        if (list_sticks.Count > 1)
                        {
                            if (joystick2.AcquireJoystick(list_sticks[1]))
                                joy2_connected = true;
                            else
                                joy2_connected = false;
                        }
                        break;
                    }
                }
                else
                {
                    ReserveKeybord_timer.Enabled = true;
                    break;
                }
            }
        }

        private void enableTimer()
        {
            ReserveKeybord_timer.Enabled = false;
            if (this.InvokeRequired)
            {
                BeginInvoke(new ThreadStart(delegate()
                {
                    joystick_keybord_Timer.Enabled = true;
                }));
            }
            else
                joystick_keybord_Timer.Enabled = true;
        }

       
        private void buttonconnect_Click(object sender, EventArgs e)
        {
            string str = "Ok!";
            String message = "Ok";
            
            laurentA.SetIP(textBox_TCP_1.Text);
            laurentA.SetPort(textBox_Port1.Text);
            laurentA.NeedRead(true);
            message = "Модуль А> Попытка подключения \r \n";
            textBox_Statusbar.AppendText(message);
            message = "Модуль А>";
            message += laurentA.ConnectToLaurent();
            textBox_Statusbar.AppendText(message);
            laurentA.NeedRead(false);

            message = "Модуль Б>  Попытка подключения \r \n";
            textBox_Statusbar.AppendText(message);
            message = "Модуль Б>";
            laurentB.SetIP(textBox_TCP_2.Text);
            laurentB.SetPort(textBox_Port2.Text);
            laurentB.NeedRead(true);
            message += laurentB.ConnectToLaurent();
            textBox_Statusbar.AppendText(message);
            laurentB.NeedRead(false);

            TimerConnectionStatus.Enabled = true;
        }
        public void Test(String message)
        {
            MessageBox.Show(message, "client code");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
             string directory = AppDomain.CurrentDomain.BaseDirectory;
             laurentA = new TcpIpLaurentConnector();
             laurentB = new TcpIpLaurentConnector();
             controlls = new Controlls();
             form_settings = new Form_Settings();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            controlls.LeftOn(ref laurentA, ref laurentB);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            controlls.RightOn(ref laurentA, ref laurentB);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            controlls.UpOn(ref laurentA, ref laurentB);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            controlls.DownOn(ref laurentA, ref laurentB);
        }

        enum Actions { a_move_forward, a_move_back, a_move_left, a_move_right };
        Dictionary<string, Actions> actions_dict;

        bool NUM_LOCK = true;
        private void joystick_and_keybord_Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                ReserveKeybord_timer.Enabled = false;
                joystick.UpdateStatus();
                joystickButtons_J1 = joystick.m_buttons;
                
                Microsoft.DirectX.DirectInput.KeyboardState keys = keybord.m_keyboard_device.GetCurrentKeyboardState();
                
                String joy_summ_state = joystick.m_State;
                textBox1.Text = joystick.m_State;
                 
                //J2
                if (joy2_connected) 
                {
                    joystick2.UpdateStatus();
                    joystickButtons_J2 = joystick2.m_buttons;
                    
                    String pattern_regex_joystick2 = "\\s+"; 
                    String replacement = " 2";
                    Regex rgx_joystick2 = new Regex(pattern_regex_joystick2);
                    String joy2_stat = rgx_joystick2.Replace(joystick2.m_State, replacement);
                    joy2_stat = joy2_stat.TrimEnd('2');
                    joy_summ_state += joy2_stat;
                    textBox1.Text += " || ";
                    textBox1.Text += joy2_stat;
                }

                textBox1.Text += " || ";
                textBox1.Text += joy_summ_state;
                textBox1.Text += joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.A]);

                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.A]) != -1 || keys[m_kb_config.keyboard_map[Key.A]])
                {
                    controlls.LeftOn(ref laurentA, ref laurentB);
                    button_left.BackColor = Color.Red;
                }
                else
                {
                    controlls.LeftOff(ref laurentA, ref laurentB);
                    button_left.BackColor = Form.DefaultBackColor;
                }

                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D]) != -1 || keys[m_kb_config.keyboard_map[Key.D]])
                {
                    controlls.RightOn(ref laurentA, ref laurentB);
                    button_right.BackColor = Color.Red;
                }
                else
                {
                    controlls.RightOff(ref laurentA, ref laurentB);
                    button_right.BackColor = Form.DefaultBackColor;
                }

                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.W]) != -1 || keys[m_kb_config.keyboard_map[Key.W]])
                {
                    controlls.UpOn(ref laurentA, ref laurentB);
                    button_up.BackColor = Color.Red;
                }
                else
                {
                    controlls.UpOff(ref laurentA, ref laurentB);
                    button_up.BackColor = Form.DefaultBackColor;
                }

                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.S]) != -1 || keys[m_kb_config.keyboard_map[Key.S]])
                {
                    controlls.DownOn(ref laurentA, ref laurentB);
                    button_down.BackColor = Color.Red;
                }
                else
                {
                    controlls.DownOff(ref laurentA, ref laurentB);
                    button_down.BackColor = Form.DefaultBackColor;
                }

                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.Up]) != -1 || keys[m_kb_config.keyboard_map[Key.Up]])
                {
                    controlls.GunUpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunUpOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.Down]) != -1 || keys[m_kb_config.keyboard_map[Key.Down]])
                {
                    controlls.GunDownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunDownOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.Left]) != -1 || keys[m_kb_config.keyboard_map[Key.Left]])
                {
                    controlls.GunLeftOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunLeftOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.Right]) != -1 || keys[m_kb_config.keyboard_map[Key.Right]])
                {
                    controlls.GunRightOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunRightOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.NumPad8]) != -1 || keys[m_kb_config.keyboard_map[Key.NumPad8]])
                {
                    controlls.FoldingUpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingUpOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.NumPad2]) != -1 || keys[m_kb_config.keyboard_map[Key.NumPad2]])
                {
                    controlls.FoldingDownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingDownOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.NumPad4]) != -1 || keys[m_kb_config.keyboard_map[Key.NumPad4]])
                {
                    controlls.FoldingLeftOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingLeftOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.NumPad6]) != -1 || keys[m_kb_config.keyboard_map[Key.NumPad6]])
                {
                    controlls.FoldingRightOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingRightOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D1]) != -1 || keys[m_kb_config.keyboard_map[Key.D1]])
                {
                    int count = Convert.ToInt32(checkBox_light.Tag.ToString());
                    if (count > 3)
                    {
                        checkBox_light.Checked = !checkBox_light.Checked;
                        checkBox_light.Tag = 0;
                    }
                    else
                    {
                        ++count;
                        checkBox_light.Tag = count.ToString();
                    }
                }
                if (checkBox_light.Checked)
                    controlls.ProjectorOn(ref laurentA, ref laurentB);
                else
                    controlls.ProjectorOff(ref laurentA, ref laurentB);

                if (keys[m_kb_config.keyboard_map[Key.D2]])
                {
                    int count = Convert.ToInt32(checkBox_Cam.Tag.ToString());
                    if (count > 3)
                    {
                        checkBox_Cam.Checked = !checkBox_Cam.Checked;
                        checkBox_Cam.Tag = 0;
                    }
                    else
                    {
                        ++count;
                        checkBox_Cam.Tag = count.ToString();
                    }
                }
                if (checkBox_Cam.Checked)
                    controlls.CamOn(ref laurentA, ref laurentB);
                else
                    controlls.CamOff(ref laurentA, ref laurentB);

                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D3]) != -1 || keys[m_kb_config.keyboard_map[Key.D3]])
                {
                    controlls.OptionalEquipment1UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment1UpOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D4]) != -1 || keys[m_kb_config.keyboard_map[Key.D4]])
                {
                    controlls.OptionalEquipment1DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment1DownOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D5]) != -1 || keys[m_kb_config.keyboard_map[Key.D5]])
                {
                    controlls.OptionalEquipment2UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment2UpOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D6]) != -1 || keys[m_kb_config.keyboard_map[Key.D6]])
                {
                    controlls.OptionalEquipment2DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment2DownOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D7]) != -1 || keys[m_kb_config.keyboard_map[Key.D7]])
                {
                    controlls.OptionalEquipment3UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment3UpOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D8]) != -1 || keys[m_kb_config.keyboard_map[Key.D8]])
                {
                    controlls.OptionalEquipment3DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment3DownOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D9]) != -1 || keys[m_kb_config.keyboard_map[Key.D9]])
                {
                    controlls.OptionalEquipment4UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment4UpOff(ref laurentA, ref laurentB);
                }
                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.D0]) != -1 || keys[m_kb_config.keyboard_map[Key.D0]])
                {
                    controlls.OptionalEquipment4DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment4DownOff(ref laurentA, ref laurentB);
                }

                if (joy_summ_state.IndexOf(m_joy_config.m_joystick_map[Key.NumPad5]) != -1 || keys[m_kb_config.keyboard_map[Key.NumPad5]])
                {
                    int count = Convert.ToInt32(checkBox_Fix.Tag.ToString());
                    if (count > 3)
                    {
                        checkBox_Fix.Checked = !checkBox_Fix.Checked;
                        
                        checkBox_Fix.Tag = 0;
                    }
                    else
                    {
                        ++count;
                        checkBox_Fix.Tag = count.ToString();
                    }
                }
                if (checkBox_Fix.Checked)
                    controlls.FixFoldingUpOn(ref laurentA, ref laurentB);
                else
                    controlls.FixFoldingUpOff(ref laurentA, ref laurentB);

                
                
            }
            catch
            {
                joystick_keybord_Timer.Enabled = false;
                ReserveKeybord_timer.Enabled = true;
            }
        }

        private void ReserveKeybord_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Microsoft.DirectX.DirectInput.KeyboardState keys = keybord.m_keyboard_device.GetCurrentKeyboardState();

                if (keys[m_kb_config.keyboard_map[Key.A]])
                {
                    controlls.LeftOn(ref laurentA, ref laurentB);
                    button_left.BackColor = Color.Red;
                }
                else
                {
                    controlls.LeftOff(ref laurentA, ref laurentB);
                    button_left.BackColor = Form.DefaultBackColor;
                }

                if (keys[m_kb_config.keyboard_map[Key.D]])
                {
                    controlls.RightOn(ref laurentA, ref laurentB);
                    button_right.BackColor = Color.Red;
                }
                else
                {
                    controlls.RightOff(ref laurentA, ref laurentB);
                    button_right.BackColor = Form.DefaultBackColor;
                }

                if (keys[m_kb_config.keyboard_map[Key.W]])
                {
                    controlls.UpOn(ref laurentA, ref laurentB);
                    button_up.BackColor = Color.Red;
                }
                else
                {
                    controlls.UpOff(ref laurentA, ref laurentB);
                    button_up.BackColor = Form.DefaultBackColor;
                }

                if (keys[m_kb_config.keyboard_map[Key.S]])
                {
                    controlls.DownOn(ref laurentA, ref laurentB);
                    button_down.BackColor = Color.Red;
                }
                else
                {
                    controlls.DownOff(ref laurentA, ref laurentB);
                    button_down.BackColor = Form.DefaultBackColor;
                }

                if (keys[m_kb_config.keyboard_map[Key.Up]])
                {
                    controlls.GunUpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunUpOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.Down]])
                {
                    controlls.GunDownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunDownOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.Left]])
                {
                    controlls.GunLeftOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunLeftOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.Right]])
                {
                    controlls.GunRightOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.GunRightOff(ref laurentA, ref laurentB);
                }

                if (keys[m_kb_config.keyboard_map[Key.D1]])
                {
                    int count = Convert.ToInt32(checkBox_light.Tag.ToString());
                    if (count > 3)
                    {
                        checkBox_light.Checked = !checkBox_light.Checked;
                        
                        checkBox_light.Tag = 0;
                    }
                    else
                    {
                        ++count;
                        checkBox_light.Tag = count.ToString();
                    }
                }
                if (checkBox_light.Checked)
                    controlls.ProjectorOn(ref laurentA, ref laurentB);
                else
                    controlls.ProjectorOff(ref laurentA, ref laurentB);
                if (keys[m_kb_config.keyboard_map[Key.D2]])
                {
                    int count = Convert.ToInt32(checkBox_Cam.Tag.ToString());
                    if (count > 3)
                    {
                        checkBox_Cam.Checked = !checkBox_Cam.Checked;
                        
                        checkBox_Cam.Tag = 0;
                    }
                    else
                    {
                        ++count;
                        checkBox_Cam.Tag = count.ToString();
                    }
                }
                if (checkBox_Cam.Checked)
                    controlls.CamOn(ref laurentA, ref laurentB);
                else
                    controlls.CamOff(ref laurentA, ref laurentB);

                if (keys[m_kb_config.keyboard_map[Key.D3]])
                {
                    controlls.OptionalEquipment1UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment1UpOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.D4]])
                {
                    controlls.OptionalEquipment1DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment1DownOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.D5]])
                {
                    controlls.OptionalEquipment2UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment2UpOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.D6]])
                {
                    controlls.OptionalEquipment2DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment2DownOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.D7]])
                {
                    controlls.OptionalEquipment3UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment3UpOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.D8]])
                {
                    controlls.OptionalEquipment3DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment3DownOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.D9]])
                {
                    controlls.OptionalEquipment4UpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment4UpOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.D0]])
                {
                    controlls.OptionalEquipment4DownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.OptionalEquipment4DownOff(ref laurentA, ref laurentB);
                }

                if (keys[m_kb_config.keyboard_map[Key.NumPad8]])
                {
                    controlls.FoldingUpOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingUpOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.NumPad2]])
                {
                    controlls.FoldingDownOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingDownOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.NumPad4]])
                {
                    controlls.FoldingLeftOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingLeftOff(ref laurentA, ref laurentB);
                }
                if (keys[m_kb_config.keyboard_map[Key.NumPad6]])
                {
                    controlls.FoldingRightOn(ref laurentA, ref laurentB);
                }
                else
                {
                    controlls.FoldingRightOff(ref laurentA, ref laurentB);
                }

                if (keys[m_kb_config.keyboard_map[Key.NumPad5]])
                {
                    int count = Convert.ToInt32(checkBox_Fix.Tag.ToString());
                    if (count > 3)
                    {
                        checkBox_Fix.Checked = !checkBox_Fix.Checked;
                        checkBox_Fix.Tag = 0;
                    }
                    else
                    {
                        ++count;
                        checkBox_Fix.Tag = count.ToString();
                    }
                }
                if (checkBox_Fix.Checked)
                    controlls.FixFoldingUpOn(ref laurentA, ref laurentB);
                else
                    controlls.FixFoldingUpOff(ref laurentA, ref laurentB);
                 

            }
            catch
            {
                ReserveKeybord_timer.Enabled = false;
                connectToJoysticks(joystick, joystick2);
            }
        }

        private void buttonJoysticConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание! Пожалуйста подключите джойстики и переведите все оси, всех подключенных джойстиков в центральное положение, и не нажимайте кнопок в течении 5 секунд.");
            connectToJoysticks(joystick, joystick2);
        }

        
        private void button_Settings_Click(object sender, EventArgs e)
        {
            joystick_keybord_Timer.Enabled = false;
            ReserveKeybord_timer.Enabled = false;
            form_settings.ShowDialog();
            m_kb_config = new KeyboardConfiguration();
            m_joy_config = new JoystickConfiguration();
        }

        private void TimerConnectionStatus_Tick(object sender, EventArgs e)
        {
            textBox_Statusbar.Clear();
            String message = "Модуль А >";
            if (laurentA.GetConnectionStatus())
            {
                message += "Есть подключение ";
                laurentA.NeedRead(true);
                message += laurentA.GetRDR();
                laurentB.NeedRead(false);
                message += " \r \n";
            }
            else
                message += "Подключение отсутствует \r \n";
            

            textBox_Statusbar.AppendText(message);
            message = "Модуль Б >";
            if (laurentB.GetConnectionStatus())
            {
                message += "Есть подключение ";
                laurentB.NeedRead(true);
                message += laurentB.GetRDR();
                laurentB.NeedRead(false);
                message += " \r \n";
            }
            else
                message += "Подключение отсутствует \r \n";
            
            textBox_Statusbar.AppendText(message);
            
        }
    
    }
}

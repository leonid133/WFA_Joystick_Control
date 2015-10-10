﻿using System;
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

        //String ADRESS = "http:\\\\192.168.1.163:80";
        public Form_Control()
        {
            InitializeComponent();
            joystick = new Joystick(this.Handle);
            joystick2 = new Joystick(this.Handle);

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

        private void connectToJoystick(Joystick joystick)
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
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.IsWebBrowserContextMenuEnabled = false;
            webBrowser1.WebBrowserShortcutsEnabled = false;
            webBrowser1.ObjectForScripting = this;
            // Uncomment the following line when you are finished debugging.
            webBrowser1.ScriptErrorsSuppressed = true;
            /*
             webBrowser1.DocumentText =
            "<html><head><script>" +
            "function test(message) { alert(message); }" +
            "</script></head><body><button " +
            "onclick=\"window.external.Test('called from script code')\">" +
            "call client code from script code</button>" +
            "</body></html>";*/
            /*
             webBrowser1.DocumentText =
             "<html><head></head><body><img src=\"C:\\Users\\User\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\1.jpg\" style=\"width:640px;height:480px;\"> "  +
             "</body></html>";
            */
            string directory = AppDomain.CurrentDomain.BaseDirectory;
             /*webBrowser1.DocumentText =
             "<html><head></head><body><img src=\"" + 
             directory +
             "1.jpg\" style=\"width:640px;height:480px;\"> " +
             "</body></html>";*/
             textBox1.Text = ReadStringConnect();

             laurentA = new TcpIpLaurentConnector();
             laurentB = new TcpIpLaurentConnector();
             controlls = new Controlls();
             form_settings = new Form_Settings();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {

            controlls.LeftOn(ref laurentA, ref laurentB);
            
            //webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            //webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            //webBrowser1.Document.InvokeScript("Button_onclick",  new String[] { "up" });
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            //webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" });
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

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
               
                if (joystick.m_Xaxis == 0 || keys[Key.Left])
                {
                    controlls.LeftOn(ref laurentA, ref laurentB);
                   // webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });//output.Text += "Left\n";
                    button_left.BackColor = Color.Red;
                }
                else
                {
                    controlls.LeftOff(ref laurentA, ref laurentB);
                    button_left.BackColor = Form.DefaultBackColor;
                }

                if (joystick.m_Xaxis == 65535 || keys[Key.Right])
                {
                    controlls.RightOn(ref laurentA, ref laurentB);
                    // webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });  //output.Text += "Right\n";
                    button_right.BackColor = Color.Red;
                }
                else
                {
                    controlls.RightOff(ref laurentA, ref laurentB);
                    button_right.BackColor = Form.DefaultBackColor;
                }

                if (joystick.m_Yaxis == 0 || keys[Key.Up])
                {
                    controlls.UpOn(ref laurentA, ref laurentB);
                    //webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "up" }); //output.Text += "Up\n";
                    button_up.BackColor = Color.Red;
                }
                else
                {
                    controlls.UpOff(ref laurentA, ref laurentB);
                    button_up.BackColor = Form.DefaultBackColor;
                }

                if (joystick.m_Yaxis == 65535 || keys[Key.Down])
                {
                    controlls.DownOn(ref laurentA, ref laurentB);
                    //webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" }); //output.Text += "Down\n";
                    button_down.BackColor = Color.Red;
                }
                else
                {
                    controlls.DownOff(ref laurentA, ref laurentB);
                    button_down.BackColor = Form.DefaultBackColor;
                }
                
                for (int i = 0; i < joystickButtons_J1.Length; i++)
                {
                    if (joystickButtons_J1[i] == true)
                    {
                        //webBrowser1.Url = new Uri("http://192.168.1.163:80/"); //output.Text += "Button " + i + " Pressed\n";
                        //webBrowser1.Refresh();
                    }
                }

                //J2
                if (joy2_connected)
                {
                    joystick2.UpdateStatus();
                    joystickButtons_J2 = joystick2.m_buttons;

                    if (joystick2.m_Yaxis == 65535)
                    {
                        controlls.FoldingDownOn(ref laurentA, ref laurentB);
                        //webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" }); //output.Text += "Down\n";
                        button_down.BackColor = Color.Red;
                    }
                    else
                    {
                        controlls.FoldingDownOff(ref laurentA, ref laurentB);
                        button_down.BackColor = Form.DefaultBackColor;
                    }
                }
            }
            catch
            {
                joystick_keybord_Timer.Enabled = false;
                ReserveKeybord_timer.Enabled = true;
                //connectToJoystick(joystick);
            }
        }

        private void ReserveKeybord_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Microsoft.DirectX.DirectInput.KeyboardState keys = keybord.m_keyboard_device.GetCurrentKeyboardState();

                if (keys[Key.Left])
                {
                    controlls.LeftOn(ref laurentA, ref laurentB);
                   // webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });//output.Text += "Left\n";
                    button_left.BackColor = Color.Red;
                }
                else
                {
                    controlls.LeftOff(ref laurentA, ref laurentB);
                    button_left.BackColor = Form.DefaultBackColor;
                }

                if (keys[Key.Right])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });  //output.Text += "Right\n";
                    button_right.BackColor = Color.Red;
                }
                else
                {
                    button_right.BackColor = Form.DefaultBackColor;
                }

                if (keys[Key.Up])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "up" }); //output.Text += "Up\n";
                    button_up.BackColor = Color.Red;
                }
                else
                {
                    button_up.BackColor = Form.DefaultBackColor;
                }

                if (keys[Key.Down])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" }); //output.Text += "Down\n";
                    button_down.BackColor = Color.Red;
                }
                else
                {
                    button_down.BackColor = Form.DefaultBackColor;
                }


            }
            catch
            {
                ReserveKeybord_timer.Enabled = false;
                connectToJoystick(joystick);
            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonJoysticConnect_Click(object sender, EventArgs e)
        {
            connectToJoystick(joystick);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SaveStringConnection(textBox1.Text);
        }
        
        private void button_disconnect1_Click(object sender, EventArgs e)
        {
            //laurentA.Disconnect();
        }

        private void button_Record_Click(object sender, EventArgs e)
        {

        }

        private void buttonURLConnect_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(ReadStringConnect());
            
        }

        private void button_VideoConnect_Click(object sender, EventArgs e)
        {
            string imagestream = textBox_VideoConnect.Text;
            //imagestream += ":8080/?action=stream";
            //imagestream += ":8080/?action=snapshot";
            pictureBox1.Load(imagestream);
            pictureBox1.BringToFront();
            webBrowser1.Visible = false;
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            form_settings.ShowDialog();
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

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

using System.Diagnostics;


namespace WFA_Joystick_Control
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
 
    public partial class Form_Control : Form
    {
        private Keybord keybord;

        private Joystick joystick;
        private bool[] joystickButtons_J1;

        private Form_Settings form_settings;

        private KeyboardConfiguration m_kb_config;

        //String ADRESS = "http:\\\\192.168.1.163:80";
        public Form_Control()
        {
            InitializeComponent();
            joystick = new Joystick(this.Handle);

            m_kb_config = new KeyboardConfiguration();

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

        string ReadStringConnect(string path_connectionfile)
        {
            string connectionString = "";
           
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
                    string path_connectionfile = @"joy.txt";
                    string joy_item_str = ReadStringConnect(path_connectionfile);
                    int joy_item = -1;
                    try
                    {
                        joy_item = Convert.ToInt32(joy_item_str);
                        if (joy_item >= 0 && joy_item < list_sticks.Count)
                            if (joystick.AcquireJoystick(list_sticks[joy_item]))
                            {
                                enableTimer();
                                break;
                            }
                    }
                    catch { break; }
                    
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
            
             webBrowser1.DocumentText =
            "<html><head><script>" +
            "function test(message) { alert(message); }" +
            "</script></head><body><button " +
            "onclick=\"window.external.Test('called from script code')\">" +
            "call client code from script code</button>" +
            "</body></html>";
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
             
             form_settings = new Form_Settings();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick",  new String[] { "up" });
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" });
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

                if (joystick.m_Xaxis == 0 || keys[m_kb_config.keyboard_map[Key.A]])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });//output.Text += "Left\n";
                    button_left.BackColor = Color.Red;
                }
                else
                {
                    button_left.BackColor = Form.DefaultBackColor;
                }

                if (joystick.m_Xaxis == 65535 || keys[m_kb_config.keyboard_map[Key.D]])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });  //output.Text += "Right\n";
                    button_right.BackColor = Color.Red;
                }
                else
                {
                    button_right.BackColor = Form.DefaultBackColor;
                }

                if (joystick.m_Yaxis == 0 || keys[m_kb_config.keyboard_map[Key.W]])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "up" }); //output.Text += "Up\n";
                    button_up.BackColor = Color.Red;
                }
                else
                {
                    button_up.BackColor = Form.DefaultBackColor;
                }

                if (joystick.m_Yaxis == 65535 || keys[m_kb_config.keyboard_map[Key.S]])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" }); //output.Text += "Down\n";
                    button_down.BackColor = Color.Red;
                }
                else
                {
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

                if (keys[m_kb_config.keyboard_map[Key.A]])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });//output.Text += "Left\n";
                    button_left.BackColor = Color.Red;
                }
                else
                {
                    button_left.BackColor = Form.DefaultBackColor;
                }

                if (keys[m_kb_config.keyboard_map[Key.D]])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });  //output.Text += "Right\n";
                    button_right.BackColor = Color.Red;
                }
                else
                {
                    button_right.BackColor = Form.DefaultBackColor;
                }

                if (keys[m_kb_config.keyboard_map[Key.W]])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "up" }); //output.Text += "Up\n";
                    button_up.BackColor = Color.Red;
                }
                else
                {
                    button_up.BackColor = Form.DefaultBackColor;
                }

                if (keys[m_kb_config.keyboard_map[Key.S]])
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

               
        private void button_disconnect1_Click(object sender, EventArgs e)
        {
            //laurentA.Disconnect();
        }

        private void button_Record_Click(object sender, EventArgs e)
        {
            if (button_Record.BackColor == Color.OrangeRed)
                button_Record.BackColor = Color.Gray;
            else
                button_Record.BackColor = Color.OrangeRed;

        }

        private void buttonURLConnect_Click(object sender, EventArgs e)
        {
            string path_connectionfile = @"connection.txt";
            webBrowser1.Url = new Uri(ReadStringConnect(path_connectionfile));
            
        }
        
       

        private void button_VideoConnect_Click(object sender, EventArgs e)
        {
            buttonJoysticConnect_Click(sender, e);
            buttonURLConnect_Click(sender, e);
         
            //imagestream += ":8080/?action=stream";
            //imagestream += ":8080/?action=snapshot";
            if (button_Record.BackColor == Color.OrangeRed)
            {

                saveFileDialog_video.Filter = "Видео файл | *.mp4";
                saveFileDialog_video.ShowDialog();
            }
             BackgroundWorker worker = new BackgroundWorker();
             worker.DoWork += new DoWorkEventHandler(worker_DoWork);
             worker.RunWorkerAsync();
            //pictureBox1.Load(imagestream);
            //pictureBox1.BringToFront();
            //webBrowser1.Visible = false;
        }
        
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            string patch_videoplayer = @"videoexe.txt";
            string vido_player_exe = ReadStringConnect(patch_videoplayer);
            psi.FileName = vido_player_exe; //"C:\VideoLAN\VLC\vlc.exe";

            string path_connectionfile = @"videosrc.txt";
            string imagestream = ReadStringConnect(path_connectionfile);

            if (button_Record.BackColor == Color.OrangeRed)
            {
                if (saveFileDialog_video.CheckPathExists)
                {
                    imagestream += " --sout=#duplicate{dst=std{access=file,mux=mp4,dst=";
                    imagestream += saveFileDialog_video.FileName;
                    imagestream +="},dst=display}";
                }
            }
            
            psi.Arguments = imagestream;
            Process.Start(psi);
            //C:\VideoLAN\VLC\vlc.exe
            /*
            while (true)
            {
                string path_connectionfile = @"videosrc.txt";
                string imagestream = ReadStringConnect(path_connectionfile);
                
                pictureBox1.Load(imagestream);
                //throw new NotImplementedException();
            }
             * */
        }
        
        private void button_Settings_Click(object sender, EventArgs e)
        {
            form_settings.ShowDialog();
            m_kb_config = new KeyboardConfiguration();
        }
                
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

           
    }
}

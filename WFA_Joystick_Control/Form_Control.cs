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
        private TcpIpLaurentConnector laurentA, laurentB;
        private Controlls controlls;
        private Joystick joystick;
        private bool[] joystickButtons;

//         private Microsoft.DirectX.DirectInput.Device keyboard;
//         private bool[] keyboardButtons;

        //String ADRESS = "http:\\\\192.168.1.163:80";

        public Form_Control()
        {
            InitializeComponent();
            joystick = new Joystick(this.Handle);
            connectToJoystick(joystick);
            joystick.InitializeKeyboard();

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
                string sticks = joystick.FindJoysticks();
                if (sticks != null)
                {
                    if (joystick.AcquireJoystick(sticks))
                    {
                        enableTimer();
                        break;
                    }
                }
                else
                    break;
            }
        }

        private void enableTimer()
        {
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
            message = laurentA.ConnectToLaurent();
            MessageBox.Show(message, str);
            message = laurentA.LoginToLaurent();
            MessageBox.Show(message, str);
            message = laurentA.OnRel("1");
            MessageBox.Show(message, str);
            message = laurentA.OffRel("1");
            MessageBox.Show(message, str);
             
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
        private void joystickTimer_Tick(object sender, EventArgs e)
        {
            try
            {
               
                joystick.UpdateStatus();
                joystickButtons = joystick.buttons;
                Microsoft.DirectX.DirectInput.KeyboardState keys = joystick.keyboard.GetCurrentKeyboardState();
               
                if (joystick.Xaxis == 0 || keys[Key.Left])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });//output.Text += "Left\n";
                    button_left.BackColor = Color.Red;
                }
                else
                {
                    button_left.BackColor = Form.DefaultBackColor;
                }

                if (joystick.Xaxis == 65535 || keys[Key.Right])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });  //output.Text += "Right\n";
                    button_right.BackColor = Color.Red;
                }
                else
                {
                    button_right.BackColor = Form.DefaultBackColor;
                }

                if (joystick.Yaxis == 0 || keys[Key.Up])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "up" }); //output.Text += "Up\n";
                    button_up.BackColor = Color.Red;
                }
                else
                {
                    button_up.BackColor = Form.DefaultBackColor;
                }

                if (joystick.Yaxis == 65535 || keys[Key.Down])
                {
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" }); //output.Text += "Down\n";
                    button_down.BackColor = Color.Red;
                }
                else
                {
                    button_down.BackColor = Form.DefaultBackColor;
                }
                
                for (int i = 0; i < joystickButtons.Length; i++)
                {
                    if (joystickButtons[i] == true)
                    {
                        //webBrowser1.Url = new Uri("http://192.168.1.163:80/"); //output.Text += "Button " + i + " Pressed\n";
                        //webBrowser1.Refresh();
                    }
                }
            }
            catch
            {
                joystick_keybord_Timer.Enabled = false;
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
            laurentA.Disconnect();
        }

        private void button_Record_Click(object sender, EventArgs e)
        {

        }

        private void buttonURLConnect_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(ReadStringConnect());
            string imagestream = ReadStringConnect();
            imagestream += ":8080/?action=stream";
            pictureBox1.Load(imagestream);
        }

    
    }
}

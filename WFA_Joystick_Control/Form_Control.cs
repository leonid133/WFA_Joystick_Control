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
        private TcpIpLaurentConnector laurent1;
        
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
                    joystickTimer.Enabled = true;
                }));
            }
            else
                joystickTimer.Enabled = true;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           //webBrowser1.Navigate("http://192.168.1.163:80/");
            //webBrowser1.Refresh();
            webBrowser1.Url = new Uri(ReadStringConnect());
            string str = "Ok!";
            String message = "Ok";
            laurent1.SetIP(textBox_TCP_1.Text);
            laurent1.SetPort(textBox_Port1.Text);
            message = laurent1.ConnectToLaurent();
            MessageBox.Show(message, str);
            message = laurent1.LoginToLaurent();
            MessageBox.Show(message, str);
            message = laurent1.OnRel("1");
            MessageBox.Show(message, str);
            message = laurent1.OffRel("1");
            MessageBox.Show(message, str);
        }
        public void Test(String message)
        {
            MessageBox.Show(message, "client code");
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.AllowWebBrowserDrop = false;
            //webBrowser1.IsWebBrowserContextMenuEnabled = false;
            //webBrowser1.WebBrowserShortcutsEnabled = false;
            webBrowser1.ObjectForScripting = this;
            // Uncomment the following line when you are finished debugging.
        //webBrowser1.ScriptErrorsSuppressed = true;
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
             webBrowser1.DocumentText =
             "<html><head></head><body><img src=\"" + 
             directory +
             "1.jpg\" style=\"width:640px;height:480px;\"> " +
             "</body></html>";
             textBox1.Text = ReadStringConnect();
             laurent1 = new TcpIpLaurentConnector();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick",
     new String[] { "left" });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick",
    new String[] { "right" });
            //webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick",
    new String[] { "up" });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.InvokeScript("Button_onclick",
    new String[] { "down" });
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //MessageBox.Show("Pressed " + Keys.Shift);
        }


        private void Form_Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Form.KeyPress: '" +
                    e.KeyChar.ToString() + "' pressed.");
        }

//         bool is_processed = false;
        private void WebBrowser_Control_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.Focus();
//             if(!is_processed)
            {
                MessageBox.Show("Form.KeyPress: '" + e.KeyData.ToString() + "' pressed.");
//                 is_processed = true;
            }
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

                if (joystick.Xaxis == 0)
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "left" });//output.Text += "Left\n";

                if (joystick.Xaxis == 65535)
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "right" });  //output.Text += "Right\n";

                if (joystick.Yaxis == 0)
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "up" }); //output.Text += "Up\n";

                if (joystick.Yaxis == 65535)
                    webBrowser1.Document.InvokeScript("Button_onclick", new String[] { "down" }); //output.Text += "Down\n";

                for (int i = 0; i < joystickButtons.Length; i++)
                {
                    if (joystickButtons[i] == true)
                    {
                        webBrowser1.Url = new Uri("http://192.168.1.163:80/"); //output.Text += "Button " + i + " Pressed\n";
                        //webBrowser1.Refresh();
                    }
                }
            }
            catch
            {
                joystickTimer.Enabled = false;
                connectToJoystick(joystick);
            }
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connectToJoystick(joystick);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SaveStringConnection(textBox1.Text);
        }
        
        private void button_disconnect1_Click(object sender, EventArgs e)
        {
            laurent1.Disconnect();
        }

        private void keybordTimerTick(object sender, EventArgs e)
        {
            try
            {
                string str1 = "";
                //                 joystick.keyboard.Poll();
                Microsoft.DirectX.DirectInput.KeyboardState keys = joystick.keyboard.GetCurrentKeyboardState();
                if (keys[Key.W] /*&& keys[Key.E]*/)
                {
                    //                     MessageBox.Show("DirectX.DirectInput: w pressed.");
                    str1 += "1";

                }
                if (keys[Key.E])
                {
                    str1 += "2";
                    //                     MessageBox.Show("DirectX.DirectInput: e pressed.");
                }
                if (keys[Key.NumPad4] && !NUM_LOCK)
                {
                    str1 += "NUM_LeftArrow";
                }
                if (keys[Key.NumPad4] && NUM_LOCK)
                {
                    str1 += "NUM4";
                }
                if (keys[Key.LeftArrow]) str1 += "LeftArrow";
                if (keys[Key.Numlock])
                {
                    //                     str1 += "Numlock"; 
                    NUM_LOCK = !NUM_LOCK;
                }

                if (str1 != "")
                {
                    MessageBox.Show(str1);
                }
            }
            catch
            {
                MessageBox.Show("KeyCatch");
            }
        }
    }
}

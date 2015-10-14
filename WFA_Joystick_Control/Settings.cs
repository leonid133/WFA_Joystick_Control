using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.DirectX.DirectInput;
using System.IO;

using eKey = Microsoft.DirectX.DirectInput.Key;

namespace WFA_Joystick_Control
{
    public partial class Form_Settings : Form
    {
        private eKey m_current_button;
        private KeyboardConfiguration m_kb_config = new KeyboardConfiguration();
        private Keybord m_keybord;

        void SaveStringConnection(string connectionString, string path_connectionfile)
        {
            
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

        public Form_Settings()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }

            m_keybord = new Keybord(this.Handle);
            m_keybord.InitializeKeyboard();

            try
            {
                // Find all the GameControl devices that are attached.
                DeviceList gameControllerList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);

                // check that we have at least one device.
                if (gameControllerList.Count > 0)
                {
                    foreach (DeviceInstance deviceInstance in gameControllerList)
                    {
                        this.comboBox_Sticks.Items.Add(deviceInstance.ProductName);    
                    }
                }
                
                string path_connectionfile = @"connection.txt";
                textBox_Connection.Text = ReadStringConnect( path_connectionfile);

                path_connectionfile = @"videosrc.txt";
                textBox_VideoConnect.Text = ReadStringConnect(path_connectionfile);

                path_connectionfile = @"videoexe.txt";
                textBox_VideoLAN.Text = ReadStringConnect(path_connectionfile);

            }
            catch
            {
                this.comboBox_Sticks.Items.Clear();
            }

            Refresh();
        }

        public override void Refresh()
        {
            button1.Text = m_kb_config.keyboard_map[eKey.W].ToString();
            button2.Text = m_kb_config.keyboard_map[eKey.S].ToString();
            button3.Text = m_kb_config.keyboard_map[eKey.A].ToString();
            button4.Text = m_kb_config.keyboard_map[eKey.D].ToString();

            base.Refresh();
        }

        private void control_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
                button1_KeyPress(new object(), new KeyPressEventArgs(new char()));
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.W;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.S;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.A;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D;

        }

        private void textBox_Connection_KeyUp(object sender, KeyEventArgs e)
        {
            string path_connectionfile = @"connection.txt";
            SaveStringConnection(textBox_Connection.Text, path_connectionfile);
        }

        private void textBox_VideoConnect_KeyUp(object sender, KeyEventArgs e)
        {
            string path_connectionfile = @"videosrc.txt";
            SaveStringConnection(textBox_VideoConnect.Text, path_connectionfile);
        }

        private void comboBox_Sticks_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path_connectionfile = @"joy.txt";
            SaveStringConnection(comboBox_Sticks.SelectedIndex.ToString(), path_connectionfile);
        }

        private void textBox_VideoLAN_KeyUp(object sender, KeyEventArgs e)
        {
            string path_connectionfile = @"videoexe.txt";
            SaveStringConnection(textBox_VideoLAN.Text, path_connectionfile);
        }

    }
}

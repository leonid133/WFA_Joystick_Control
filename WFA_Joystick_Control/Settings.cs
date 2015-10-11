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

namespace WFA_Joystick_Control
{
    public partial class Form_Settings : Form
    {
        private eKey m_current_button;
        private KeyboardConfiguration m_kb_config = new KeyboardConfiguration();
        private Keybord m_keybord;


        public Form_Settings()
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(control_PreviewKeyDown);
            }

            m_keybord = new Keybord(this.Handle);
            m_keybord.InitializeKeyboard();

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

    }
}

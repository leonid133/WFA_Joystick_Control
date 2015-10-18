﻿using System;
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
            button1.Text = NiceName(m_kb_config.keyboard_map[eKey.W].ToString());
            button2.Text = NiceName(m_kb_config.keyboard_map[eKey.S].ToString());
            button3.Text = NiceName(m_kb_config.keyboard_map[eKey.A].ToString());
            button4.Text = NiceName(m_kb_config.keyboard_map[eKey.D].ToString());

            button8.Text = NiceName(m_kb_config.keyboard_map[eKey.Up].ToString());
            button7.Text = NiceName(m_kb_config.keyboard_map[eKey.Down].ToString());
            button6.Text = NiceName(m_kb_config.keyboard_map[eKey.Left].ToString());
            button5.Text = NiceName(m_kb_config.keyboard_map[eKey.Right].ToString());

            button12.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad8].ToString());
            button11.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad2].ToString());
            button10.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad4].ToString());
            button9.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad6].ToString());
            button13.Text = NiceName(m_kb_config.keyboard_map[eKey.NumPad5].ToString());

            button23.Text = NiceName(m_kb_config.keyboard_map[eKey.D1].ToString());
            button22.Text = NiceName(m_kb_config.keyboard_map[eKey.D2].ToString());
            button21.Text = NiceName(m_kb_config.keyboard_map[eKey.D3].ToString());
            button20.Text = NiceName(m_kb_config.keyboard_map[eKey.D4].ToString());
            button19.Text = NiceName(m_kb_config.keyboard_map[eKey.D5].ToString());
            button18.Text = NiceName(m_kb_config.keyboard_map[eKey.D6].ToString());
            button17.Text = NiceName(m_kb_config.keyboard_map[eKey.D7].ToString());
            button16.Text = NiceName(m_kb_config.keyboard_map[eKey.D8].ToString());
            button15.Text = NiceName(m_kb_config.keyboard_map[eKey.D9].ToString());
            button14.Text = NiceName(m_kb_config.keyboard_map[eKey.D0].ToString());

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

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Up;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Down;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Left;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.Right;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad6;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.NumPad5;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D2;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D3;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D4;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D5;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D6;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D7;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D8;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            m_current_button = eKey.D0;
        }

    }
}

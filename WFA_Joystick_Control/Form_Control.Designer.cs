namespace WFA_Joystick_Control
{
    partial class Form_Control
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_Record = new System.Windows.Forms.Button();
            this.joystick_keybord_Timer = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_joyConnect = new System.Windows.Forms.Button();
            this.buttonURLConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_VideoConnect = new System.Windows.Forms.Button();
            this.ReserveKeybord_timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Settings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(108, 36);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(41, 23);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "left";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(198, 36);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(41, 23);
            this.button_right.TabIndex = 3;
            this.button_right.Text = "right";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(154, 17);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(41, 23);
            this.button_up.TabIndex = 4;
            this.button_up.Text = "up";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(154, 60);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(41, 23);
            this.button_down.TabIndex = 5;
            this.button_down.Text = "down";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // button_Record
            // 
            this.button_Record.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Record.Location = new System.Drawing.Point(257, 60);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(75, 23);
            this.button_Record.TabIndex = 6;
            this.button_Record.Text = "Record";
            this.button_Record.UseVisualStyleBackColor = false;
            this.button_Record.Click += new System.EventHandler(this.button_Record_Click);
            // 
            // joystick_keybord_Timer
            // 
            this.joystick_keybord_Timer.Enabled = true;
            this.joystick_keybord_Timer.Tick += new System.EventHandler(this.joystick_and_keybord_Timer_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(147, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(321, 211);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // button_joyConnect
            // 
            this.button_joyConnect.Location = new System.Drawing.Point(11, 41);
            this.button_joyConnect.Name = "button_joyConnect";
            this.button_joyConnect.Size = new System.Drawing.Size(75, 23);
            this.button_joyConnect.TabIndex = 9;
            this.button_joyConnect.Text = "Joystic_Connect";
            this.button_joyConnect.UseVisualStyleBackColor = true;
            this.button_joyConnect.Visible = false;
            this.button_joyConnect.Click += new System.EventHandler(this.buttonJoysticConnect_Click);
            // 
            // buttonURLConnect
            // 
            this.buttonURLConnect.Location = new System.Drawing.Point(11, 12);
            this.buttonURLConnect.Name = "buttonURLConnect";
            this.buttonURLConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonURLConnect.TabIndex = 14;
            this.buttonURLConnect.Text = "connect";
            this.buttonURLConnect.UseVisualStyleBackColor = true;
            this.buttonURLConnect.Visible = false;
            this.buttonURLConnect.Click += new System.EventHandler(this.buttonURLConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button_VideoConnect
            // 
            this.button_VideoConnect.Location = new System.Drawing.Point(257, 17);
            this.button_VideoConnect.Name = "button_VideoConnect";
            this.button_VideoConnect.Size = new System.Drawing.Size(75, 23);
            this.button_VideoConnect.TabIndex = 16;
            this.button_VideoConnect.Text = "Play";
            this.button_VideoConnect.UseVisualStyleBackColor = true;
            this.button_VideoConnect.Click += new System.EventHandler(this.button_VideoConnect_Click);
            // 
            // ReserveKeybord_timer
            // 
            this.ReserveKeybord_timer.Enabled = true;
            this.ReserveKeybord_timer.Tick += new System.EventHandler(this.ReserveKeybord_timer_Tick);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.webBrowser1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonURLConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_joyConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBox1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(890, 434);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.toolStripContainer1.LeftToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(890, 434);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button_Record);
            this.panel1.Controls.Add(this.button_Settings);
            this.panel1.Controls.Add(this.button_VideoConnect);
            this.panel1.Controls.Add(this.button_up);
            this.panel1.Controls.Add(this.button_left);
            this.panel1.Controls.Add(this.button_right);
            this.panel1.Controls.Add(this.button_down);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 92);
            this.panel1.TabIndex = 21;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            // 
            // button_Settings
            // 
            this.button_Settings.Location = new System.Drawing.Point(16, 25);
            this.button_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(58, 44);
            this.button_Settings.TabIndex = 20;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 434);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form_Control";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_Record;
        private System.Windows.Forms.Timer joystick_keybord_Timer;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_joyConnect;
        private System.Windows.Forms.Button buttonURLConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_VideoConnect;
        private System.Windows.Forms.Timer ReserveKeybord_timer;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button button_Settings;
        public System.Windows.Forms.Panel panel1;
    }
}


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
            this.button_connect1 = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_Record = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.joystick_keybord_Timer = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button_joyConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Port1 = new System.Windows.Forms.TextBox();
            this.buttonURLConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_VideoConnect = new System.Windows.Forms.Button();
            this.textBox_VideoConnect = new System.Windows.Forms.TextBox();
            this.ReserveKeybord_timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.textBox_Port2 = new System.Windows.Forms.TextBox();
            this.textBox_TCP_2 = new System.Windows.Forms.TextBox();
            this.textBox_TCP_1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect1
            // 
            this.button_connect1.Location = new System.Drawing.Point(463, 41);
            this.button_connect1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_connect1.Name = "button_connect1";
            this.button_connect1.Size = new System.Drawing.Size(100, 28);
            this.button_connect1.TabIndex = 1;
            this.button_connect1.Text = "connect";
            this.button_connect1.UseVisualStyleBackColor = true;
            this.button_connect1.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(8, 32);
            this.button_left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(55, 28);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "left";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(128, 32);
            this.button_right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(55, 28);
            this.button_right.TabIndex = 3;
            this.button_right.Text = "right";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(69, 9);
            this.button_up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(55, 28);
            this.button_up.TabIndex = 4;
            this.button_up.Text = "up";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(69, 62);
            this.button_down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(55, 28);
            this.button_down.TabIndex = 5;
            this.button_down.Text = "down";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // button_Record
            // 
            this.button_Record.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Record.Location = new System.Drawing.Point(1076, 44);
            this.button_Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(100, 28);
            this.button_Record.TabIndex = 6;
            this.button_Record.Text = "Record";
            this.button_Record.UseVisualStyleBackColor = false;
            this.button_Record.Click += new System.EventHandler(this.button_Record_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(595, 9);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(100, 28);
            this.button_refresh.TabIndex = 7;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // joystick_keybord_Timer
            // 
            this.joystick_keybord_Timer.Enabled = true;
            this.joystick_keybord_Timer.Tick += new System.EventHandler(this.joystickTimer_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(172, 117);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(876, 423);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // button_joyConnect
            // 
            this.button_joyConnect.Location = new System.Drawing.Point(8, 146);
            this.button_joyConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_joyConnect.Name = "button_joyConnect";
            this.button_joyConnect.Size = new System.Drawing.Size(100, 28);
            this.button_joyConnect.TabIndex = 9;
            this.button_joyConnect.Text = "Joystic_Connect";
            this.button_joyConnect.UseVisualStyleBackColor = true;
            this.button_joyConnect.Click += new System.EventHandler(this.buttonJoysticConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "http://192.168.1.163/";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // textBox_Port1
            // 
            this.textBox_Port1.Location = new System.Drawing.Point(373, 44);
            this.textBox_Port1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Port1.Name = "textBox_Port1";
            this.textBox_Port1.Size = new System.Drawing.Size(67, 22);
            this.textBox_Port1.TabIndex = 12;
            this.textBox_Port1.Text = "2424";
            // 
            // buttonURLConnect
            // 
            this.buttonURLConnect.Location = new System.Drawing.Point(463, 7);
            this.buttonURLConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonURLConnect.Name = "buttonURLConnect";
            this.buttonURLConnect.Size = new System.Drawing.Size(124, 28);
            this.buttonURLConnect.TabIndex = 14;
            this.buttonURLConnect.Text = "URL_connect";
            this.buttonURLConnect.UseVisualStyleBackColor = true;
            this.buttonURLConnect.Click += new System.EventHandler(this.buttonURLConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(172, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button_VideoConnect
            // 
            this.button_VideoConnect.Location = new System.Drawing.Point(1076, 9);
            this.button_VideoConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_VideoConnect.Name = "button_VideoConnect";
            this.button_VideoConnect.Size = new System.Drawing.Size(100, 28);
            this.button_VideoConnect.TabIndex = 16;
            this.button_VideoConnect.Text = "Video";
            this.button_VideoConnect.UseVisualStyleBackColor = true;
            this.button_VideoConnect.Click += new System.EventHandler(this.button_VideoConnect_Click);
            // 
            // textBox_VideoConnect
            // 
            this.textBox_VideoConnect.Location = new System.Drawing.Point(721, 12);
            this.textBox_VideoConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_VideoConnect.Name = "textBox_VideoConnect";
            this.textBox_VideoConnect.Size = new System.Drawing.Size(345, 22);
            this.textBox_VideoConnect.TabIndex = 17;
            this.textBox_VideoConnect.Text = "http://192.168.1.163/:8080/?action=snapshot";
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_Port2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_TCP_2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.webBrowser1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_VideoConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_VideoConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.buttonURLConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_TCP_1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_Port1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_joyConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_refresh);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_Record);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_down);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_up);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_right);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_left);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_connect1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBox1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1187, 534);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1187, 534);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // textBox_Port2
            // 
            this.textBox_Port2.Location = new System.Drawing.Point(373, 75);
            this.textBox_Port2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Port2.Name = "textBox_Port2";
            this.textBox_Port2.Size = new System.Drawing.Size(67, 22);
            this.textBox_Port2.TabIndex = 19;
            this.textBox_Port2.Text = "2424";
            // 
            // textBox_TCP_2
            // 
            this.textBox_TCP_2.Location = new System.Drawing.Point(223, 76);
            this.textBox_TCP_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_TCP_2.Name = "textBox_TCP_2";
            this.textBox_TCP_2.Size = new System.Drawing.Size(113, 22);
            this.textBox_TCP_2.TabIndex = 18;
            this.textBox_TCP_2.Text = "192.168.0.111";
            // 
            // textBox_TCP_1
            // 
            this.textBox_TCP_1.Location = new System.Drawing.Point(223, 44);
            this.textBox_TCP_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TCP_1.Name = "textBox_TCP_1";
            this.textBox_TCP_1.Size = new System.Drawing.Size(113, 22);
            this.textBox_TCP_1.TabIndex = 11;
            this.textBox_TCP_1.Text = "192.168.0.110";
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 534);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Control";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connect1;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_Record;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Timer joystick_keybord_Timer;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button_joyConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_Port1;
        private System.Windows.Forms.Button buttonURLConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_VideoConnect;
        private System.Windows.Forms.TextBox textBox_VideoConnect;
        private System.Windows.Forms.Timer ReserveKeybord_timer;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox textBox_TCP_1;
        private System.Windows.Forms.TextBox textBox_Port2;
        private System.Windows.Forms.TextBox textBox_TCP_2;
    }
}


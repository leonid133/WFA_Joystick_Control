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
            this.joystick_keybord_Timer = new System.Windows.Forms.Timer(this.components);
            this.button_joyConnect = new System.Windows.Forms.Button();
            this.textBox_Port1 = new System.Windows.Forms.TextBox();
            this.ReserveKeybord_timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.button_Settings = new System.Windows.Forms.Button();
            this.textBox_Port2 = new System.Windows.Forms.TextBox();
            this.textBox_TCP_2 = new System.Windows.Forms.TextBox();
            this.textBox_TCP_1 = new System.Windows.Forms.TextBox();
            this.TimerConnectionStatus = new System.Windows.Forms.Timer(this.components);
            this.textBox_Statusbar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect1
            // 
            this.button_connect1.Location = new System.Drawing.Point(347, 33);
            this.button_connect1.Name = "button_connect1";
            this.button_connect1.Size = new System.Drawing.Size(75, 23);
            this.button_connect1.TabIndex = 1;
            this.button_connect1.Text = "connect";
            this.button_connect1.UseVisualStyleBackColor = true;
            this.button_connect1.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(6, 26);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(41, 23);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "left";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(96, 26);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(41, 23);
            this.button_right.TabIndex = 3;
            this.button_right.Text = "right";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(52, 7);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(41, 23);
            this.button_up.TabIndex = 4;
            this.button_up.Text = "up";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(52, 50);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(41, 23);
            this.button_down.TabIndex = 5;
            this.button_down.Text = "down";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // joystick_keybord_Timer
            // 
            this.joystick_keybord_Timer.Enabled = true;
            this.joystick_keybord_Timer.Tick += new System.EventHandler(this.joystick_and_keybord_Timer_Tick);
            // 
            // button_joyConnect
            // 
            this.button_joyConnect.Location = new System.Drawing.Point(6, 119);
            this.button_joyConnect.Name = "button_joyConnect";
            this.button_joyConnect.Size = new System.Drawing.Size(75, 23);
            this.button_joyConnect.TabIndex = 9;
            this.button_joyConnect.Text = "Joystic_Connect";
            this.button_joyConnect.UseVisualStyleBackColor = true;
            this.button_joyConnect.Click += new System.EventHandler(this.buttonJoysticConnect_Click);
            // 
            // textBox_Port1
            // 
            this.textBox_Port1.Location = new System.Drawing.Point(269, 26);
            this.textBox_Port1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Port1.Name = "textBox_Port1";
            this.textBox_Port1.Size = new System.Drawing.Size(51, 20);
            this.textBox_Port1.TabIndex = 12;
            this.textBox_Port1.Text = "2424";
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_Statusbar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_Settings);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_Port2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_TCP_2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_TCP_1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox_Port1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_joyConnect);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_down);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_up);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_right);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_left);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button_connect1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(463, 238);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(463, 238);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // button_Settings
            // 
            this.button_Settings.Location = new System.Drawing.Point(6, 155);
            this.button_Settings.Margin = new System.Windows.Forms.Padding(2);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(75, 24);
            this.button_Settings.TabIndex = 20;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // textBox_Port2
            // 
            this.textBox_Port2.Location = new System.Drawing.Point(269, 51);
            this.textBox_Port2.Name = "textBox_Port2";
            this.textBox_Port2.Size = new System.Drawing.Size(51, 20);
            this.textBox_Port2.TabIndex = 19;
            this.textBox_Port2.Text = "2424";
            // 
            // textBox_TCP_2
            // 
            this.textBox_TCP_2.Location = new System.Drawing.Point(177, 51);
            this.textBox_TCP_2.Name = "textBox_TCP_2";
            this.textBox_TCP_2.Size = new System.Drawing.Size(86, 20);
            this.textBox_TCP_2.TabIndex = 18;
            this.textBox_TCP_2.Text = "192.168.0.111";
            // 
            // textBox_TCP_1
            // 
            this.textBox_TCP_1.Location = new System.Drawing.Point(179, 26);
            this.textBox_TCP_1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TCP_1.Name = "textBox_TCP_1";
            this.textBox_TCP_1.Size = new System.Drawing.Size(86, 20);
            this.textBox_TCP_1.TabIndex = 11;
            this.textBox_TCP_1.Text = "192.168.0.110";
            // 
            // TimerConnectionStatus
            // 
            this.TimerConnectionStatus.Interval = 1000;
            this.TimerConnectionStatus.Tick += new System.EventHandler(this.TimerConnectionStatus_Tick);
            // 
            // textBox_Statusbar
            // 
            this.textBox_Statusbar.Location = new System.Drawing.Point(105, 85);
            this.textBox_Statusbar.Multiline = true;
            this.textBox_Statusbar.Name = "textBox_Statusbar";
            this.textBox_Statusbar.Size = new System.Drawing.Size(346, 141);
            this.textBox_Statusbar.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Адреса модулей laurent112";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "B";
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 238);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form_Control";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Timer joystick_keybord_Timer;
        private System.Windows.Forms.Button button_joyConnect;
        private System.Windows.Forms.TextBox textBox_Port1;
        private System.Windows.Forms.Timer ReserveKeybord_timer;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TextBox textBox_TCP_1;
        private System.Windows.Forms.TextBox textBox_Port2;
        private System.Windows.Forms.TextBox textBox_TCP_2;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Timer TimerConnectionStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Statusbar;
    }
}


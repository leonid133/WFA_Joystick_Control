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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox_Fix = new System.Windows.Forms.CheckBox();
            this.checkBox_Cam = new System.Windows.Forms.CheckBox();
            this.checkBox_light = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Statusbar = new System.Windows.Forms.TextBox();
            this.button_Settings = new System.Windows.Forms.Button();
            this.textBox_Port2 = new System.Windows.Forms.TextBox();
            this.textBox_TCP_2 = new System.Windows.Forms.TextBox();
            this.textBox_TCP_1 = new System.Windows.Forms.TextBox();
            this.TimerConnectionStatus = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connect1
            // 
            this.button_connect1.Location = new System.Drawing.Point(463, 41);
            this.button_connect1.Margin = new System.Windows.Forms.Padding(4);
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
            this.button_left.Margin = new System.Windows.Forms.Padding(4);
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
            this.button_right.Margin = new System.Windows.Forms.Padding(4);
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
            this.button_up.Margin = new System.Windows.Forms.Padding(4);
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
            this.button_down.Margin = new System.Windows.Forms.Padding(4);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(55, 28);
            this.button_down.TabIndex = 5;
            this.button_down.Text = "down";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // joystick_keybord_Timer
            // 
            this.joystick_keybord_Timer.Tick += new System.EventHandler(this.joystick_and_keybord_Timer_Tick);
            // 
            // button_joyConnect
            // 
            this.button_joyConnect.Location = new System.Drawing.Point(8, 146);
            this.button_joyConnect.Margin = new System.Windows.Forms.Padding(4);
            this.button_joyConnect.Name = "button_joyConnect";
            this.button_joyConnect.Size = new System.Drawing.Size(116, 28);
            this.button_joyConnect.TabIndex = 9;
            this.button_joyConnect.Text = "Joy_Connect";
            this.button_joyConnect.UseVisualStyleBackColor = true;
            this.button_joyConnect.Click += new System.EventHandler(this.buttonJoysticConnect_Click);
            // 
            // textBox_Port1
            // 
            this.textBox_Port1.Location = new System.Drawing.Point(359, 32);
            this.textBox_Port1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Port1.Name = "textBox_Port1";
            this.textBox_Port1.Size = new System.Drawing.Size(67, 22);
            this.textBox_Port1.TabIndex = 12;
            this.textBox_Port1.Text = "2424";
            // 
            // ReserveKeybord_timer
            // 
            this.ReserveKeybord_timer.Interval = 200;
            this.ReserveKeybord_timer.Tick += new System.EventHandler(this.ReserveKeybord_timer_Tick);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.checkBox_Fix);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.checkBox_Cam);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.checkBox_light);
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
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(840, 396);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(840, 396);
            this.toolStripContainer1.TabIndex = 18;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 301);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 22);
            this.textBox1.TabIndex = 28;
            // 
            // checkBox_Fix
            // 
            this.checkBox_Fix.AutoSize = true;
            this.checkBox_Fix.Location = new System.Drawing.Point(637, 105);
            this.checkBox_Fix.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Fix.Name = "checkBox_Fix";
            this.checkBox_Fix.Size = new System.Drawing.Size(188, 21);
            this.checkBox_Fix.TabIndex = 27;
            this.checkBox_Fix.Tag = "1";
            this.checkBox_Fix.Text = "Фиксация складывания";
            this.checkBox_Fix.UseVisualStyleBackColor = true;
            // 
            // checkBox_Cam
            // 
            this.checkBox_Cam.AutoSize = true;
            this.checkBox_Cam.Location = new System.Drawing.Point(637, 68);
            this.checkBox_Cam.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Cam.Name = "checkBox_Cam";
            this.checkBox_Cam.Size = new System.Drawing.Size(80, 21);
            this.checkBox_Cam.TabIndex = 26;
            this.checkBox_Cam.Tag = "1";
            this.checkBox_Cam.Text = "Камера";
            this.checkBox_Cam.UseVisualStyleBackColor = true;
            // 
            // checkBox_light
            // 
            this.checkBox_light.AutoSize = true;
            this.checkBox_light.Location = new System.Drawing.Point(637, 32);
            this.checkBox_light.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_light.Name = "checkBox_light";
            this.checkBox_light.Size = new System.Drawing.Size(103, 21);
            this.checkBox_light.TabIndex = 25;
            this.checkBox_light.Tag = "1";
            this.checkBox_light.Text = "Прожектор";
            this.checkBox_light.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Адреса модулей laurent112";
            // 
            // textBox_Statusbar
            // 
            this.textBox_Statusbar.Location = new System.Drawing.Point(140, 105);
            this.textBox_Statusbar.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Statusbar.Multiline = true;
            this.textBox_Statusbar.Name = "textBox_Statusbar";
            this.textBox_Statusbar.Size = new System.Drawing.Size(460, 173);
            this.textBox_Statusbar.TabIndex = 21;
            // 
            // button_Settings
            // 
            this.button_Settings.Location = new System.Drawing.Point(8, 191);
            this.button_Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(116, 30);
            this.button_Settings.TabIndex = 20;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // textBox_Port2
            // 
            this.textBox_Port2.Location = new System.Drawing.Point(359, 63);
            this.textBox_Port2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Port2.Name = "textBox_Port2";
            this.textBox_Port2.Size = new System.Drawing.Size(67, 22);
            this.textBox_Port2.TabIndex = 19;
            this.textBox_Port2.Text = "2424";
            // 
            // textBox_TCP_2
            // 
            this.textBox_TCP_2.Location = new System.Drawing.Point(236, 63);
            this.textBox_TCP_2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TCP_2.Name = "textBox_TCP_2";
            this.textBox_TCP_2.Size = new System.Drawing.Size(113, 22);
            this.textBox_TCP_2.TabIndex = 18;
            this.textBox_TCP_2.Text = "192.168.0.111";
            // 
            // textBox_TCP_1
            // 
            this.textBox_TCP_1.Location = new System.Drawing.Point(239, 32);
            this.textBox_TCP_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TCP_1.Name = "textBox_TCP_1";
            this.textBox_TCP_1.Size = new System.Drawing.Size(113, 22);
            this.textBox_TCP_1.TabIndex = 11;
            this.textBox_TCP_1.Text = "192.168.0.110";
            // 
            // TimerConnectionStatus
            // 
            this.TimerConnectionStatus.Interval = 1000;
            this.TimerConnectionStatus.Tick += new System.EventHandler(this.TimerConnectionStatus_Tick);
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 396);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.CheckBox checkBox_light;
        private System.Windows.Forms.CheckBox checkBox_Fix;
        private System.Windows.Forms.CheckBox checkBox_Cam;
        private System.Windows.Forms.TextBox textBox1;
    }
}


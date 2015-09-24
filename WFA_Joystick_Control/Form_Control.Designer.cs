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
            this.textBox_TCP_1 = new System.Windows.Forms.TextBox();
            this.textBox_Port1 = new System.Windows.Forms.TextBox();
            this.button_disconnect1 = new System.Windows.Forms.Button();
            this.buttonURLConnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connect1
            // 
            this.button_connect1.Location = new System.Drawing.Point(436, 46);
            this.button_connect1.Name = "button_connect1";
            this.button_connect1.Size = new System.Drawing.Size(75, 23);
            this.button_connect1.TabIndex = 1;
            this.button_connect1.Text = "connect";
            this.button_connect1.UseVisualStyleBackColor = true;
            this.button_connect1.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(12, 75);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 23);
            this.button_left.TabIndex = 2;
            this.button_left.Text = "left";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(109, 75);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 23);
            this.button_right.TabIndex = 3;
            this.button_right.Text = "right";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(59, 46);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(75, 23);
            this.button_up.TabIndex = 4;
            this.button_up.Text = "up";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(59, 104);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(75, 23);
            this.button_down.TabIndex = 5;
            this.button_down.Text = "down";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // button_Record
            // 
            this.button_Record.BackColor = System.Drawing.Color.OrangeRed;
            this.button_Record.Location = new System.Drawing.Point(12, 143);
            this.button_Record.Name = "button_Record";
            this.button_Record.Size = new System.Drawing.Size(75, 23);
            this.button_Record.TabIndex = 6;
            this.button_Record.Text = "Record";
            this.button_Record.UseVisualStyleBackColor = false;
            this.button_Record.Click += new System.EventHandler(this.button_Record_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(535, 10);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
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
            this.webBrowser1.Location = new System.Drawing.Point(225, 84);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(423, 158);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // button_joyConnect
            // 
            this.button_joyConnect.Location = new System.Drawing.Point(13, 183);
            this.button_joyConnect.Name = "button_joyConnect";
            this.button_joyConnect.Size = new System.Drawing.Size(75, 23);
            this.button_joyConnect.TabIndex = 9;
            this.button_joyConnect.Text = "Joystic_Connect";
            this.button_joyConnect.UseVisualStyleBackColor = true;
            this.button_joyConnect.Click += new System.EventHandler(this.buttonJoysticConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(254, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "http://192.168.1.163:80/";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // textBox_TCP_1
            // 
            this.textBox_TCP_1.Location = new System.Drawing.Point(254, 50);
            this.textBox_TCP_1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TCP_1.Name = "textBox_TCP_1";
            this.textBox_TCP_1.Size = new System.Drawing.Size(86, 20);
            this.textBox_TCP_1.TabIndex = 11;
            this.textBox_TCP_1.Text = "192.168.0.110";
            // 
            // textBox_Port1
            // 
            this.textBox_Port1.Location = new System.Drawing.Point(367, 50);
            this.textBox_Port1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Port1.Name = "textBox_Port1";
            this.textBox_Port1.Size = new System.Drawing.Size(51, 20);
            this.textBox_Port1.TabIndex = 12;
            this.textBox_Port1.Text = "2424";
            // 
            // button_disconnect1
            // 
            this.button_disconnect1.Location = new System.Drawing.Point(535, 46);
            this.button_disconnect1.Margin = new System.Windows.Forms.Padding(2);
            this.button_disconnect1.Name = "button_disconnect1";
            this.button_disconnect1.Size = new System.Drawing.Size(70, 23);
            this.button_disconnect1.TabIndex = 13;
            this.button_disconnect1.Text = "disconnect";
            this.button_disconnect1.UseVisualStyleBackColor = true;
            this.button_disconnect1.Click += new System.EventHandler(this.button_disconnect1_Click);
            // 
            // buttonURLConnect
            // 
            this.buttonURLConnect.Location = new System.Drawing.Point(436, 9);
            this.buttonURLConnect.Name = "buttonURLConnect";
            this.buttonURLConnect.Size = new System.Drawing.Size(93, 23);
            this.buttonURLConnect.TabIndex = 14;
            this.buttonURLConnect.Text = "URL_connect";
            this.buttonURLConnect.UseVisualStyleBackColor = true;
            this.buttonURLConnect.Click += new System.EventHandler(this.buttonURLConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 220);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonURLConnect);
            this.Controls.Add(this.button_disconnect1);
            this.Controls.Add(this.textBox_TCP_1);
            this.Controls.Add(this.textBox_Port1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_joyConnect);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_Record);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_connect1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form_Control";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox_TCP_1;
        private System.Windows.Forms.TextBox textBox_Port1;
        private System.Windows.Forms.Button button_disconnect1;
        private System.Windows.Forms.Button buttonURLConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


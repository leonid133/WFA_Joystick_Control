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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.joystickTimer = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_TCP_1 = new System.Windows.Forms.TextBox();
            this.textBox_Port1 = new System.Windows.Forms.TextBox();
            this.button_disconnect1 = new System.Windows.Forms.Button();
            this.keybordTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_connect1
            // 
            this.button_connect1.Location = new System.Drawing.Point(582, 57);
            this.button_connect1.Margin = new System.Windows.Forms.Padding(4);
            this.button_connect1.Name = "button_connect1";
            this.button_connect1.Size = new System.Drawing.Size(100, 28);
            this.button_connect1.TabIndex = 1;
            this.button_connect1.Text = "connect";
            this.button_connect1.UseVisualStyleBackColor = true;
            this.button_connect1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 92);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "left";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 92);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "right";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(79, 57);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "up";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(79, 128);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "down";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.Location = new System.Drawing.Point(16, 176);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Record";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(171, 15);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 28);
            this.button7.TabIndex = 7;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // joystickTimer
            // 
            this.joystickTimer.Enabled = true;
            this.joystickTimer.Tick += new System.EventHandler(this.joystickTimer_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1259, 623);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(17, 225);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 28);
            this.button8.TabIndex = 9;
            this.button8.Text = "Joystic_Connect";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "http://192.168.1.163:80/";
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // textBox_TCP_1
            // 
            this.textBox_TCP_1.Location = new System.Drawing.Point(339, 62);
            this.textBox_TCP_1.Name = "textBox_TCP_1";
            this.textBox_TCP_1.Size = new System.Drawing.Size(114, 22);
            this.textBox_TCP_1.TabIndex = 11;
            this.textBox_TCP_1.Text = "192.168.0.110";
            // 
            // textBox_Port1
            // 
            this.textBox_Port1.Location = new System.Drawing.Point(489, 62);
            this.textBox_Port1.Name = "textBox_Port1";
            this.textBox_Port1.Size = new System.Drawing.Size(67, 22);
            this.textBox_Port1.TabIndex = 12;
            this.textBox_Port1.Text = "2424";
            // 
            // button_disconnect1
            // 
            this.button_disconnect1.Location = new System.Drawing.Point(713, 57);
            this.button_disconnect1.Name = "button_disconnect1";
            this.button_disconnect1.Size = new System.Drawing.Size(93, 28);
            this.button_disconnect1.TabIndex = 13;
            this.button_disconnect1.Text = "disconnect";
            this.button_disconnect1.UseVisualStyleBackColor = true;
            this.button_disconnect1.Click += new System.EventHandler(this.button_disconnect1_Click);
            // 
            // keybordTimer
            // 
            this.keybordTimer.Enabled = true;
            this.keybordTimer.Interval = 200;
            this.keybordTimer.Tick += new System.EventHandler(this.keybordTimerTick);
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 623);
            this.Controls.Add(this.button_disconnect1);
            this.Controls.Add(this.textBox_TCP_1);
            this.Controls.Add(this.textBox_Port1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_connect1);
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Control";
            this.Text = "Управление";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connect1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer joystickTimer;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_TCP_1;
        private System.Windows.Forms.TextBox textBox_Port1;
        private System.Windows.Forms.Button button_disconnect1;
        private System.Windows.Forms.Timer keybordTimer;
    }
}


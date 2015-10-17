namespace WFA_Joystick_Control
{
    partial class Form_Settings
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
            this.button_w = new System.Windows.Forms.Button();
            this.button_s = new System.Windows.Forms.Button();
            this.button_a = new System.Windows.Forms.Button();
            this.button_d = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Right = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_Num6 = new System.Windows.Forms.Button();
            this.button_Num4 = new System.Windows.Forms.Button();
            this.button_Num2 = new System.Windows.Forms.Button();
            this.button_Num8 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button_Num5 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.button_2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.button_1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.joystick_settings_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_w
            // 
            this.button_w.Location = new System.Drawing.Point(171, 55);
            this.button_w.Name = "button_w";
            this.button_w.Size = new System.Drawing.Size(125, 23);
            this.button_w.TabIndex = 1;
            this.button_w.Text = "w";
            this.button_w.UseVisualStyleBackColor = true;
            this.button_w.Click += new System.EventHandler(this.button_w_Click);
            this.button_w.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_s
            // 
            this.button_s.Location = new System.Drawing.Point(171, 100);
            this.button_s.Name = "button_s";
            this.button_s.Size = new System.Drawing.Size(125, 23);
            this.button_s.TabIndex = 1;
            this.button_s.Text = "s";
            this.button_s.UseVisualStyleBackColor = true;
            this.button_s.Click += new System.EventHandler(this.button_s_Click);
            this.button_s.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_a
            // 
            this.button_a.Location = new System.Drawing.Point(171, 145);
            this.button_a.Name = "button_a";
            this.button_a.Size = new System.Drawing.Size(125, 23);
            this.button_a.TabIndex = 1;
            this.button_a.Text = "a";
            this.button_a.UseVisualStyleBackColor = true;
            this.button_a.Click += new System.EventHandler(this.button_a_Click);
            this.button_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_d
            // 
            this.button_d.Location = new System.Drawing.Point(171, 190);
            this.button_d.Name = "button_d";
            this.button_d.Size = new System.Drawing.Size(125, 23);
            this.button_d.TabIndex = 1;
            this.button_d.Text = "d";
            this.button_d.UseVisualStyleBackColor = true;
            this.button_d.Click += new System.EventHandler(this.button_d_Click);
            this.button_d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(342, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите клавишу для действия || Выберите действие на джойстике";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Движение вперед:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Движение назад:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Движение влево:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Движение вправо:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Поворот пушки вправо:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Поворот пушки влево:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Опускание пушки:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Подъем пушки:";
            // 
            // button_Right
            // 
            this.button_Right.Location = new System.Drawing.Point(171, 420);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(125, 23);
            this.button_Right.TabIndex = 4;
            this.button_Right.Text = "Right";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            this.button_Right.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(171, 375);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(125, 23);
            this.button_Left.TabIndex = 3;
            this.button_Left.Text = "Left";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            this.button_Left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_Down
            // 
            this.button_Down.Location = new System.Drawing.Point(171, 330);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(125, 23);
            this.button_Down.TabIndex = 5;
            this.button_Down.Text = "Down";
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Down_Click);
            this.button_Down.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_Up
            // 
            this.button_Up.Location = new System.Drawing.Point(171, 285);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(125, 23);
            this.button_Up.TabIndex = 6;
            this.button_Up.Text = "Up";
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.button_Up_Click);
            this.button_Up.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Складывание:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Раскладывание:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 26);
            this.label12.TabIndex = 17;
            this.label12.Text = "Складывание по вертикали \r\n(вниз):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 26);
            this.label13.TabIndex = 18;
            this.label13.Text = "Складывание по вертикали\r\n (вверх):";
            // 
            // button_Num6
            // 
            this.button_Num6.Location = new System.Drawing.Point(477, 189);
            this.button_Num6.Name = "button_Num6";
            this.button_Num6.Size = new System.Drawing.Size(125, 23);
            this.button_Num6.TabIndex = 12;
            this.button_Num6.Text = "Num6";
            this.button_Num6.UseVisualStyleBackColor = true;
            this.button_Num6.Click += new System.EventHandler(this.button_Num6_Click);
            this.button_Num6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_Num4
            // 
            this.button_Num4.Location = new System.Drawing.Point(477, 144);
            this.button_Num4.Name = "button_Num4";
            this.button_Num4.Size = new System.Drawing.Size(125, 23);
            this.button_Num4.TabIndex = 11;
            this.button_Num4.Text = "Num4";
            this.button_Num4.UseVisualStyleBackColor = true;
            this.button_Num4.Click += new System.EventHandler(this.button_Num4_Click);
            this.button_Num4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_Num2
            // 
            this.button_Num2.Location = new System.Drawing.Point(477, 99);
            this.button_Num2.Name = "button_Num2";
            this.button_Num2.Size = new System.Drawing.Size(125, 23);
            this.button_Num2.TabIndex = 13;
            this.button_Num2.Text = "Num2";
            this.button_Num2.UseVisualStyleBackColor = true;
            this.button_Num2.Click += new System.EventHandler(this.button_Num2_Click);
            this.button_Num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_Num8
            // 
            this.button_Num8.Location = new System.Drawing.Point(477, 54);
            this.button_Num8.Name = "button_Num8";
            this.button_Num8.Size = new System.Drawing.Size(125, 23);
            this.button_Num8.TabIndex = 14;
            this.button_Num8.Text = "Num8";
            this.button_Num8.UseVisualStyleBackColor = true;
            this.button_Num8.Click += new System.EventHandler(this.button_Num8_Click);
            this.button_Num8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 26);
            this.label14.TabIndex = 20;
            this.label14.Text = "Фиксация вертикального \r\nскладывания:";
            // 
            // button_Num5
            // 
            this.button_Num5.Location = new System.Drawing.Point(477, 234);
            this.button_Num5.Name = "button_Num5";
            this.button_Num5.Size = new System.Drawing.Size(125, 23);
            this.button_Num5.TabIndex = 19;
            this.button_Num5.Text = "Num5";
            this.button_Num5.UseVisualStyleBackColor = true;
            this.button_Num5.Click += new System.EventHandler(this.button_Num5_Click);
            this.button_Num5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(621, 197);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(161, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "Доп. оборудование №2 (вниз):";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(621, 152);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(166, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Доп. оборудование №2 (вверх):";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(621, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(161, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Доп. оборудование №1 (вниз):";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(621, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(166, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Доп. оборудование №1 (вверх):";
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(789, 192);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(125, 23);
            this.button_6.TabIndex = 22;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            this.button_6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(789, 147);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(125, 23);
            this.button_5.TabIndex = 21;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            this.button_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(789, 100);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(125, 23);
            this.button_4.TabIndex = 24;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            this.button_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(789, 55);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(125, 23);
            this.button_3.TabIndex = 23;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            this.button_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(312, 425);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 40;
            this.label23.Text = "Камера:";
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(477, 420);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(125, 23);
            this.button_2.TabIndex = 39;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            this.button_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(312, 380);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "Прожектор:";
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(477, 375);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(125, 23);
            this.button_1.TabIndex = 37;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            this.button_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(621, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Доп. оборудование №4 (вниз):";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(621, 380);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Доп. оборудование №4 (вверх):";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(621, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "Доп. оборудование №3 (вниз):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(621, 288);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Доп. оборудование №3 (вверх):";
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(789, 420);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(125, 23);
            this.button_0.TabIndex = 42;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            this.button_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(789, 375);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(125, 23);
            this.button_9.TabIndex = 41;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            this.button_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(789, 328);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(125, 23);
            this.button_8.TabIndex = 44;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            this.button_8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(789, 283);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(125, 23);
            this.button_7.TabIndex = 43;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            this.button_7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            // 
            // joystick_settings_Timer
            // 
            this.joystick_settings_Timer.Tick += new System.EventHandler(this.joystick_settings_Timer_Tick);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 490);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button_Num5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_Num6);
            this.Controls.Add(this.button_Num4);
            this.Controls.Add(this.button_Num2);
            this.Controls.Add(this.button_Num8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Down);
            this.Controls.Add(this.button_Up);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_d);
            this.Controls.Add(this.button_a);
            this.Controls.Add(this.button_s);
            this.Controls.Add(this.button_w);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Settings";
            this.Text = "Настройки";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetPressedKey_FromTheCurrentButton);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.control_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_w;
        private System.Windows.Forms.Button button_s;
        private System.Windows.Forms.Button button_a;
        private System.Windows.Forms.Button button_d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_Num6;
        private System.Windows.Forms.Button button_Num4;
        private System.Windows.Forms.Button button_Num2;
        private System.Windows.Forms.Button button_Num8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button_Num5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Timer joystick_settings_Timer;
    }
}
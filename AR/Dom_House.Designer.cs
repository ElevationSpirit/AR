namespace AR
{
    partial class Dom_House
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.A_off = new System.Windows.Forms.RadioButton();
            this.A_on = new System.Windows.Forms.RadioButton();
            this.HPBuy = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ASpeedGain = new System.Windows.Forms.Button();
            this.DmgGain = new System.Windows.Forms.Button();
            this.HPgain = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Прыг в портал";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "В лавку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.A_off);
            this.groupBox1.Controls.Add(this.A_on);
            this.groupBox1.Controls.Add(this.HPBuy);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.ASpeedGain);
            this.groupBox1.Controls.Add(this.DmgGain);
            this.groupBox1.Controls.Add(this.HPgain);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // A_off
            // 
            this.A_off.AutoSize = true;
            this.A_off.Location = new System.Drawing.Point(5, 185);
            this.A_off.Name = "A_off";
            this.A_off.Size = new System.Drawing.Size(83, 17);
            this.A_off.TabIndex = 6;
            this.A_off.TabStop = true;
            this.A_off.Text = "Выключена";
            this.A_off.UseVisualStyleBackColor = true;
            // 
            // A_on
            // 
            this.A_on.AutoSize = true;
            this.A_on.Location = new System.Drawing.Point(5, 162);
            this.A_on.Name = "A_on";
            this.A_on.Size = new System.Drawing.Size(75, 17);
            this.A_on.TabIndex = 6;
            this.A_on.TabStop = true;
            this.A_on.Text = "Включена";
            this.A_on.UseVisualStyleBackColor = true;
            this.A_on.CheckedChanged += new System.EventHandler(this.A_on_CheckedChanged);
            // 
            // HPBuy
            // 
            this.HPBuy.Location = new System.Drawing.Point(88, 179);
            this.HPBuy.Name = "HPBuy";
            this.HPBuy.Size = new System.Drawing.Size(181, 23);
            this.HPBuy.TabIndex = 3;
            this.HPBuy.Text = "Пополнить хп (10 монет)";
            this.HPBuy.UseVisualStyleBackColor = true;
            this.HPBuy.Click += new System.EventHandler(this.HPBuy_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(88, 154);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Скилпоинты";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(88, 127);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            // 
            // ASpeedGain
            // 
            this.ASpeedGain.Location = new System.Drawing.Point(194, 71);
            this.ASpeedGain.Name = "ASpeedGain";
            this.ASpeedGain.Size = new System.Drawing.Size(75, 23);
            this.ASpeedGain.TabIndex = 2;
            this.ASpeedGain.Text = "Качнуть";
            this.ASpeedGain.UseVisualStyleBackColor = true;
            this.ASpeedGain.Click += new System.EventHandler(this.ASpeedGain_Click);
            // 
            // DmgGain
            // 
            this.DmgGain.Location = new System.Drawing.Point(194, 44);
            this.DmgGain.Name = "DmgGain";
            this.DmgGain.Size = new System.Drawing.Size(75, 23);
            this.DmgGain.TabIndex = 2;
            this.DmgGain.Text = "Качнуть";
            this.DmgGain.UseVisualStyleBackColor = true;
            this.DmgGain.Click += new System.EventHandler(this.DmgGain_Click);
            // 
            // HPgain
            // 
            this.HPgain.Location = new System.Drawing.Point(195, 17);
            this.HPgain.Name = "HPgain";
            this.HPgain.Size = new System.Drawing.Size(75, 23);
            this.HPgain.TabIndex = 2;
            this.HPgain.Text = "Качнуть";
            this.HPgain.UseVisualStyleBackColor = true;
            this.HPgain.Click += new System.EventHandler(this.HPgain_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Голден винд";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Атак спид";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дамаг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Здоровье ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(88, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(293, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 212);
            this.listBox1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(26, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(10, 8);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Dom_House
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 269);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Dom_House";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House";
            this.Activated += new System.EventHandler(this.Dom_House_Activated);
            this.Load += new System.EventHandler(this.Dom_House_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ASpeedGain;
        private System.Windows.Forms.Button DmgGain;
        private System.Windows.Forms.Button HPgain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button HPBuy;
        private System.Windows.Forms.RadioButton A_off;
        private System.Windows.Forms.RadioButton A_on;
    }
}
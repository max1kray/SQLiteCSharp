namespace SQLiteCSharp
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFIO = new System.Windows.Forms.MaskedTextBox();
            this.tbLOGIN = new System.Windows.Forms.MaskedTextBox();
            this.tbDATE = new System.Windows.Forms.MaskedTextBox();
            this.tbGROUP = new System.Windows.Forms.MaskedTextBox();
            this.tbSTAVKA = new System.Windows.Forms.MaskedTextBox();
            this.tbPROC = new System.Windows.Forms.MaskedTextBox();
            this.tbLIM = new System.Windows.Forms.MaskedTextBox();
            this.tbNACH = new System.Windows.Forms.MaskedTextBox();
            this.tbPASS = new System.Windows.Forms.MaskedTextBox();
            this.ifAdd = new System.Windows.Forms.RadioButton();
            this.ifDel = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Группа";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата поступления на работу";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Пароль";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ФИО Начальника";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Лимит суммарной надбавки";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Процент за год работы";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ставка";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Логин";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ФИО Сотрудника";
            this.label10.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(175, 38);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(196, 20);
            this.tbFIO.TabIndex = 21;
            this.tbFIO.Visible = false;
            // 
            // tbLOGIN
            // 
            this.tbLOGIN.Location = new System.Drawing.Point(175, 67);
            this.tbLOGIN.Name = "tbLOGIN";
            this.tbLOGIN.Size = new System.Drawing.Size(196, 20);
            this.tbLOGIN.TabIndex = 22;
            this.tbLOGIN.Visible = false;
            // 
            // tbDATE
            // 
            this.tbDATE.Location = new System.Drawing.Point(175, 93);
            this.tbDATE.Mask = "00.00.0000";
            this.tbDATE.Name = "tbDATE";
            this.tbDATE.Size = new System.Drawing.Size(196, 20);
            this.tbDATE.TabIndex = 23;
            this.tbDATE.ValidatingType = typeof(System.DateTime);
            this.tbDATE.Visible = false;
            // 
            // tbGROUP
            // 
            this.tbGROUP.Location = new System.Drawing.Point(175, 119);
            this.tbGROUP.Name = "tbGROUP";
            this.tbGROUP.Size = new System.Drawing.Size(196, 20);
            this.tbGROUP.TabIndex = 25;
            this.tbGROUP.Visible = false;
            // 
            // tbSTAVKA
            // 
            this.tbSTAVKA.Location = new System.Drawing.Point(175, 145);
            this.tbSTAVKA.Name = "tbSTAVKA";
            this.tbSTAVKA.Size = new System.Drawing.Size(196, 20);
            this.tbSTAVKA.TabIndex = 26;
            this.tbSTAVKA.Visible = false;
            // 
            // tbPROC
            // 
            this.tbPROC.Location = new System.Drawing.Point(175, 171);
            this.tbPROC.Name = "tbPROC";
            this.tbPROC.Size = new System.Drawing.Size(196, 20);
            this.tbPROC.TabIndex = 27;
            this.tbPROC.Visible = false;
            // 
            // tbLIM
            // 
            this.tbLIM.Location = new System.Drawing.Point(175, 197);
            this.tbLIM.Name = "tbLIM";
            this.tbLIM.Size = new System.Drawing.Size(196, 20);
            this.tbLIM.TabIndex = 28;
            this.tbLIM.Visible = false;
            // 
            // tbNACH
            // 
            this.tbNACH.Location = new System.Drawing.Point(175, 223);
            this.tbNACH.Name = "tbNACH";
            this.tbNACH.Size = new System.Drawing.Size(196, 20);
            this.tbNACH.TabIndex = 29;
            this.tbNACH.Visible = false;
            // 
            // tbPASS
            // 
            this.tbPASS.Location = new System.Drawing.Point(175, 249);
            this.tbPASS.Name = "tbPASS";
            this.tbPASS.Size = new System.Drawing.Size(196, 20);
            this.tbPASS.TabIndex = 30;
            this.tbPASS.Visible = false;
            // 
            // ifAdd
            // 
            this.ifAdd.AutoSize = true;
            this.ifAdd.Location = new System.Drawing.Point(15, 12);
            this.ifAdd.Name = "ifAdd";
            this.ifAdd.Size = new System.Drawing.Size(149, 17);
            this.ifAdd.TabIndex = 31;
            this.ifAdd.Text = "Добавить пользователя";
            this.ifAdd.UseVisualStyleBackColor = true;
            this.ifAdd.CheckedChanged += new System.EventHandler(this.IfAdd_CheckedChanged);
            // 
            // ifDel
            // 
            this.ifDel.AutoSize = true;
            this.ifDel.Location = new System.Drawing.Point(170, 12);
            this.ifDel.Name = "ifDel";
            this.ifDel.Size = new System.Drawing.Size(142, 17);
            this.ifDel.TabIndex = 32;
            this.ifDel.Text = "Удалить пользователя";
            this.ifDel.UseVisualStyleBackColor = true;
            this.ifDel.CheckedChanged += new System.EventHandler(this.IfDel_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(60, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 39);
            this.label3.TabIndex = 35;
            this.label3.Text = "УДАЛЯЙСЯ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLiteCSharp.Properties.Resources.kana200;
            this.pictureBox1.Location = new System.Drawing.Point(169, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 191);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ifDel);
            this.Controls.Add(this.ifAdd);
            this.Controls.Add(this.tbPASS);
            this.Controls.Add(this.tbNACH);
            this.Controls.Add(this.tbLIM);
            this.Controls.Add(this.tbPROC);
            this.Controls.Add(this.tbSTAVKA);
            this.Controls.Add(this.tbGROUP);
            this.Controls.Add(this.tbDATE);
            this.Controls.Add(this.tbLOGIN);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "SQLiteCSharp";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox tbFIO;
        private System.Windows.Forms.MaskedTextBox tbLOGIN;
        private System.Windows.Forms.MaskedTextBox tbDATE;
        private System.Windows.Forms.MaskedTextBox tbGROUP;
        private System.Windows.Forms.MaskedTextBox tbSTAVKA;
        private System.Windows.Forms.MaskedTextBox tbPROC;
        private System.Windows.Forms.MaskedTextBox tbLIM;
        private System.Windows.Forms.MaskedTextBox tbNACH;
        private System.Windows.Forms.MaskedTextBox tbPASS;
        private System.Windows.Forms.RadioButton ifAdd;
        private System.Windows.Forms.RadioButton ifDel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
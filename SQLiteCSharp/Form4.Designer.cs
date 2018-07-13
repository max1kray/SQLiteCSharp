namespace SQLiteCSharp
{
    partial class Form4
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
            this.rbLogin = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.btLogin = new System.Windows.Forms.Button();
            this.btPass = new System.Windows.Forms.Button();
            this.tbOldLog = new System.Windows.Forms.TextBox();
            this.tbNewLog = new System.Windows.Forms.TextBox();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbNewPass2 = new System.Windows.Forms.TextBox();
            this.lOldLog = new System.Windows.Forms.Label();
            this.lNewLog = new System.Windows.Forms.Label();
            this.lOldPass = new System.Windows.Forms.Label();
            this.lNewPass = new System.Windows.Forms.Label();
            this.lNewPass2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbLogin
            // 
            this.rbLogin.AutoSize = true;
            this.rbLogin.Location = new System.Drawing.Point(12, 12);
            this.rbLogin.Name = "rbLogin";
            this.rbLogin.Size = new System.Drawing.Size(108, 17);
            this.rbLogin.TabIndex = 0;
            this.rbLogin.Text = "Изменить логин";
            this.rbLogin.UseVisualStyleBackColor = true;
            this.rbLogin.CheckedChanged += new System.EventHandler(this.RbLogin_CheckedChanged);
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.Location = new System.Drawing.Point(136, 12);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(115, 17);
            this.rbPass.TabIndex = 1;
            this.rbPass.Text = "Изменить пароль";
            this.rbPass.UseVisualStyleBackColor = true;
            this.rbPass.CheckedChanged += new System.EventHandler(this.RbPass_CheckedChanged);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(45, 154);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "OK";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // btPass
            // 
            this.btPass.Location = new System.Drawing.Point(176, 154);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(75, 23);
            this.btPass.TabIndex = 3;
            this.btPass.Text = "OK";
            this.btPass.UseVisualStyleBackColor = true;
            this.btPass.Click += new System.EventHandler(this.BtPass_Click);
            // 
            // tbOldLog
            // 
            this.tbOldLog.Location = new System.Drawing.Point(20, 58);
            this.tbOldLog.Name = "tbOldLog";
            this.tbOldLog.Size = new System.Drawing.Size(100, 20);
            this.tbOldLog.TabIndex = 4;
            // 
            // tbNewLog
            // 
            this.tbNewLog.Location = new System.Drawing.Point(20, 128);
            this.tbNewLog.Name = "tbNewLog";
            this.tbNewLog.Size = new System.Drawing.Size(100, 20);
            this.tbNewLog.TabIndex = 5;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(151, 58);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Size = new System.Drawing.Size(100, 20);
            this.tbOldPass.TabIndex = 6;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(151, 93);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(100, 20);
            this.tbNewPass.TabIndex = 7;
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Location = new System.Drawing.Point(151, 128);
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.Size = new System.Drawing.Size(100, 20);
            this.tbNewPass2.TabIndex = 8;
            // 
            // lOldLog
            // 
            this.lOldLog.AutoSize = true;
            this.lOldLog.Location = new System.Drawing.Point(17, 42);
            this.lOldLog.Name = "lOldLog";
            this.lOldLog.Size = new System.Drawing.Size(77, 13);
            this.lOldLog.TabIndex = 9;
            this.lOldLog.Text = "Старый логин";
            // 
            // lNewLog
            // 
            this.lNewLog.AutoSize = true;
            this.lNewLog.Location = new System.Drawing.Point(17, 112);
            this.lNewLog.Name = "lNewLog";
            this.lNewLog.Size = new System.Drawing.Size(73, 13);
            this.lNewLog.TabIndex = 10;
            this.lNewLog.Text = "Новый логин";
            // 
            // lOldPass
            // 
            this.lOldPass.AutoSize = true;
            this.lOldPass.Location = new System.Drawing.Point(148, 42);
            this.lOldPass.Name = "lOldPass";
            this.lOldPass.Size = new System.Drawing.Size(84, 13);
            this.lOldPass.TabIndex = 11;
            this.lOldPass.Text = "Старый пароль";
            // 
            // lNewPass
            // 
            this.lNewPass.AutoSize = true;
            this.lNewPass.Location = new System.Drawing.Point(148, 77);
            this.lNewPass.Name = "lNewPass";
            this.lNewPass.Size = new System.Drawing.Size(80, 13);
            this.lNewPass.TabIndex = 12;
            this.lNewPass.Text = "Новый пароль";
            // 
            // lNewPass2
            // 
            this.lNewPass2.AutoSize = true;
            this.lNewPass2.Location = new System.Drawing.Point(148, 112);
            this.lNewPass2.Name = "lNewPass2";
            this.lNewPass2.Size = new System.Drawing.Size(88, 13);
            this.lNewPass2.TabIndex = 13;
            this.lNewPass2.Text = "Подтверждение";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 188);
            this.Controls.Add(this.lNewPass2);
            this.Controls.Add(this.lNewPass);
            this.Controls.Add(this.lOldPass);
            this.Controls.Add(this.lNewLog);
            this.Controls.Add(this.lOldLog);
            this.Controls.Add(this.tbNewPass2);
            this.Controls.Add(this.tbNewPass);
            this.Controls.Add(this.tbOldPass);
            this.Controls.Add(this.tbNewLog);
            this.Controls.Add(this.tbOldLog);
            this.Controls.Add(this.btPass);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.rbPass);
            this.Controls.Add(this.rbLogin);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "SQLiteCSharp";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbLogin;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btPass;
        private System.Windows.Forms.TextBox tbOldLog;
        private System.Windows.Forms.TextBox tbNewLog;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbNewPass2;
        private System.Windows.Forms.Label lOldLog;
        private System.Windows.Forms.Label lNewLog;
        private System.Windows.Forms.Label lOldPass;
        private System.Windows.Forms.Label lNewPass;
        private System.Windows.Forms.Label lNewPass2;
    }
}
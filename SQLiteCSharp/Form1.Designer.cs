namespace SQLiteCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataView4user = new System.Windows.Forms.DataGridView();
            this.ФИО_Сотрудника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_поступления_на_работу = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Группа = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ставка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО_Начальника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЗП = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataView4sub = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tbUpdate = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btSumZp = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataView4user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView4sub)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView4user
            // 
            this.dataView4user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView4user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView4user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ФИО_Сотрудника,
            this.Дата_поступления_на_работу,
            this.Группа,
            this.Ставка,
            this.ФИО_Начальника,
            this.ЗП});
            this.dataView4user.Location = new System.Drawing.Point(0, 25);
            this.dataView4user.Name = "dataView4user";
            this.dataView4user.RowHeadersVisible = false;
            this.dataView4user.Size = new System.Drawing.Size(763, 93);
            this.dataView4user.TabIndex = 0;
            // 
            // ФИО_Сотрудника
            // 
            this.ФИО_Сотрудника.HeaderText = "ФИО Сотрудника";
            this.ФИО_Сотрудника.Name = "ФИО_Сотрудника";
            // 
            // Дата_поступления_на_работу
            // 
            this.Дата_поступления_на_работу.HeaderText = "Дата поступления на работу";
            this.Дата_поступления_на_работу.Name = "Дата_поступления_на_работу";
            // 
            // Группа
            // 
            this.Группа.HeaderText = "Группа";
            this.Группа.Name = "Группа";
            // 
            // Ставка
            // 
            this.Ставка.HeaderText = "Ставка";
            this.Ставка.Name = "Ставка";
            // 
            // ФИО_Начальника
            // 
            this.ФИО_Начальника.HeaderText = "ФИО Начальника";
            this.ФИО_Начальника.Name = "ФИО_Начальника";
            // 
            // ЗП
            // 
            this.ЗП.HeaderText = "ЗП";
            this.ЗП.Name = "ЗП";
            // 
            // dataView4sub
            // 
            this.dataView4sub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView4sub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView4sub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataView4sub.Location = new System.Drawing.Point(0, 144);
            this.dataView4sub.Name = "dataView4sub";
            this.dataView4sub.RowHeadersVisible = false;
            this.dataView4sub.Size = new System.Drawing.Size(763, 215);
            this.dataView4sub.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ФИО Сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата поступления на работу";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ставка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ФИО Начальника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ЗП";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAddUser,
            this.toolStripButton2,
            this.tbUpdate,
            this.btSumZp});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(762, 25);
            this.ToolStrip1.TabIndex = 4;
            this.ToolStrip1.Text = "toolStrip1";
            // 
            // btAddUser
            // 
            this.btAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btAddUser.Image")));
            this.btAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(189, 22);
            this.btAddUser.Text = "Добавить/удалить пользователя";
            this.btAddUser.Click += new System.EventHandler(this.BtAddUser_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(146, 22);
            this.toolStripButton2.Text = "Изменить пароль/логин";
            this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // tbUpdate
            // 
            this.tbUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tbUpdate.Image")));
            this.tbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(113, 22);
            this.tbUpdate.Text = "Обновить таблицу";
            this.tbUpdate.Click += new System.EventHandler(this.TbUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Подчиненные:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLiteCSharp.Properties.Resources.qwe222;
            this.pictureBox1.Location = new System.Drawing.Point(0, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btSumZp
            // 
            this.btSumZp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btSumZp.Image = ((System.Drawing.Image)(resources.GetObject("btSumZp.Image")));
            this.btSumZp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSumZp.Name = "btSumZp";
            this.btSumZp.Size = new System.Drawing.Size(163, 22);
            this.btSumZp.Text = "Сумма зп всех сотрудников";
            this.btSumZp.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(762, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.dataView4sub);
            this.Controls.Add(this.dataView4user);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "SQLiteCSharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView4user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView4sub)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView4user;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_Сотрудника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_поступления_на_работу;
        private System.Windows.Forms.DataGridViewTextBoxColumn Группа;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ставка;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО_Начальника;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЗП;
        private System.Windows.Forms.DataGridView dataView4sub;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton btAddUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tbUpdate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton btSumZp;
    }
}


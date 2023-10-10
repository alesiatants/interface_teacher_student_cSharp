
namespace Class_Student_Teacher
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxliststudents = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.soapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelcorse = new System.Windows.Forms.Label();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labeldescription = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.textBoxtitle = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonaddtolist = new System.Windows.Forms.Button();
            this.buttonoutlist = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonclearlist = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ЗаголовокColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ОписаниеColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ДатаСдачиColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.courseWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxliststudents
            // 
            this.comboBoxliststudents.BackColor = System.Drawing.Color.Azure;
            this.comboBoxliststudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxliststudents.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxliststudents.FormattingEnabled = true;
            this.comboBoxliststudents.Location = new System.Drawing.Point(138, 5);
            this.comboBoxliststudents.Name = "comboBoxliststudents";
            this.comboBoxliststudents.Size = new System.Drawing.Size(256, 31);
            this.comboBoxliststudents.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1336, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатьДанныеToolStripMenuItem,
            this.прочитатьДанныеToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(88, 30);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // записатьДанныеToolStripMenuItem
            // 
            this.записатьДанныеToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.записатьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonToolStripMenuItem,
            this.xmlToolStripMenuItem,
            this.soapToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.записатьДанныеToolStripMenuItem.Name = "записатьДанныеToolStripMenuItem";
            this.записатьДанныеToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.записатьДанныеToolStripMenuItem.Text = "Записать данные";
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
            this.jsonToolStripMenuItem.Text = "json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.jsonToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
            this.xmlToolStripMenuItem.Text = "xml";
            this.xmlToolStripMenuItem.Click += new System.EventHandler(this.xmlToolStripMenuItem_Click);
            // 
            // soapToolStripMenuItem
            // 
            this.soapToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.soapToolStripMenuItem.Name = "soapToolStripMenuItem";
            this.soapToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
            this.soapToolStripMenuItem.Text = "soap";
            this.soapToolStripMenuItem.Click += new System.EventHandler(this.soapToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(165, 34);
            this.excelToolStripMenuItem.Text = "excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // прочитатьДанныеToolStripMenuItem
            // 
            this.прочитатьДанныеToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.прочитатьДанныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonToolStripMenuItem1,
            this.xmlToolStripMenuItem1,
            this.soapToolStripMenuItem1,
            this.excelToolStripMenuItem1});
            this.прочитатьДанныеToolStripMenuItem.Name = "прочитатьДанныеToolStripMenuItem";
            this.прочитатьДанныеToolStripMenuItem.Size = new System.Drawing.Size(318, 34);
            this.прочитатьДанныеToolStripMenuItem.Text = "Прочитать данные";
            // 
            // jsonToolStripMenuItem1
            // 
            this.jsonToolStripMenuItem1.BackColor = System.Drawing.Color.Azure;
            this.jsonToolStripMenuItem1.Name = "jsonToolStripMenuItem1";
            this.jsonToolStripMenuItem1.Size = new System.Drawing.Size(165, 34);
            this.jsonToolStripMenuItem1.Text = "json";
            this.jsonToolStripMenuItem1.Click += new System.EventHandler(this.jsonToolStripMenuItem1_Click);
            // 
            // xmlToolStripMenuItem1
            // 
            this.xmlToolStripMenuItem1.BackColor = System.Drawing.Color.Azure;
            this.xmlToolStripMenuItem1.Name = "xmlToolStripMenuItem1";
            this.xmlToolStripMenuItem1.Size = new System.Drawing.Size(165, 34);
            this.xmlToolStripMenuItem1.Text = "xml";
            this.xmlToolStripMenuItem1.Click += new System.EventHandler(this.xmlToolStripMenuItem1_Click);
            // 
            // soapToolStripMenuItem1
            // 
            this.soapToolStripMenuItem1.BackColor = System.Drawing.Color.Azure;
            this.soapToolStripMenuItem1.Name = "soapToolStripMenuItem1";
            this.soapToolStripMenuItem1.Size = new System.Drawing.Size(165, 34);
            this.soapToolStripMenuItem1.Text = "soap";
            this.soapToolStripMenuItem1.Click += new System.EventHandler(this.soapToolStripMenuItem1_Click);
            // 
            // excelToolStripMenuItem1
            // 
            this.excelToolStripMenuItem1.BackColor = System.Drawing.Color.Azure;
            this.excelToolStripMenuItem1.Name = "excelToolStripMenuItem1";
            this.excelToolStripMenuItem1.Size = new System.Drawing.Size(165, 34);
            this.excelToolStripMenuItem1.Text = "excel";
            this.excelToolStripMenuItem1.Click += new System.EventHandler(this.excelToolStripMenuItem1_Click);
            // 
            // labelcorse
            // 
            this.labelcorse.AutoSize = true;
            this.labelcorse.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcorse.Location = new System.Drawing.Point(12, 47);
            this.labelcorse.Name = "labelcorse";
            this.labelcorse.Size = new System.Drawing.Size(269, 24);
            this.labelcorse.TabIndex = 3;
            this.labelcorse.Text = "Ввод даных о курсовой";
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltitle.Location = new System.Drawing.Point(63, 95);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(60, 23);
            this.labeltitle.TabIndex = 4;
            this.labeltitle.Text = "Тема";
            // 
            // labeldescription
            // 
            this.labeldescription.AutoSize = true;
            this.labeldescription.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldescription.Location = new System.Drawing.Point(27, 147);
            this.labeldescription.Name = "labeldescription";
            this.labeldescription.Size = new System.Drawing.Size(111, 23);
            this.labeldescription.TabIndex = 5;
            this.labeldescription.Text = "Описание";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeldate.Location = new System.Drawing.Point(12, 290);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(126, 23);
            this.labeldate.TabIndex = 6;
            this.labeldate.Text = "Дата сдачи";
            // 
            // textBoxtitle
            // 
            this.textBoxtitle.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxtitle.Location = new System.Drawing.Point(144, 92);
            this.textBoxtitle.Name = "textBoxtitle";
            this.textBoxtitle.Size = new System.Drawing.Size(250, 31);
            this.textBoxtitle.TabIndex = 7;
            this.textBoxtitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxtitle_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(144, 147);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 85);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 290);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 31);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ЗаголовокColumn,
            this.ОписаниеColumn,
            this.ДатаСдачиColumn});
            this.dataGridView1.DataSource = this.courseWorkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(460, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(828, 289);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // buttonaddtolist
            // 
            this.buttonaddtolist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonaddtolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddtolist.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonaddtolist.Location = new System.Drawing.Point(16, 375);
            this.buttonaddtolist.Name = "buttonaddtolist";
            this.buttonaddtolist.Size = new System.Drawing.Size(181, 108);
            this.buttonaddtolist.TabIndex = 11;
            this.buttonaddtolist.Text = "Добавить курсовую в список";
            this.buttonaddtolist.UseVisualStyleBackColor = true;
            this.buttonaddtolist.Click += new System.EventHandler(this.buttonaddtolist_Click);
            // 
            // buttonoutlist
            // 
            this.buttonoutlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonoutlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonoutlist.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonoutlist.Location = new System.Drawing.Point(217, 375);
            this.buttonoutlist.Name = "buttonoutlist";
            this.buttonoutlist.Size = new System.Drawing.Size(158, 108);
            this.buttonoutlist.TabIndex = 12;
            this.buttonoutlist.Text = "Вывести список в табицу";
            this.buttonoutlist.UseVisualStyleBackColor = true;
            this.buttonoutlist.Click += new System.EventHandler(this.buttonoutlist_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclear.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonclear.Location = new System.Drawing.Point(395, 375);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(184, 108);
            this.buttonclear.TabIndex = 13;
            this.buttonclear.Text = "Очистить поля";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonclearlist
            // 
            this.buttonclearlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonclearlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclearlist.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonclearlist.Location = new System.Drawing.Point(609, 375);
            this.buttonclearlist.Name = "buttonclearlist";
            this.buttonclearlist.Size = new System.Drawing.Size(183, 108);
            this.buttonclearlist.TabIndex = 14;
            this.buttonclearlist.Text = "Очистить список";
            this.buttonclearlist.UseVisualStyleBackColor = true;
            this.buttonclearlist.Click += new System.EventHandler(this.buttonclearlist_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonexit.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonexit.Location = new System.Drawing.Point(1170, 366);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(155, 117);
            this.buttonexit.TabIndex = 15;
            this.buttonexit.Text = "Выйти";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(823, 389);
            this.progressBar1.Maximum = 2;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(323, 40);
            this.progressBar1.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1336, 31);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 24);
            this.toolStripStatusLabel1.Text = "ShowAll";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 24);
            this.toolStripStatusLabel2.Visible = false;
            // 
            // ЗаголовокColumn
            // 
            this.ЗаголовокColumn.DataPropertyName = "Заголовок";
            this.ЗаголовокColumn.FilteringEnabled = false;
            this.ЗаголовокColumn.HeaderText = "Заголовок";
            this.ЗаголовокColumn.MinimumWidth = 8;
            this.ЗаголовокColumn.Name = "ЗаголовокColumn";
            this.ЗаголовокColumn.ReadOnly = true;
            this.ЗаголовокColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ОписаниеColumn
            // 
            this.ОписаниеColumn.DataPropertyName = "Описание";
            this.ОписаниеColumn.FilteringEnabled = false;
            this.ОписаниеColumn.HeaderText = "Описание";
            this.ОписаниеColumn.MinimumWidth = 8;
            this.ОписаниеColumn.Name = "ОписаниеColumn";
            this.ОписаниеColumn.ReadOnly = true;
            this.ОписаниеColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ДатаСдачиColumn
            // 
            this.ДатаСдачиColumn.DataPropertyName = "ДатаСдачи";
            this.ДатаСдачиColumn.FilteringEnabled = false;
            this.ДатаСдачиColumn.HeaderText = "ДатаСдачи";
            this.ДатаСдачиColumn.MinimumWidth = 8;
            this.ДатаСдачиColumn.Name = "ДатаСдачиColumn";
            this.ДатаСдачиColumn.ReadOnly = true;
            this.ДатаСдачиColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // courseWorkBindingSource
            // 
            this.courseWorkBindingSource.DataSource = typeof(Class_Student_Teacher.CourseWork);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1336, 585);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonclearlist);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonoutlist);
            this.Controls.Add(this.buttonaddtolist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxtitle);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labeldescription);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.labelcorse);
            this.Controls.Add(this.comboBoxliststudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Заполнение данных о курсовых";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseWorkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxliststudents;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem soapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem1;
        private System.Windows.Forms.Label labelcorse;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labeldescription;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.TextBox textBoxtitle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonaddtolist;
        private System.Windows.Forms.Button buttonoutlist;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonclearlist;
        private System.Windows.Forms.Button buttonexit;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ЗаголовокColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ОписаниеColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ДатаСдачиColumn;
        private System.Windows.Forms.BindingSource courseWorkBindingSource;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

namespace Class_Student_Teacher
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
            this.components = new System.ComponentModel.Container();
            this.labeltitle = new System.Windows.Forms.Label();
            this.labelidentificator = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelNumofseat = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.comboBoxKey = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddtoTeacherList = new System.Windows.Forms.Button();
            this.buttonOutputListTeacher = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.statusStripShowAll = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonaddphoto = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonShowinfo = new System.Windows.Forms.Button();
            this.ФИОColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ДРColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ПочтаColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.СтранаColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ГородColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.СпециализацияColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.ЗарплатаColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.КоличествоСтудентовColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStripShowAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeltitle.Location = new System.Drawing.Point(12, 45);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(260, 25);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "Ввод данных о учителях";
            // 
            // labelidentificator
            // 
            this.labelidentificator.AutoSize = true;
            this.labelidentificator.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelidentificator.Location = new System.Drawing.Point(94, 112);
            this.labelidentificator.Name = "labelidentificator";
            this.labelidentificator.Size = new System.Drawing.Size(58, 23);
            this.labelidentificator.TabIndex = 1;
            this.labelidentificator.Text = "ФИО";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(186, 112);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(263, 31);
            this.textBoxSurname.TabIndex = 2;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            this.textBoxSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSurname_KeyDown);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(13, 162);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(168, 23);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(84, 223);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 23);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Почта";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(186, 217);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(263, 31);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxEmail_KeyDown);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry.Location = new System.Drawing.Point(78, 290);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(86, 23);
            this.labelCountry.TabIndex = 8;
            this.labelCountry.Text = "Страна";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountry.Location = new System.Drawing.Point(186, 282);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(263, 31);
            this.textBoxCountry.TabIndex = 9;
            this.textBoxCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCountry_KeyDown);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(89, 356);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(68, 23);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "Город";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(186, 348);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(263, 31);
            this.textBoxCity.TabIndex = 11;
            this.textBoxCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCity_KeyDown);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSalary.Location = new System.Drawing.Point(58, 421);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(106, 23);
            this.labelSalary.TabIndex = 12;
            this.labelSalary.Text = "Зарплата";
            // 
            // labelNumofseat
            // 
            this.labelNumofseat.AutoSize = true;
            this.labelNumofseat.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumofseat.Location = new System.Drawing.Point(8, 469);
            this.labelNumofseat.Name = "labelNumofseat";
            this.labelNumofseat.Size = new System.Drawing.Size(166, 69);
            this.labelNumofseat.TabIndex = 14;
            this.labelNumofseat.Text = "Максимальное \r\n      количество \r\n       студентов";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.Location = new System.Drawing.Point(8, 557);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(200, 46);
            this.labelKey.TabIndex = 16;
            this.labelKey.Text = "            Область      \r\nспециализации";
            // 
            // comboBoxKey
            // 
            this.comboBoxKey.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxKey.FormattingEnabled = true;
            this.comboBoxKey.Location = new System.Drawing.Point(186, 557);
            this.comboBoxKey.Name = "comboBoxKey";
            this.comboBoxKey.Size = new System.Drawing.Size(263, 31);
            this.comboBoxKey.TabIndex = 17;
            this.comboBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxKey_KeyDown);
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
            this.ФИОColumn,
            this.ДРColumn,
            this.ПочтаColumn,
            this.СтранаColumn,
            this.ГородColumn,
            this.СпециализацияColumn,
            this.ЗарплатаColumn,
            this.КоличествоСтудентовColumn});
            this.dataGridView1.DataSource = this.teacherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(518, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1348, 574);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // buttonAddtoTeacherList
            // 
            this.buttonAddtoTeacherList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonAddtoTeacherList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddtoTeacherList.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddtoTeacherList.Location = new System.Drawing.Point(17, 846);
            this.buttonAddtoTeacherList.Name = "buttonAddtoTeacherList";
            this.buttonAddtoTeacherList.Size = new System.Drawing.Size(164, 113);
            this.buttonAddtoTeacherList.TabIndex = 19;
            this.buttonAddtoTeacherList.Text = "Добавить в список учителей";
            this.buttonAddtoTeacherList.UseVisualStyleBackColor = true;
            this.buttonAddtoTeacherList.Click += new System.EventHandler(this.buttonAddtoTeacherList_Click);
            // 
            // buttonOutputListTeacher
            // 
            this.buttonOutputListTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonOutputListTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutputListTeacher.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOutputListTeacher.Location = new System.Drawing.Point(201, 846);
            this.buttonOutputListTeacher.Name = "buttonOutputListTeacher";
            this.buttonOutputListTeacher.Size = new System.Drawing.Size(230, 113);
            this.buttonOutputListTeacher.TabIndex = 20;
            this.buttonOutputListTeacher.Text = "Вывести список учителей в таблицу";
            this.buttonOutputListTeacher.UseVisualStyleBackColor = true;
            this.buttonOutputListTeacher.Click += new System.EventHandler(this.buttonOutputListTeacher_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(440, 846);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(160, 113);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1732, 34);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.записатьДанныеToolStripMenuItem,
            this.прочитатьДанныеToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
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
            this.записатьДанныеToolStripMenuItem.Text = "Записать данные ";
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
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(1715, 846);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(151, 113);
            this.buttonExit.TabIndex = 23;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStudent.Location = new System.Drawing.Point(810, 846);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(217, 113);
            this.buttonAddStudent.TabIndex = 24;
            this.buttonAddStudent.Text = "Добавить студентов в список учителей";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonClearList
            // 
            this.buttonClearList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearList.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearList.Location = new System.Drawing.Point(616, 846);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(172, 113);
            this.buttonClearList.TabIndex = 25;
            this.buttonClearList.Text = "Очистить список учителей";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // statusStripShowAll
            // 
            this.statusStripShowAll.BackColor = System.Drawing.Color.MediumAquamarine;
            this.statusStripShowAll.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStripShowAll.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripShowAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ShowAll});
            this.statusStripShowAll.Location = new System.Drawing.Point(0, 1019);
            this.statusStripShowAll.Name = "statusStripShowAll";
            this.statusStripShowAll.Size = new System.Drawing.Size(1732, 31);
            this.statusStripShowAll.TabIndex = 26;
            this.statusStripShowAll.Text = "statusStrip1";
            this.statusStripShowAll.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStripShowAll_ItemClicked);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 24);
            this.StatusLabel.Visible = false;
            // 
            // ShowAll
            // 
            this.ShowAll.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAll.IsLink = true;
            this.ShowAll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(93, 24);
            this.ShowAll.Text = "ShowAll";
            this.ShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1044, 894);
            this.progressBar1.Maximum = 7;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 34);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 594);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // buttonaddphoto
            // 
            this.buttonaddphoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonaddphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddphoto.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonaddphoto.Location = new System.Drawing.Point(12, 688);
            this.buttonaddphoto.Name = "buttonaddphoto";
            this.buttonaddphoto.Size = new System.Drawing.Size(152, 95);
            this.buttonaddphoto.TabIndex = 29;
            this.buttonaddphoto.Text = "Добавить фото";
            this.buttonaddphoto.UseVisualStyleBackColor = true;
            this.buttonaddphoto.Click += new System.EventHandler(this.buttonaddphoto_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(186, 488);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(263, 31);
            this.numericUpDown1.TabIndex = 30;
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyDown);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(186, 413);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(263, 31);
            this.maskedTextBox1.TabIndex = 31;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // buttonShowinfo
            // 
            this.buttonShowinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.buttonShowinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowinfo.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowinfo.Location = new System.Drawing.Point(1521, 846);
            this.buttonShowinfo.Name = "buttonShowinfo";
            this.buttonShowinfo.Size = new System.Drawing.Size(179, 113);
            this.buttonShowinfo.TabIndex = 32;
            this.buttonShowinfo.Text = "Вывести информацию о учителях";
            this.buttonShowinfo.UseVisualStyleBackColor = true;
            this.buttonShowinfo.Click += new System.EventHandler(this.buttonShowinfo_Click);
            // 
            // ФИОColumn
            // 
            this.ФИОColumn.DataPropertyName = "ФИО";
            this.ФИОColumn.FillWeight = 49.07612F;
            this.ФИОColumn.FilteringEnabled = false;
            this.ФИОColumn.HeaderText = "ФИО";
            this.ФИОColumn.MinimumWidth = 8;
            this.ФИОColumn.Name = "ФИОColumn";
            this.ФИОColumn.ReadOnly = true;
            this.ФИОColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ДРColumn
            // 
            this.ДРColumn.DataPropertyName = "ДатаРождения";
            this.ДРColumn.FillWeight = 106.2751F;
            this.ДРColumn.FilteringEnabled = false;
            this.ДРColumn.HeaderText = "ДатаРождения";
            this.ДРColumn.MinimumWidth = 8;
            this.ДРColumn.Name = "ДРColumn";
            this.ДРColumn.ReadOnly = true;
            this.ДРColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ПочтаColumn
            // 
            this.ПочтаColumn.DataPropertyName = "Почта";
            this.ПочтаColumn.FillWeight = 63.85686F;
            this.ПочтаColumn.FilteringEnabled = false;
            this.ПочтаColumn.HeaderText = "Почта";
            this.ПочтаColumn.MinimumWidth = 8;
            this.ПочтаColumn.Name = "ПочтаColumn";
            this.ПочтаColumn.ReadOnly = true;
            this.ПочтаColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // СтранаColumn
            // 
            this.СтранаColumn.DataPropertyName = "Страна";
            this.СтранаColumn.FillWeight = 75.19688F;
            this.СтранаColumn.FilteringEnabled = false;
            this.СтранаColumn.HeaderText = "Страна";
            this.СтранаColumn.MinimumWidth = 8;
            this.СтранаColumn.Name = "СтранаColumn";
            this.СтранаColumn.ReadOnly = true;
            this.СтранаColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ГородColumn
            // 
            this.ГородColumn.DataPropertyName = "Город";
            this.ГородColumn.FillWeight = 73.051F;
            this.ГородColumn.FilteringEnabled = false;
            this.ГородColumn.HeaderText = "Город";
            this.ГородColumn.MinimumWidth = 8;
            this.ГородColumn.Name = "ГородColumn";
            this.ГородColumn.ReadOnly = true;
            this.ГородColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // СпециализацияColumn
            // 
            this.СпециализацияColumn.DataPropertyName = "Специализация";
            this.СпециализацияColumn.FillWeight = 138.601F;
            this.СпециализацияColumn.FilteringEnabled = false;
            this.СпециализацияColumn.HeaderText = "Специализация";
            this.СпециализацияColumn.MinimumWidth = 8;
            this.СпециализацияColumn.Name = "СпециализацияColumn";
            this.СпециализацияColumn.ReadOnly = true;
            this.СпециализацияColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ЗарплатаColumn
            // 
            this.ЗарплатаColumn.DataPropertyName = "Зарплата";
            this.ЗарплатаColumn.FillWeight = 101.733F;
            this.ЗарплатаColumn.FilteringEnabled = false;
            this.ЗарплатаColumn.HeaderText = "Зарплата";
            this.ЗарплатаColumn.MinimumWidth = 8;
            this.ЗарплатаColumn.Name = "ЗарплатаColumn";
            this.ЗарплатаColumn.ReadOnly = true;
            this.ЗарплатаColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // КоличествоСтудентовColumn
            // 
            this.КоличествоСтудентовColumn.DataPropertyName = "КоличествоСтудентов";
            this.КоличествоСтудентовColumn.FillWeight = 192.21F;
            this.КоличествоСтудентовColumn.FilteringEnabled = false;
            this.КоличествоСтудентовColumn.HeaderText = "КоличествоСтудентов";
            this.КоличествоСтудентовColumn.MinimumWidth = 8;
            this.КоличествоСтудентовColumn.Name = "КоличествоСтудентовColumn";
            this.КоличествоСтудентовColumn.ReadOnly = true;
            this.КоличествоСтудентовColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataSource = typeof(Class_Student_Teacher.Teacher);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1732, 1050);
            this.Controls.Add(this.buttonShowinfo);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonaddphoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStripShowAll);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOutputListTeacher);
            this.Controls.Add(this.buttonAddtoTeacherList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelNumofseat);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelidentificator);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Заполнение данных о учителях";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripShowAll.ResumeLayout(false);
            this.statusStripShowAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label labelidentificator;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelNumofseat;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.ComboBox comboBoxKey;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddtoTeacherList;
        private System.Windows.Forms.Button buttonOutputListTeacher;
        private System.Windows.Forms.Button buttonClear;
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
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonClearList;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ФИОColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ДРColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ПочтаColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn СтранаColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ГородColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn СпециализацияColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn ЗарплатаColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn КоличествоСтудентовColumn;
        private System.Windows.Forms.StatusStrip statusStripShowAll;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ShowAll;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonaddphoto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonShowinfo;
    }
}


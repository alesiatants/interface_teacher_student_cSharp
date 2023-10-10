using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoreLinq;
using DataGridViewAutoFilter;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;

namespace Class_Student_Teacher
{
    public partial class Form2 : Form
    {
        int d = 0, m = 0, l = 0, x = 0, r = 0, c=0;
        ListTeachers listteachers = new ListTeachers();
        List<String> listnames = new List<String>();
        List<Student> liststud = new List<Student>();
        String[] group = new String[] { "241", "231", "261", "341", "331", "361", "441", "431", "461", "241-М", "231-М", "261-М" };
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ListTeachers listteach)
        {
            InitializeComponent();
            listteachers = listteach;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.comboBoxgroup.Items.AddRange(group);
            string[] key = (string[])Enum.GetNames(typeof(Key));
            comboBoxkey.Items.AddRange(key);
            string currentname = (string)comboBoxlistteacher.SelectedItem;
            //listteachers.findName(currentname).Liststudent = new List<Student>();
            studentBindingSource.DataSource = listteachers.findName(currentname).Liststudent.ToDataTable();
            dataGridView1.DataSource = studentBindingSource;
            EnableGridFilter(true);
            for (int i = 0; i < listteachers.ListTeacher.Count; i++)
            {
                listnames.Add(listteachers.ListTeacher[i].ФИО);
            }
            if (listnames.Count == 0) comboBoxlistteacher.Text = "Список преподавателей пуст!";
            else comboBoxlistteacher.Text = "Выберите преподавателя";
            //if (listnames.Count != 0) comboBox1.Text = "Выберите преподавателя ";

            for (int i = 0; i < listteachers.ListTeacher.Count; i++)
            {
                if (!comboBoxlistteacher.Items.Contains(listteachers.ListTeacher[i].ФИО)) comboBoxlistteacher.Items.AddRange(listnames.ToArray());
            }
            buildfunct();
            comboBoxlistteacher.SelectedIndexChanged += new System.EventHandler(comboBoxlistteacher_SelectedIndexChanged);
            buildtree();
        }
        private void buildfunct()
        {
            this.chart1.Series["Число Студентов"].Points.Clear();
            this.chart1.Series["Число Студентов"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            //this.chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

            int number = 0;
            ListTeachers listteach = listteachers;
            for (int i = 0; i < listteach.ListTeacher.Count; i++)
            {
                //this.chart1.Series["Series1"].Points.AddXY(listteach.ListTeacher[i].Name, listteach.ListTeacher[i].ListStudent.Count);
                if (listteach.ListTeacher[i].Liststudent != null)
                {
                    number = listteach.ListTeacher[i].Liststudent.Count;
                }
                else
                {
                    listteach.ListTeacher[i].Liststudent = new List<Student>();
                    number = listteach.ListTeacher[i].Liststudent.Count;
                }
                this.chart1.Series["Число Студентов"].Points.AddXY(listteach.ListTeacher[i].ФИО, number);
            }



        }
        public bool isselectedtextbox(ComboBox one)
        {
            if (one.SelectedIndex > -1) return true;
            else return false;
        }
        private bool checklist(Teacher t, Student h)
        {
            if (t.Liststudent.Exists(x => (x.ФИО == h.ФИО))) return true;
            else return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public bool IsNotEmpty(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;
            else return true;
        }
        public bool IsValidEmail(string email)
        {
            IsNotEmpty(email);
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                string inicial, email, group, photo, message = "Список уже содержит учителей под именем";
                bool form;
                Address address;
                Key key;
                DateTime date;
                string currentname = (string)comboBoxlistteacher.SelectedItem;
                try
                {
                    inicial = textBoxinizial.Text;
                    date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                    email = textBoxemail.Text;
                    address = new Address(textBoxcountry.Text, textBoxcity.Text);
                    
                    if (IsNotEmpty(inicial) && IsNotEmpty(dateTimePicker1.Value.ToString()) && IsNotEmpty(email) && IsNotEmpty(textBoxcountry.Text) && IsNotEmpty(textBoxcity.Text) && isselectedtextbox(comboBoxgroup) && isselectedtextbox(comboBoxkey) && pictureBox1.Image != null)
                    {

                        photo = ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                        group = comboBoxgroup.SelectedItem.ToString();
                        form = checkBoxform.Checked;
                        key = (Key)Enum.Parse(typeof(Key), comboBoxkey.SelectedItem.ToString(), true);
                        if (IsValidEmail(email) == false)
                        {
                            MessageBox.Show("Неверная почта", "Ошибка - некорректная почта");
                            textBoxemail.BackColor = Color.Red;
                        }
                        else
                        {

                            textBoxemail.BackColor = Color.White;

                            Student student = new Student(inicial, date, email, address, key,photo, group, form);


                            //listteachers.findName(currentname).ListStudent.Add(st);
                            foreach (Teacher t in listteachers.ListTeacher)
                            {
                                if (t.ФИО == currentname)
                                {
                                    if (checklist(t, student)) message += " ";
                                    else
                                    {
                                        t.add(student);
                                        //liststud = t.Liststudent;
                                        message = "Студенты успешно записаны";
                                        studentBindingSource.DataSource = t.Liststudent.ToDataTable();
                                        dataGridView1.DataSource = studentBindingSource;
                                        EnableGridFilter(true);
                                        clearbox();
                                    }

                                }
                            }


                        }
                        /*studentBindingSource.DataSource = liststud.ToDataTable();
                        dataGridView1.DataSource = studentBindingSource;*/
                    }


                    else
                    {
                        MessageBox.Show("Вы не везде заполнили поля", "Ошибка - неверный ввод");
                    }
                    /*studentBindingSource.DataSource = liststud.ToDataTable();
                    dataGridView1.DataSource = studentBindingSource;
                    EnableGridFilter(true);*/



                }
                catch
                {
                    MessageBox.Show("Вы ввели данные неверного типа либо вообще не ввели", "Ошибка - неверный ввод");
                }
            }
            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
            buildfunct();
            buildtree();
        }

        private void buttonoutputstudent_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                string currentname = (string)comboBoxlistteacher.SelectedItem;
                foreach (Teacher t in listteachers.ListTeacher)
                {
                    if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                    {
                        studentBindingSource.DataSource = t.Liststudent.ToDataTable();
                        dataGridView1.DataSource = studentBindingSource;
                        EnableGridFilter(true);
                        
                    }
                }
                
                /*if (liststud == null)
                {
                    liststud = new List<Student>();
                }
                studentBindingSource.DataSource = liststud.ToDataTable();
                dataGridView1.DataSource = studentBindingSource;
                EnableGridFilter(true);*/
            }
            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
        }

        private void comboBoxlistteacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }
        private void clearbox()
        {
            textBoxinizial.Clear();
            textBoxemail.Clear();
            textBoxcountry.Clear();
            textBoxcity.Clear();
            comboBoxgroup.Text = "";
            comboBoxkey.Text = "";
            checkBoxform.Checked = false;
            pictureBox1.Image = null;
            d = 0;
            r = 0; 
            l = 0;
            m = 0;
            x = 0;
            c = 0;
            progressBar1.Value = 0;

        }
        private void buttonclear_Click(object sender, EventArgs e)
        {
            clearbox();
        }

        private void buttonclearlist_Click(object sender, EventArgs e)
        {
            foreach (Teacher t in listteachers.ListTeacher)
            {
                if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                {
                    t.clear();
                }
            }
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
            buildtree();

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                Teacher teacher = new Teacher();
                string currentname = (string)comboBoxlistteacher.SelectedItem;
                string message = "Список уже содержит студентов под именем";

                foreach (Teacher t in listteachers.ListTeacher)
                {
                    if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                    {
                        foreach (Student st in t.Liststudent)
                        {
                            t.writetojson(st, t.ФИО);
                        }
                    }
                }


            }

            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                Teacher teacher = new Teacher();
                string currentname = (string)comboBoxlistteacher.SelectedItem;
                string name, message = "Список уже содержит студентов под именем";
                int age, group;
                foreach (Teacher t in listteachers.ListTeacher)
                {
                    if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                    {
                        if (File.Exists($"Students_{t.ФИО}'s.json"))
                        {
                            studentBindingSource.DataSource = t.readfromjson(t.ФИО).ToDataTable();
                            dataGridView1.DataSource = studentBindingSource;
                            EnableGridFilter(true);
                            pictureBox1.Image = Base64ToImage(t.readfromjson(t.ФИО)[0].Фото);
                        }
                        else
                        {
                            MessageBox.Show("Файл еще не создан!");
                        }
                    }
                }


            }

            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                string currentname = (string)comboBoxlistteacher.SelectedItem;
                List<Student> reserv = new List<Student>();
                string message;

                foreach (Teacher t in listteachers.ListTeacher)
                {
                    if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                    {
                        foreach (Student st in t.Liststudent)
                        {
                            if (reserv.Count != 0 && reserv.Exists(x => (x.ФИО == st.ФИО))) message = "Nothing";
                            else
                            {
                                reserv.Add(st);
                            }
                        }
                        listteachers.findName(currentname).writetoxml(reserv, currentname);
                    }
                }

            }
            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
        }

        private void xmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {

                try
                {
                    string currentname = (string)comboBoxlistteacher.SelectedItem;
                    studentBindingSource.DataSource = listteachers.findName(currentname).readfromxml(currentname).ToDataTable();
                    dataGridView1.DataSource = studentBindingSource;
                    EnableGridFilter(true);
                }
                catch
                {
                    MessageBox.Show("Файл Teachers.xml еще не создан!", "Ошибка - несозданный файл");
                }
            }
            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
        }

        private void soapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                Teacher teacher = new Teacher();
                string currentname = (string)comboBoxlistteacher.SelectedItem;
                List<Student> reserv = new List<Student>();
                string message = "Список уже содержит студентов под именем";

                foreach (Teacher t in listteachers.ListTeacher)
                {
                    if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                    {
                        foreach (Student st in t.Liststudent)
                        {
                            if (reserv.Count != 0 && reserv.Exists(x => (x.ФИО == st.ФИО))) message = "Nothing";
                            else
                            {
                                reserv.Add(st);
                            }
                        }
                        listteachers.findName(currentname).writetosoap(reserv, currentname);
                    }
                }

            }

            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
        }

        private void soapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                try
                {
                    string currentname = (string)comboBoxlistteacher.SelectedItem;
                    studentBindingSource.DataSource = listteachers.findName(currentname).readfromsoap(currentname).ToDataTable();
                    dataGridView1.DataSource = studentBindingSource;
                    EnableGridFilter(true);
                }
                catch
                {
                    MessageBox.Show("Файл Teachers.soap еще не создан!", "Ошибка - несозданный файл");
                }
            }
            else MessageBox.Show("Не выбран преподаватель!", "Ошибка");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Cells[1, 1] = "ФИО";
            ExcelApp.Cells[1, 2] = "День Рождения";
            ExcelApp.Cells[1, 3] = "Почта";
            ExcelApp.Cells[1, 4] = "Страна";
            ExcelApp.Cells[1, 5] = "Город";
            ExcelApp.Cells[1, 6] = "Группа";
            ExcelApp.Cells[1, 7] = "Очная форма обучения";
            ExcelApp.Cells[1, 8] = "Специализация";
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (i == 7)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].FormattedValue).ToString();
                        ExcelApp.Visible = true;
                    }
                    else
                    {

                        ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                        ExcelApp.Visible = true;
                    }

                }
            }
        }

        private void excelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string file = "";
            System.Data.DataTable dt = new System.Data.DataTable();
            DataRow row;
            OpenFileDialog fs = new OpenFileDialog();
            fs.Filter = "Excel files(*.xlsx)|*.xlsx";
            DialogResult result = fs.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = fs.FileName;
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook excelWorkbook = ExcelApp.Workbooks.Open(file);
                Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;
                int colCount = excelRange.Columns.Count;
                int rowCount = excelRange.Rows.Count;
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        dt.Columns.Add(excelRange.Cells[i, j].Value);
                    }
                    break;
                }
                int rowCounter;
                for (int i = 2; i <= rowCount; i++)
                {
                    row = dt.NewRow();
                    rowCounter = 0;
                    for (int j = 1; j <= colCount; j++)
                    {
                        if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value != null)
                        {
                            row[rowCounter] = excelRange.Cells[i, j].Value;
                        }
                        else
                        {
                            row[rowCounter] = excelRange.Cells[i, j].Value;
                        }
                        rowCounter++;
                    }
                    dt.Rows.Add(row);

                }
                studentBindingSource.DataSource = dt;
                dataGridView1.DataSource = studentBindingSource;
                EnableGridFilter(true);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                excelWorkbook.Close();
                ExcelApp.Quit();
            }
        }

        private void buttonaddcoursework_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher)) {
                foreach (Teacher t in listteachers.ListTeacher)
                {
                    if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                    {
                        Form3 newForm = new Form3(t.Liststudent, treeView1, listteachers.ListTeacher);
                        newForm.ShowDialog();
                        /*treeView1.Nodes.Clear();
                        int c = 0;
                        foreach (Teacher teacher in listteachers.ListTeacher)
                        {
                            treeView1.Nodes.Add(teacher.ФИО);
                            if (teacher.Liststudent != null)
                            {
                                foreach (Student student in teacher.Liststudent)
                                {
                                    treeView1.Nodes[c].Nodes.Add(student.ФИО);
                                    if (student.Курсовая != null)
                                    {
                                        foreach (CourseWork work in student.Курсовая)
                                        {
                                            treeView1.Nodes[c].Nodes[c].Nodes.Add(work.Заголовок);
                                        }
                                    }
                                    //treeView1.Nodes[c].Nodes[0].Nodes.Add(student.CourseWork.Title);
                                }
                            }
                            c++;
                        }
                        treeView1.EndUpdate();*/
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран преподаватель!", "Ошибка");
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }
        private void EnableGridFilter(bool value)
        {
            ФИОColumn.FilteringEnabled = value;
            ДатаРожденияColumn.FilteringEnabled = value;
            ПочтаColumn.FilteringEnabled = value;
            СтранаColumn.FilteringEnabled = value;
            ГородColumn.FilteringEnabled = value;
            СпециализацияColumn.FilteringEnabled = value;
            ГруппаColumn.FilteringEnabled = value;
            ФормаОбученияColumn.FilteringEnabled = value;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dataGridView1);
            if (string.IsNullOrEmpty(filterStatus))
            {
                ShowAll.Visible = false;
                StatusLabel.Visible = false;
            }
            else
            {
                ShowAll.Visible = true;
                StatusLabel.Visible = true;
                StatusLabel.Text = filterStatus;
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up) && dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level == 2)
            {
                int c = 0;
                string title = treeView1.SelectedNode.Text;
                foreach (Teacher teacher in listteachers.ListTeacher)
                {
                    if (teacher.Liststudent != null)
                    {
                        foreach (Student student in teacher.Liststudent)
                        {
                            if (student.Курсовая != null)
                            {
                                foreach (CourseWork work in student.Курсовая)
                                {
                                    if (work.Заголовок == treeView1.SelectedNode.Text)
                                    {
                                        Form4 newForm = new Form4(work, student.Почта, student.ФИО);
                                        newForm.ShowDialog();
                                    }
                                }
                            }
                            //treeView1.Nodes[c].Nodes[0].Nodes.Add(student.CourseWork.Title);
                        }
                    }
                    c++;
                }
            }
        }
        private void textBoxinizial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBoxinizial.Text != "" && c == 0)

                    this.progressBar1.Value += 1;
                c = 1;

                if (textBoxinizial.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        c = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле имени!");

                }
                if (textBoxinizial.Text != "" && c != 0)
                {

                }
            }
        }
        private void textBoxemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxemail.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        d = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле почты");
                }
                else
                {

                    if (IsValidEmail(textBoxemail.Text))
                    {
                        if (d == 0)
                        {
                            textBoxemail.BackColor = Color.White;
                            this.progressBar1.Value += 1;
                            d = 1;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверная почта!");
                        textBoxemail.BackColor = Color.Red;

                    }
                }
            }
        }

        private void buttonaddphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.ShowDialog();

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void buttonshowinfo_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxlistteacher))
            {
                foreach (Teacher t in listteachers.ListTeacher)
                {
                    if (t.ФИО == comboBoxlistteacher.SelectedItem.ToString())
                    {
                        if (t.Liststudent.Count == 0)
                        {
                            MessageBox.Show("Список студентов пуст!");
                        }
                        else
                        {
                            Form6 newForm = new Form6(t.Liststudent);
                            newForm.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Не выбран учитель!", "Ошибка");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxcountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (IsNotEmpty(textBoxcountry.Text) && m == 0)
                {
                    this.progressBar1.Value += 1;
                    m = 1;
                }
                if (textBoxcountry.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        m = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле страна!");

                }
                if (textBoxcountry.Text != "" && m != 0)
                {

                }
            }
        }
       
        private void textBoxcity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (IsNotEmpty(textBoxcity.Text) && l == 0)
                {
                    this.progressBar1.Value += 1;
                    l = 1;
                }
                if (textBoxcity.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        l = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле город!");

                }
                if (textBoxcity.Text != "" && l != 0)
                {

                }
            }
        }
        private void comboBoxgroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isselectedtextbox(comboBoxgroup))
                {

                    if (x == 0)
                    {
                        this.progressBar1.Value += 1;
                        x = 1;
                    }
                }
                else
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        x = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле группа");
                }
            }
        }
        private void comboBoxkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isselectedtextbox(comboBoxkey))
                {

                    if (r == 0)
                    {
                        this.progressBar1.Value += 1;
                        comboBoxlistteacher.Items.Clear();
                        for (int i = 0; i < listteachers.ListTeacher.Count; i++)
                        {
                            if (listteachers.ListTeacher[i].Специализация.ToString() == comboBoxkey.SelectedItem.ToString()) comboBoxlistteacher.Items.Add(listteachers.ListTeacher[i].ФИО);
                        }
                        r = 1;
                    }
                }
                else
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        r = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле специализация");
                }
            }
        }
        public void buildtree()
        {
            treeView1.Nodes.Clear();
            int c = 0;
            int j = 0;
            foreach (Teacher teacher in listteachers.ListTeacher)
            {
                treeView1.Nodes.Add(teacher.ФИО);
                if (teacher.Liststudent != null)
                {
                    foreach (Student student in teacher.Liststudent)
                    {
                        treeView1.Nodes[c].Nodes.Add(student.ФИО);
                        if (student.Курсовая != null)
                        {
                            foreach (CourseWork work in student.Курсовая)
                            {
                                treeView1.Nodes[c].Nodes[j].Nodes.Add(work.Заголовок);
                            }
                        }
                        j++;
                        //treeView1.Nodes[c].Nodes[0].Nodes.Add(student.CourseWork.Title);
                    }
                }
                c++;
            }
            treeView1.EndUpdate();
        }
    }
    
}
    

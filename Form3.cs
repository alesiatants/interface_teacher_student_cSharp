
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
    public partial class Form3 : Form
    {
        List<Student> liststudents = new List<Student>();
        List<String> listnames = new List<String>();
        List<CourseWork> liststud = new List<CourseWork>();
        TreeView tree;
        List<Teacher> t;
        int c = 0, d = 0;
        public Form3(List<Student> list, TreeView view, List<Teacher> _t)
        {
            InitializeComponent();
            liststudents = list;
            tree = view;
            t = _t;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
       
            string currentname = (string)comboBoxliststudents.SelectedItem;
            foreach(Student obj in liststudents)
            {
                if (obj.Курсовая == null)
                {
                    obj.Курсовая = new List<CourseWork>();
                }
                if (obj.ФИО == currentname) {
                    courseWorkBindingSource.DataSource = obj.Курсовая.ToDataTable();
                    dataGridView1.DataSource = courseWorkBindingSource;
                    EnableGridFilter(true);
                }
            }
            
            for (int i = 0; i < liststudents.Count; i++)
            {
                listnames.Add(liststudents[i].ФИО);
            }
            if (listnames.Count == 0) comboBoxliststudents.Text = "Список студентов пуст!";
            else comboBoxliststudents.Text = "Выберите студента";
            //if (listnames.Count != 0) comboBox1.Text = "Выберите преподавателя ";

            for (int i = 0; i < liststudents.Count; i++)
            {
                if (!comboBoxliststudents.Items.Contains(liststudents[i].ФИО)) comboBoxliststudents.Items.AddRange(listnames.ToArray());
            }
            comboBoxliststudents.SelectedIndexChanged += new System.EventHandler(comboBoxliststudents_SelectedIndexChanged);
        }
        private void comboBoxliststudents_SelectedIndexChanged(object sender, EventArgs e)
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
        public bool isselectedtextbox(ComboBox one)
        {
            if (one.SelectedIndex > -1) return true;
            else return false;
        }
        private bool checklist(Student s, CourseWork h)
        {
            bool flag = false;
            foreach (CourseWork work in s.Курсовая)
            {
                
                if (work.Заголовок == h.Заголовок)
                {
                    flag = true;
                }
                else flag = false;
            }
            return flag;
        }
        public bool IsNotEmpty(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;
            else return true;
        }

        private void buttonaddtolist_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {
                string title, description,  message = "Список уже содержи курсовые под названием";
                DateTime date;
                string currentname = (string)comboBoxliststudents.SelectedItem;

                try
                {
                    title = textBoxtitle.Text;
                    date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                    description = textBox1.Text;

                    if (IsNotEmpty(title) && IsNotEmpty(dateTimePicker1.Value.ToString()) && IsNotEmpty(description))
                    {

                            CourseWork work = new CourseWork(title, description, date);


                            //listteachers.findName(currentname).ListStudent.Add(st);
                            foreach (Student t in liststudents)
                            {
                            //t.Курсовая = new List<CourseWork>();
                            if (t.ФИО == currentname)
                                {
                                    if (checklist(t, work)) message += " ";
                                    else
                                    {
                                        t.add(work);
                                        //liststud = t.Курсовая;
                                    courseWorkBindingSource.DataSource = t.Курсовая.ToDataTable();
                                    dataGridView1.DataSource = courseWorkBindingSource;
                                    EnableGridFilter(true);
                                    buildfunc();
                                    clearbox();
                                    message = "Курсовые успешно записаны";
                                    
                                    }

                                }
                            }


                        }
                        /*studentBindingSource.DataSource = liststud.ToDataTable();
                        dataGridView1.DataSource = studentBindingSource;*/
                    


                    else
                    {
                        MessageBox.Show("Вы не везде заполнили поля", "Ошибка - неверный ввод");
                    }
                    /*courseWorkBindingSource.DataSource = liststud.ToDataTable();
                    dataGridView1.DataSource = courseWorkBindingSource;
                    progressBar1.Value = 0;*/



                }
                catch
                {
                    MessageBox.Show("Вы ввели данные неверного типа либо вообще не ввели", "Ошибка - неверный ввод");
                }
            }
            else MessageBox.Show("Не выбран студент!", "Ошибка");
        }

        private void buttonoutlist_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {
                string currentname = (string)comboBoxliststudents.SelectedItem;
                foreach (Student t in liststudents)
                {
                    if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
                    {
                        courseWorkBindingSource.DataSource = t.Курсовая.ToDataTable();
                        dataGridView1.DataSource = courseWorkBindingSource;
                        EnableGridFilter(true);
                    }
                }
               /* if (liststud == null)
                {
                    liststud = new List<CourseWork>();
                }
                courseWorkBindingSource.DataSource = liststud.ToDataTable();
                dataGridView1.DataSource = courseWorkBindingSource;*/
            }
            else MessageBox.Show("Не выбран студент!", "Ошибка");
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            clearbox();
        }
        private void clearbox()
        {
            textBoxtitle.Clear();
            textBox1.Clear();
            c = 0;
            d = 0;
            progressBar1.Value = 0;
        }
        private void buttonclearlist_Click(object sender, EventArgs e)
        {
            foreach (Student t in liststudents)
            {
                if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
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
            buildfunc();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {
                Teacher teacher = new Teacher();
                string currentname = (string)comboBoxliststudents.SelectedItem;
                string message = "Список уже содержит курсовые под названием";

                foreach (Student t in liststudents)
                {
                    if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
                    {
                        foreach (CourseWork st in t.Курсовая)
                        {
                            t.writetojson(st, t.ФИО);
                        }
                    }
                }


            }

            else MessageBox.Show("Не выбран студент!", "Ошибка");
        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {
                Teacher teacher = new Teacher();
                string currentname = (string)comboBoxliststudents.SelectedItem;
                string message = "Список уже содержит курсовые под названием";
                
                foreach (Student t in liststudents)
                {
                    if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
                    {
                        if (File.Exists($"CourseWorks_{t.ФИО}'s.json"))
                        {
                            courseWorkBindingSource.DataSource = t.readfromjson(t.ФИО).ToDataTable();
                            dataGridView1.DataSource = courseWorkBindingSource;
                            EnableGridFilter(true);
                        }
                        else
                        {
                            MessageBox.Show("Файл еще не создан!");
                        }
                    }
                }


            }

            else MessageBox.Show("Не выбран студент!", "Ошибка");
        }
        private void buildfunc()
        {
            tree.Nodes.Clear();
            int c = 0;
            int j = 0;
            foreach (Teacher teacher in t)
            {
                tree.Nodes.Add(teacher.ФИО);
                if (teacher.Liststudent != null)
                {
                    foreach (Student student in teacher.Liststudent)
                    {
                        tree.Nodes[c].Nodes.Add(student.ФИО);
                        if (student.Курсовая != null)
                        {
                            foreach (CourseWork work in student.Курсовая)
                            {
                                tree.Nodes[c].Nodes[j].Nodes.Add(work.Заголовок);
                            }
                        }
                        j++;
                        //treeView1.Nodes[c].Nodes[0].Nodes.Add(student.CourseWork.Title);
                    }
                }
                c++;
            }
            tree.EndUpdate();
        }
        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {
                string currentname = (string)comboBoxliststudents.SelectedItem;
                List<CourseWork> reserv = new List<CourseWork>();
                string message;

                foreach (Student t in liststudents)
                {
                    if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
                    {
                        foreach (CourseWork st in t.Курсовая)
                        {
                            if (reserv.Count != 0 && reserv.Exists(x => (x.Заголовок == st.Заголовок))) message = "Nothing";
                            else
                            {
                                reserv.Add(st);
                            }
                        }
                        t.writetoxml(reserv, currentname);
                    }
                }

            }
            else MessageBox.Show("Не выбран студент!", "Ошибка");
        }

        private void xmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {

                try
                {
                    if (isselectedtextbox(comboBoxliststudents))
                    {
                        Teacher teacher = new Teacher();
                        string currentname = (string)comboBoxliststudents.SelectedItem;
                        string message = "Список уже содержит студентов под именем";

                        foreach (Student t in liststudents)
                        {
                            if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
                            {
                                courseWorkBindingSource.DataSource = t.readfromxml(t.ФИО).ToDataTable();
                                dataGridView1.DataSource = courseWorkBindingSource;
                                EnableGridFilter(true);

                            }
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Файл еще не создан!", "Ошибка - несозданный файл");
                }
            }
            else MessageBox.Show("Не выбран пстудент!", "Ошибка");
        }

        private void soapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {
                Teacher teacher = new Teacher();
                string currentname = (string)comboBoxliststudents.SelectedItem;
                List<CourseWork> reserv = new List<CourseWork>();
                string message = "Список уже содержит курсовые под названием";

                foreach (Student t in liststudents)
                {
                    if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
                    {
                        foreach (CourseWork st in t.Курсовая)
                        {
                            if (reserv.Count != 0 && reserv.Exists(x => (x.Заголовок == st.Заголовок))) message = "Nothing";
                            else
                            {
                                reserv.Add(st);
                            }
                        }
                        t.writetosoap(reserv, currentname);
                    }
                }

            }

            else MessageBox.Show("Не выбран студент!", "Ошибка");
        }

        private void soapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isselectedtextbox(comboBoxliststudents))
            {
                try
                {
                    string currentname = (string)comboBoxliststudents.SelectedItem;
                    foreach (Student t in liststudents)
                    {
                        if (t.ФИО == comboBoxliststudents.SelectedItem.ToString())
                        {
                            courseWorkBindingSource.DataSource = t.readfromsoap(currentname).ToDataTable();
                            dataGridView1.DataSource = courseWorkBindingSource;
                            EnableGridFilter(true);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Файл еще не создан!", "Ошибка - несозданный файл");
                }
            }
            else MessageBox.Show("Не выбран студент!", "Ошибка");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = "";
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Cells[1, 1] = "Заголовок";
            ExcelApp.Cells[1, 2] = "Описание";
            ExcelApp.Cells[1, 3] = "Дата";
            
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (i == 3)
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
                courseWorkBindingSource.DataSource = dt;
                dataGridView1.DataSource = courseWorkBindingSource;
                EnableGridFilter(true);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                excelWorkbook.Close();
                ExcelApp.Quit();
            }
        }
        private void textBoxtitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (textBoxtitle.Text != "" && c == 0)
                {

                    this.progressBar1.Value += 1;
                    c = 1;
                }

                if (textBoxtitle.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        c = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле названия курсовой!");

                }
                if (textBoxtitle.Text != "" && c != 0)
                {

                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }
        private void EnableGridFilter(bool value)
        {
            ЗаголовокColumn.FilteringEnabled = value;
            ОписаниеColumn.FilteringEnabled = value;
            ДатаСдачиColumn.FilteringEnabled = value;
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dataGridView1);
            if (string.IsNullOrEmpty(filterStatus))
            {
                toolStripStatusLabel1.Visible = false;
                toolStripStatusLabel2.Visible = false;
            }
            else
            {
                toolStripStatusLabel1.Visible = true;
                toolStripStatusLabel2.Visible = true;
                toolStripStatusLabel2.Text = filterStatus;
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                if (textBox1.Text != "" && d == 0)
                {

                    this.progressBar1.Value += 1;
                    d = 1;
                }

                if (textBox1.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        d = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле описания!");

                }
                if (textBox1.Text != "" && d != 0)
                {

                }
            }
            }
    }
}

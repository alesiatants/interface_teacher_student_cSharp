using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewAutoFilter;
using MoreLinq;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace Class_Student_Teacher
{

    public partial class Form1 : Form
    {
        ListTeachers listteacher = new ListTeachers();
        int c = 0, d = 0, x = 0, y = 0, m = 0, n = 0, v = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void EnableGridFilter(bool value)
        {
            ФИОColumn.FilteringEnabled = value;
            ДРColumn.FilteringEnabled = value;
            ПочтаColumn.FilteringEnabled = value;
            СтранаColumn.FilteringEnabled = value;
            ГородColumn.FilteringEnabled = value;
            СпециализацияColumn.FilteringEnabled = value;
            ЗарплатаColumn.FilteringEnabled = value;
            КоличествоСтудентовColumn.FilteringEnabled = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image1= Image.FromFile(@"C:\Users\Алеся\Pictures\A.jpg");
            Image image2 = Image.FromFile(@"C:\Users\Алеся\Pictures\B.jpg");
            string[] key = (string[])Enum.GetNames(typeof(Key));
            Teacher teacher1 = new Teacher("Кирова Наталия Ивановна", new DateTime(1997, 03, 11), "natali@gmail.com", new Address("Украина", "Херсон"), Key.Python, ImageToBase64(image1, System.Drawing.Imaging.ImageFormat.Jpeg),  20000, 7);
            Teacher teacher2 = new Teacher("Разимова Виктория Олеговна", new DateTime(1999, 10, 15), "viktoria@gmail.com", new Address("Украина", "Херсон"), Key.Scala, ImageToBase64(image2, System.Drawing.Imaging.ImageFormat.Jpeg), 20000, 8);
            listteacher.add(teacher1);
            listteacher.add(teacher2);
            comboBoxKey.Items.AddRange(key);
            teacherBindingSource.DataSource = listteacher.ListTeacher.ToDataTable();
            dataGridView1.DataSource = teacherBindingSource;
            EnableGridFilter(true);
            this.timer1.Start();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool checklist(Teacher teacher)
        {
            if (listteacher.ListTeacher.Exists(x => (x.ФИО == teacher.ФИО))) return true;
            else return false;
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
        public bool isselectedtextbox(ComboBox one)
        {
            if (one.SelectedIndex > -1) return true;
            else return false;
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
        private void buttonAddtoTeacherList_Click(object sender, EventArgs e)
        {
            string inicial, email, message = "Список уже содержит учителей под именем";
            int numofseat, salary = 0;
            Address address;
            Key key;
            DateTime date;
            string photo;
            try
            {
                inicial = textBoxSurname.Text;
                date = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                email = textBoxEmail.Text;
                address = new Address(textBoxCountry.Text, textBoxCity.Text);
                /*salary = int.Parse(textBoxSalary.Text);
                numofseat = int.Parse(comboBoxNumofseat.SelectedItem.ToString());
                key = (Key)Enum.Parse(typeof(Key), comboBoxKey.SelectedItem.ToString(), true);*/

                /*if (this.progressBar1.Value == 8) {
                    Teacher teacher = new Teacher(inicial, date, email, address, key, salary, numofseat);
                    if (checklist(teacher) == false) listteacher.add(teacher);
                    teacherBindingSource.DataSource = listteacher.ListTeacher.ToDataTable();
                    dataGridView1.DataSource = teacherBindingSource;
                    EnableGridFilter(true);
                    progressBar1.Value = 0;

                }
                else
                {
                    MessageBox.Show("Вы заполнили не все поля!");
                }*/
                if (IsNotEmpty(inicial) && IsNotEmpty(dateTimePicker1.Value.ToString()) && IsNotEmpty(email) && IsNotEmpty(textBoxCountry.Text) && IsNotEmpty(textBoxCity.Text) && IsNotEmpty(salary.ToString()) && IsNotEmpty(numericUpDown1.ToString()) && isselectedtextbox(comboBoxKey) && pictureBox1.Image != null)
                 {
                         salary = int.Parse(maskedTextBox1.Text);

                     
                     numofseat = int.Parse(numericUpDown1.Value.ToString());
                     key = (Key)Enum.Parse(typeof(Key), comboBoxKey.SelectedItem.ToString(), true);
                    photo = ImageToBase64(pictureBox1.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
                    if (IsValidEmail(email) == false)
                     {
                         MessageBox.Show("Неверная почта", "Ошибка - некорректная почта");
                         textBoxEmail.BackColor = Color.Red;
                     }
                     else
                     {

                         textBoxEmail.BackColor = Color.White;
                         
                             Teacher teacher = new Teacher(inicial, date, email, address, key, photo, salary, numofseat);
                            if (checklist(teacher) == false) { 
                                listteacher.add(teacher);
                                progressBar1.Value = 0;
                            }
                     }
                     
                 }
                 else
                 {
                     MessageBox.Show("Вы не везде заполнили поля", "Ошибка - неверный ввод");
                 }
                 teacherBindingSource.DataSource = listteacher.ListTeacher.ToDataTable();
                 dataGridView1.DataSource = teacherBindingSource;
                 EnableGridFilter(true);
                 clear();
                 

            }
            catch
            {
                MessageBox.Show("Вы ввели данные неверного типа либо вообще не ввели", "Ошибка - неверный ввод");
            }           
        }
        public void clear()
        {
            textBoxSurname.Clear();
            textBoxEmail.Clear();
            textBoxCountry.Clear();
            textBoxCity.Clear();
            maskedTextBox1.Clear();
            numericUpDown1.Text = "";
            comboBoxKey.Text = "";
            x = 0;
            y = 0;
            v = 0;
            m = 0;
            n = 0;
            d = 0;
            c = 0;
            progressBar1.Value = 0;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listteacher.clear();
            teacherBindingSource.DataSource = listteacher.ListTeacher.ToDataTable();
            dataGridView1.DataSource = teacherBindingSource;
            EnableGridFilter(true);
        }

        private void buttonOutputListTeacher_Click(object sender, EventArgs e)
        {

            teacherBindingSource.DataSource = listteacher.ListTeacher.ToDataTable();
            dataGridView1.DataSource = teacherBindingSource;
            EnableGridFilter(true);
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listteacher.ListTeacher.Count != 0)
            {
                foreach (Teacher obj in listteacher.ListTeacher)
                {
                    listteacher.writetojson(obj);
                }
            }
            else
            {
                MessageBox.Show("Список учителей пуст!", "Ошибка записи");
            }
        }

        private void jsonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                teacherBindingSource.DataSource = listteacher.readfromjson().ToDataTable();
                dataGridView1.DataSource = teacherBindingSource;
                EnableGridFilter(true);
                pictureBox1.Image = Base64ToImage(listteacher.readfromjson()[0].Фото);
            }
            catch
            {
                MessageBox.Show("Файл Teachers.json еще не создан!", "Ошибка - несозданный файл");
            }
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Teacher> reserv = new List<Teacher>();
            string message = "Список уже содержит студентов под именем";
            /*
                foreach (Teacher obj in listteacher.ListTeacher)
                {
                    if (reserv.Count != 0 && reserv.Exists(x => (x.ФИО == obj.ФИО))) message = "Nothing";
                    else
                    {
                        reserv.Add(obj);
                    }
                }*/

            if (listteacher.ListTeacher.Count == 0)
            {
                MessageBox.Show("Список пуст, нечего записывать!", "Ошибка - пустой список");
            }
            else
            {
                listteacher.writetoxml(listteacher.ListTeacher);
            }
        }

        private void xmlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                teacherBindingSource.DataSource = listteacher.readfromxml().ToDataTable();
                dataGridView1.DataSource = teacherBindingSource;
                EnableGridFilter(true);
            }
            catch
            {
                MessageBox.Show("Файл Teachers.xml еще не создан!", "Ошибка - несозданный файл");
            }
        }

        private void soapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Teacher> reserv = new List<Teacher>();
            string name, message = "Список уже содержит студентов под именем";

            if (listteacher.ListTeacher.Count == 0)
            {
                MessageBox.Show("Список пуст, нечего записывать!", "Ошибка - пустой список");
            }
            else
            {
                listteacher.writetosoap(listteacher.ListTeacher);
            }
        }

        private void soapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                teacherBindingSource.DataSource = listteacher.readfromsoap().ToDataTable();
                dataGridView1.DataSource = teacherBindingSource;
                EnableGridFilter(true);
            }
            catch
            {
                MessageBox.Show("Файл Teachers.xml еще не создан!", "Ошибка - несозданный файл");
            }
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
            ExcelApp.Cells[1, 6] = "Специализация";
            ExcelApp.Cells[1, 7] = "Зарплата";
            ExcelApp.Cells[1, 8] = "Количество Студентов";
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (i == 5)
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
                teacherBindingSource.DataSource = dt;
                dataGridView1.DataSource = teacherBindingSource;
                EnableGridFilter(true);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                excelWorkbook.Close();
                ExcelApp.Quit();
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (listteacher == null)
            {
                MessageBox.Show("Список учителей пуст!");
            }
            else
            {
                Form2 newForm = new Form2(listteacher);
                newForm.ShowDialog();
            }
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

        private void ShowAll_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }

        private void statusStripShowAll_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                if (textBoxSurname.Text != "" && c == 0)
                {

                    this.progressBar1.Value += 1;
                    c = 1;
                }

                if (textBoxSurname.Text == "")
                {
                     if (progressBar1.Value != 0)
                     {
                         this.progressBar1.Value -= 1;
                          c = 0;
                     }
                    MessageBox.Show("Вы не заполнили поле имени!");

                }
                if (textBoxSurname.Text != "" && c != 0)
                {

                }

            }
        }
       
        private void buttonaddphoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.ShowDialog();

            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void buttonShowinfo_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(listteacher);
            form.ShowDialog();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    if (maskedTextBox1.Text == "")
                    {
                        if (progressBar1.Value != 0)
                        {
                            this.progressBar1.Value -= 1;
                            v = 0;
                        }
                        MessageBox.Show("Вы не заполнили поле зарплата");
                    }
                    
                        if (v == 0)
                        {
                            this.progressBar1.Value += 1;
                            v = 1;
                        }
                        else { }
                    }
                    
                
            }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsNotEmpty(numericUpDown1.ToString()))
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
                    MessageBox.Show("Вы не заполнили поле количество студентов");
                }
            }
        }

        private void textBoxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxEmail.Text == "")
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

                    if (IsValidEmail(textBoxEmail.Text))
                    {
                        if (d == 0)
                        {
                            textBoxEmail.BackColor = Color.White;
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
                        textBoxEmail.BackColor = Color.Red;


                    }
                }


            }
        }
        private void textBoxCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (IsNotEmpty(textBoxCountry.Text) && m == 0)
                {
                    this.progressBar1.Value += 1;
                    m = 1;
                }
                if (textBoxCountry.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        m = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле страна!");

                }
                if (textBoxCountry.Text != "" && m != 0)
                {

                }
            }
        }
        private void textBoxCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (IsNotEmpty(textBoxCity.Text) && n == 0)
                {
                    this.progressBar1.Value += 1;
                    n = 1;
                }
                if (textBoxCity.Text == "")
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        n = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле город!");

                }
                if (textBoxCity.Text != "" && n != 0)
                {

                }
            }
        }
        
            

        
        
        private void comboBoxKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (isselectedtextbox(comboBoxKey))
                {

                    if (y == 0)
                    {
                        this.progressBar1.Value += 1;
                        y = 1;
                    }
                }
                else
                {
                    if (progressBar1.Value != 0)
                    {
                        this.progressBar1.Value -= 1;
                        y = 0;
                    }
                    MessageBox.Show("Вы не заполнили поле специализации");
                }
            }
        }
    }
}

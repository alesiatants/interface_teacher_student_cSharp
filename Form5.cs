using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Student_Teacher
{
    public partial class Form5 : Form
    {
        ListTeachers list = new ListTeachers();
        
        public Form5(ListTeachers teachers)
        {
            InitializeComponent();
            list = teachers;
            

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

        private void Form5_Load(object sender, EventArgs e)
        {
            GroupBox[] groupBox = new GroupBox[list.ListTeacher.Count];
            RadioButton[] radButGamer = new RadioButton[6];
            RadioButton[] radButComp = new RadioButton[6];
            PictureBox[] pictureBox = new PictureBox[list.ListTeacher.Count];
            TextBox[] textBoxName = new TextBox[list.ListTeacher.Count];
            Label[] name = new Label[list.ListTeacher.Count];
            DateTimePicker[] date = new DateTimePicker[list.ListTeacher.Count];
            Label[] birthday = new Label[list.ListTeacher.Count];
            Label[] email = new Label[list.ListTeacher.Count];
            Label[] country = new Label[list.ListTeacher.Count];
            Label[] city = new Label[list.ListTeacher.Count];
            Label[] salary = new Label[list.ListTeacher.Count];
            Label[] key = new Label[list.ListTeacher.Count];
            Label[] numofseat = new Label[list.ListTeacher.Count];
            TextBox[] textBoxEmail = new TextBox[list.ListTeacher.Count];
            TextBox[] textBoxCountry = new TextBox[list.ListTeacher.Count];
            TextBox[] textBoxCity = new TextBox[list.ListTeacher.Count];
            TextBox[] textBoxSalary = new TextBox[list.ListTeacher.Count];
            TextBox[] textBoxKey = new TextBox[list.ListTeacher.Count];
            TextBox[] textBoxNumOfSeat = new TextBox[list.ListTeacher.Count];
            for (int i = 0; i < list.ListTeacher.Count; i++)
            {
                groupBox[i] = new GroupBox();
                groupBox[i].BackColor = Color.MediumAquamarine;
                groupBox[i].FlatStyle = FlatStyle.Flat;
                groupBox[i].Text = "Teacher " + Convert.ToString(i + 1);
                groupBox[i].Width = 400;
                groupBox[i].Height = 400;
                groupBox[i].Location = new Point(12, 12 + 400 * i);
                pictureBox[i] = new PictureBox();
                pictureBox[i].Image = Base64ToImage(list.ListTeacher[i].Фото);
                pictureBox[i].Location = new Point(20, 20);
                pictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox[i].Width = 100;
                pictureBox[i].Height = 100;
                name[i] = new Label();
                name[i].Font = new Font("Bookman Old Style", 10);

                name[i].Text = "ФИО";
                name[i].Location = new Point(20, 30 + 100);
                name[i].Width = 150;
                textBoxName[i] = new TextBox();
                textBoxName[i].Font = new Font("Bookman Old Style", 10);
                textBoxName[i].Text = list.ListTeacher[i].ФИО;
                textBoxName[i].Location = new Point(180, 30 + 100);
                textBoxName[i].Width = 170;

                birthday[i] = new Label();
                birthday[i].Text = "День рождения";
                birthday[i].Font = new Font("Bookman Old Style", 10);
                birthday[i].Location = new Point(20, 30 + 130);
                birthday[i].Width = 150;
                date[i] = new DateTimePicker();
                date[i].Text = list.ListTeacher[i].ДатаРождения.ToString();
                date[i].Location = new Point(180, 30 + 130);
                date[i].Font = new Font("Bookman Old Style", 10);
                date[i].Width = 170;

                email[i] = new Label();
                email[i].Text = "Почта";
                email[i].Font = new Font("Bookman Old Style", 10);
                email[i].Location = new Point(20, 30 + 160);
                email[i].Width = 150;
                textBoxEmail[i] = new TextBox();
                textBoxEmail[i].Text = list.ListTeacher[i].Почта;
                textBoxEmail[i].Font = new Font("Bookman Old Style", 10);
                textBoxEmail[i].Location = new Point(180, 30 + 160);
                textBoxEmail[i].Width = 170;

                country[i] = new Label();
                country[i].Text = "Страна";
                country[i].Font = new Font("Bookman Old Style", 10);
                country[i].Location = new Point(20, 30 + 190);
                country[i].Width = 150;
                textBoxCountry[i] = new TextBox();
                textBoxCountry[i].Text = list.ListTeacher[i].Страна;
                textBoxCountry[i].Font = new Font("Bookman Old Style", 10);
                textBoxCountry[i].Location = new Point(180, 30 + 190);
                textBoxCountry[i].Width = 170;

                city[i] = new Label();
                city[i].Text = "Город";
                city[i].Font = new Font("Bookman Old Style", 10);
                city[i].Location = new Point(20, 30 + 220);
                city[i].Width = 100;
                textBoxCity[i] = new TextBox();
                textBoxCity[i].Text = list.ListTeacher[i].Город;
                textBoxCity[i].Font = new Font("Bookman Old Style", 10);
                textBoxCity[i].Location = new Point(180, 30 + 220);
                textBoxCity[i].Width = 170;

                salary[i] = new Label();
                salary[i].Text = "Зарплата";
                salary[i].Font = new Font("Bookman Old Style", 10);
                salary[i].Location = new Point(20, 30 + 250);
                salary[i].Width = 150;
                textBoxSalary[i] = new TextBox();
                textBoxSalary[i].Font = new Font("Bookman Old Style", 10);
                textBoxSalary[i].Text = list.ListTeacher[i].Зарплата.ToString();
                textBoxSalary[i].Location = new Point(180, 30 + 250);
                textBoxSalary[i].Width = 170;

                numofseat[i] = new Label();
                numofseat[i].Text = "Количество студентов";
                numofseat[i].Font = new Font("Bookman Old Style", 10);
                numofseat[i].Location = new Point(20, 30 + 280);
                numofseat[i].Width = 150;
                textBoxNumOfSeat[i] = new TextBox();
                textBoxNumOfSeat[i].Font = new Font("Bookman Old Style", 10);
                textBoxNumOfSeat[i].Text = list.ListTeacher[i].КоличествоСтудентов.ToString();
                textBoxNumOfSeat[i].Location = new Point(180, 30 + 280);
                textBoxNumOfSeat[i].Width = 170;

                key[i] = new Label();
                key[i].Text = "Специализация";
                key[i].Font = new Font("Bookman Old Style", 10);
                key[i].Location = new Point(20, 30 + 310);
                key[i].Width = 150;
                textBoxKey[i] = new TextBox();
                textBoxKey[i].Font = new Font("Bookman Old Style", 10);
                textBoxKey[i].Text = list.ListTeacher[i].Специализация.ToString();
                textBoxKey[i].Location = new Point(180, 30 + 310);
                textBoxKey[i].Width = 170;


                groupBox[i].Controls.Add(pictureBox[i]);
                groupBox[i].Controls.Add(textBoxName[i]);
                groupBox[i].Controls.Add(name[i]);
                groupBox[i].Controls.Add(date[i]);
                groupBox[i].Controls.Add(birthday[i]);
                groupBox[i].Controls.Add(textBoxEmail[i]);
                groupBox[i].Controls.Add(email[i]);
                groupBox[i].Controls.Add(textBoxCountry[i]);
                groupBox[i].Controls.Add(country[i]);
                groupBox[i].Controls.Add(textBoxCity[i]);
                groupBox[i].Controls.Add(city[i]);
                groupBox[i].Controls.Add(textBoxSalary[i]);
                groupBox[i].Controls.Add(salary[i]);
                groupBox[i].Controls.Add(textBoxNumOfSeat[i]);
                groupBox[i].Controls.Add(numofseat[i]);
                groupBox[i].Controls.Add(textBoxKey[i]);
                groupBox[i].Controls.Add(key[i]);
                //groupBox[i].Controls.Add(radButComp[i]);

                Controls.Add(groupBox[i]);
            } 
        }
    }
}

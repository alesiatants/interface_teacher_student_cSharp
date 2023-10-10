using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Class_Student_Teacher
{
    public partial class Form6 : Form
    {
        List<Student> list = new List<Student>();
        public Form6(List<Student> students)
        {
            InitializeComponent();
            list = students;
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

        private void Form6_Load(object sender, EventArgs e)
        {
            GroupBox[] groupBox = new GroupBox[list.Count];
            PictureBox[] pictureBox = new PictureBox[list.Count];
            TextBox[] textBoxName = new TextBox[list.Count];
            Label[] name = new Label[list.Count];
            DateTimePicker[] date = new DateTimePicker[list.Count];
            Label[] birthday = new Label[list.Count];
            Label[] email = new Label[list.Count];
            Label[] country = new Label[list.Count];
            Label[] city = new Label[list.Count];
            Label[] group = new Label[list.Count];
            Label[] form = new Label[list.Count];
            Label[] key = new Label[list.Count];
            TextBox[] textBoxEmail = new TextBox[list.Count];
            TextBox[] textBoxCountry = new TextBox[list.Count];
            TextBox[] textBoxCity = new TextBox[list.Count];
            TextBox[] textBoxGroup = new TextBox[list.Count];
            TextBox[] textBoxKey = new TextBox[list.Count];
            CheckBox[] textBoxForm = new CheckBox[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                groupBox[i] = new GroupBox();
                groupBox[i].BackColor = Color.MediumAquamarine;
                groupBox[i].FlatStyle = FlatStyle.Flat;
                groupBox[i].Text = "Student " + Convert.ToString(i + 1);
                groupBox[i].Width = 400;
                groupBox[i].Height = 400;
                groupBox[i].Location = new Point(12, 12 + 400 * i);
                pictureBox[i] = new PictureBox();
                pictureBox[i].Image = Base64ToImage(list[i].Фото);
                pictureBox[i].Location = new Point(20, 20);
                pictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox[i].Width = 100;
                pictureBox[i].Height = 100;
                name[i] = new Label();
                name[i].Text = "ФИО";
                name[i].Font = new Font("Bookman Old Style", 10);
                name[i].Location = new Point(20, 30 + 100);
                name[i].Width = 130;
                textBoxName[i] = new TextBox();
                textBoxName[i].Text = list[i].ФИО;
                textBoxName[i].Font = new Font("Bookman Old Style", 10);
                textBoxName[i].Location = new Point(150, 30 + 100);
                textBoxName[i].Width = 170;

                birthday[i] = new Label();
                birthday[i].Text = "День рождения";
                birthday[i].Font = new Font("Bookman Old Style", 10);
                birthday[i].Location = new Point(20, 30 + 130);
                birthday[i].Width = 100;
                date[i] = new DateTimePicker();
                date[i].Text = list[i].ДатаРождения.ToString();
                date[i].Font = new Font("Bookman Old Style", 10);
                date[i].Location = new Point(150, 30 + 130);
                date[i].Width = 170;

                email[i] = new Label();
                email[i].Text = "Почта";
                email[i].Font = new Font("Bookman Old Style", 10);
                email[i].Location = new Point(20, 30 + 160);
                email[i].Width = 130;
                textBoxEmail[i] = new TextBox();
                textBoxEmail[i].Font = new Font("Bookman Old Style", 10);
                textBoxEmail[i].Text = list[i].Почта;
                textBoxEmail[i].Location = new Point(150, 30 + 160);
                textBoxEmail[i].Width = 170;

                country[i] = new Label();
                country[i].Text = "Страна";
                country[i].Font = new Font("Bookman Old Style", 10);
                country[i].Location = new Point(20, 30 + 190);
                country[i].Width = 130;
                textBoxCountry[i] = new TextBox();
                textBoxCountry[i].Text = list[i].Страна;
                textBoxCountry[i].Font = new Font("Bookman Old Style", 10);
                textBoxCountry[i].Location = new Point(150, 30 + 190);
                textBoxCountry[i].Width = 170;

                city[i] = new Label();
                city[i].Text = "Город";
                city[i].Font  = new Font("Bookman Old Style", 10);
                city[i].Location = new Point(20, 30 + 220);
                city[i].Width = 130;
                textBoxCity[i] = new TextBox();
                textBoxCity[i].Text = list[i].Город;
                textBoxCity[i].Font = new Font("Bookman Old Style", 10);
                textBoxCity[i].Location = new Point(150, 30 + 220);
                textBoxCity[i].Width = 170;

                group[i] = new Label();
                group[i].Text = "Группа";
                group[i].Font = new Font("Bookman Old Style", 10);
                group[i].Location = new Point(20, 30 + 250);
                group[i].Width = 130;
                textBoxGroup[i] = new TextBox();
                textBoxGroup[i].Font = new Font("Bookman Old Style", 10);
                textBoxGroup[i].Text = list[i].Группа;
                textBoxGroup[i].Location = new Point(150, 30 + 250);
                textBoxGroup[i].Width = 170;

                form[i] = new Label();
                form[i].Text = "Очная форма обучения";
                form[i].Font = new Font("Bookman Old Style", 10);
                form[i].Location = new Point(20, 30 + 280);
                form[i].Width = 130;
                textBoxForm[i] = new CheckBox();
                textBoxForm[i].Font = new Font("Bookman Old Style", 10);
                textBoxForm[i].Checked = list[i].ДневнаяФормаОбучения;
                textBoxForm[i].Location = new Point(150, 30 + 280);
                textBoxForm[i].Width = 170;

                key[i] = new Label();
                key[i].Text = "Специализация";
                key[i].Font = new Font("Bookman Old Style", 10);
                key[i].Location = new Point(20, 30 + 310);
                key[i].Width = 130;
                textBoxKey[i] = new TextBox();
                textBoxKey[i].Text = list[i].Специализация.ToString();
                textBoxKey[i].Font = new Font("Bookman Old Style", 10);
                textBoxKey[i].Location = new Point(150, 30 + 310);
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
                groupBox[i].Controls.Add(textBoxGroup[i]);
                groupBox[i].Controls.Add(group[i]);
                groupBox[i].Controls.Add(textBoxForm[i]);
                groupBox[i].Controls.Add(form[i]);
                groupBox[i].Controls.Add(textBoxKey[i]);
                groupBox[i].Controls.Add(key[i]);
                //groupBox[i].Controls.Add(radButComp[i]);

                Controls.Add(groupBox[i]);
            }
        }
    }
    }


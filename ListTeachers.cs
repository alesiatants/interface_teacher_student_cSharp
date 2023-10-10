using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace Class_Student_Teacher
{
    [Serializable]
    public class ListTeachers
    {
        private List<Teacher> listteacher;
        public ListTeachers()
        {
            listteacher = new List<Teacher>();
        }
        public void add(Teacher h)
        {
            listteacher.Add(h);
        }

        public void clear()
        {
            listteacher.Clear();
        }
        public Teacher findSurname(string str)
        {

            if (listteacher.Exists(obg => obg.ФИО == str)) return listteacher.Find(obg => obg.ФИО == str);
            else return new Teacher();


        }
        public void check_json()
        {
            if (File.Exists("Teachers.json") == false)
            {
                var file = File.Create("Teachers.json");
                file.Close();
            }
        }
        public List<Teacher> readfromjson()
        {
            string json = File.ReadAllText($"Teachers.json");
            List<Teacher> allofcurrentusers = JsonConvert.DeserializeObject<List<Teacher>>(json);
            return allofcurrentusers ?? new List<Teacher>();
        }
        public void writetojson(Teacher h)
        {
            string data = "";
            check_json();
            List<Teacher> allofcurrentusers = readfromjson();
            if (allofcurrentusers.Exists(x => x.ФИО == h.ФИО)) data = "Nothing";
            else
            {
                File.WriteAllText("Teachers.json", string.Empty);
                allofcurrentusers.Add(h);
                string serializedDBUsers = JsonConvert.SerializeObject(allofcurrentusers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("Teachers.json", serializedDBUsers);
            }

        }
        public void writetoxml(List<Teacher> list)
        {
            string data = "";
            if (File.Exists("Teachers.xml") == false)
            {
                XDocument xdoc = new XDocument();

                XElement teachers = new XElement("Учителя");
                for (int i = 0; i < list.Count; i++)
                {

                    XElement teacher = new XElement("Учитель");
                    XElement name = new XElement("ФИО", list[i].ФИО);
                    XElement age = new XElement("ДатаРождения", list[i].ДатаРождения);
                    XElement email = new XElement("Почта", list[i].Почта);
                    XElement country = new XElement("Страна", list[i].Страна);
                    XElement city = new XElement("Город", list[i].Город);
                    XElement key = new XElement("Специализация", Enum.GetName(list[i].Специализация.GetType(), list[i].Специализация));
                    XElement photo = new XElement("Фото", list[i].Фото);
                    XElement salary = new XElement("Зарплата", list[i].Зарплата);
                    XElement numofstudent = new XElement("Количествостудентов", list[i].КоличествоСтудентов);
                    teacher.Add(name);
                    teacher.Add(age);
                    teacher.Add(email);
                    teacher.Add(country);
                    teacher.Add(city);
                    teacher.Add(key);
                    teacher.Add(photo);
                    teacher.Add(salary);
                    teacher.Add(numofstudent);
                    teachers.Add(teacher);


                }
                xdoc.Add(teachers);
                xdoc.Save("Teachers.xml");

            }
            else
            {
                List<Teacher> allofcurrentusers = readfromxml();
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("Teachers.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                for (int i = 0; i < list.Count; i++)
                {
                    if (allofcurrentusers.Exists(x => x.ФИО == list[i].ФИО)) data = "Nothing";
                    else
                    {
                        XmlElement personElem = xDoc.CreateElement("Учитель");
                        XmlElement nameElem = xDoc.CreateElement("ФИО");
                        XmlElement ageElem = xDoc.CreateElement("ДатаРождения");
                        XmlElement emailElem = xDoc.CreateElement("Почта");
                        XmlElement countryElem = xDoc.CreateElement("Страна");
                        XmlElement cityElem = xDoc.CreateElement("Город");
                        XmlElement keyElem = xDoc.CreateElement("Специализация");
                        XmlElement photoElem = xDoc.CreateElement("Фото");
                        XmlElement salaryElem = xDoc.CreateElement("Зарплата");
                        XmlElement numofseatElem = xDoc.CreateElement("Количествостудентов");
                        // создаем текстовые значения для элементов и атрибута

                        XmlText nameText = xDoc.CreateTextNode(list[i].ФИО);
                        XmlText ageText = xDoc.CreateTextNode(list[i].ДатаРождения.ToString());
                        XmlText emailText = xDoc.CreateTextNode(list[i].Почта);
                        XmlText countryText = xDoc.CreateTextNode(list[i].Страна);
                        XmlText cityText = xDoc.CreateTextNode(list[i].Город);
                        XmlText keyText = xDoc.CreateTextNode(list[i].Специализация.ToString());
                        XmlText photoText = xDoc.CreateTextNode(list[i].Фото);
                        XmlText salaryText = xDoc.CreateTextNode(list[i].Зарплата.ToString());
                        XmlText numofseatText = xDoc.CreateTextNode(list[i].КоличествоСтудентов.ToString());


                        //добавляем узлы
                        nameElem.AppendChild(nameText);
                        ageElem.AppendChild(ageText);
                        emailElem.AppendChild(emailText);
                        countryElem.AppendChild(countryText);
                        cityElem.AppendChild(cityText);
                        keyElem.AppendChild(keyText);
                        photoElem.AppendChild(photoText);
                        salaryElem.AppendChild(salaryText);
                        numofseatElem.AppendChild(numofseatText);
                        
                        // добавляем атрибут name
                        // добавляем элементы company и age
                        personElem.AppendChild(nameElem);
                        personElem.AppendChild(ageElem);
                        personElem.AppendChild(emailElem);
                        personElem.AppendChild(countryElem);
                        personElem.AppendChild(cityElem);
                        personElem.AppendChild(keyElem);
                        personElem.AppendChild(photoElem);
                        personElem.AppendChild(salaryElem);
                        personElem.AppendChild(numofseatElem);
                        // добавляем в корневой элемент новый элемент person
                        xRoot?.AppendChild(personElem);
                    }

                }
                xDoc.Save("Teachers.xml");
            }



        }
        public List<Teacher> readfromxml()
        {
            string data = "";
            List<Teacher> list = new List<Teacher>();
            Teacher t = new Teacher();
            XDocument xDoc = XDocument.Load("Teachers.xml");
            XElement teachers = xDoc.Element("Учителя");
            foreach (XElement elem in teachers.Elements("Учитель"))
            {
                XElement surname = elem.Element("ФИО");
                XElement date = elem.Element("ДатаРождения");
                XElement email = elem.Element("Почта");
                XElement country = elem.Element("Страна");
                XElement city = elem.Element("Город");
                XElement key = elem.Element("Специализация");
                XElement photo = elem.Element("Фото");
                XElement salary = elem.Element("Зарплата");
                XElement numofseat = elem.Element("Количествостудентов");

                Teacher teacher = new Teacher(surname.Value, DateTime.Parse(date.Value), email.Value, new Address(country.Value, city.Value), (Key)Enum.Parse(typeof(Key), key.Value, true), photo.ToString(), int.Parse(salary.Value), int.Parse(numofseat.Value));
                list.Add(teacher);
            }
            
            return list;
        }
        public void writetosoap(List<Teacher> teachers)
        {
            string data = "";
            if (File.Exists("Teachers.soap") == false)
            {
                SoapFormatter formatter = new SoapFormatter();

                // создаем поток (soap файл)
                FileStream fs = new FileStream("Teachers.soap", FileMode.OpenOrCreate);

                /*foreach (Human obj in humans)
                    formatter.Serialize(fs, obj);*/
                formatter.Serialize(fs, teachers.ToArray());
                fs.Close();
            }
            else
            {
                List<Teacher> reserv = new List<Teacher>();
                List<Teacher> allofcurrentusers = readfromsoap();

                for (int i = 0; i < allofcurrentusers.Count; i++)
                {
                    reserv.Add(allofcurrentusers[i]);
                }
                for (int i = 0; i < teachers.Count; i++)
                {
                    if (allofcurrentusers.Exists(x => x.ФИО == teachers[i].ФИО)) data = "Nothing";
                    else
                    {
                        reserv.Add(teachers[i]);
                    }
                }
                SoapFormatter formatter = new SoapFormatter();

                FileStream fs = new FileStream("Teachers.soap", FileMode.OpenOrCreate);
                formatter.Serialize(fs, reserv.ToArray());
                fs.Close();
            }

        }
        public List<Teacher> readfromsoap()
        {
            List<Teacher> teachers = new List<Teacher>();
            SoapFormatter formatter = new SoapFormatter();
            FileStream fs = new FileStream("Teachers.soap", FileMode.OpenOrCreate);
            //Human h = formatter.Deserialize(fs) as Human;
            Teacher[] teacher = (Teacher[])formatter.Deserialize(fs);
            teachers = teacher.Cast<Teacher>().ToList();
            fs.Close();
            return teachers;
        }
        public Teacher findName(string str)
        {

            if (listteacher.Exists(obg => obg.ФИО == str)) return listteacher.Find(obg => obg.ФИО == str);
            else return new Teacher();


        }
        public List<Teacher> ListTeacher
        {
            get { return listteacher; }
            set { listteacher = value; }
        }
    }
}

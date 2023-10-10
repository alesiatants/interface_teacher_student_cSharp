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
    public class Teacher:Human
    {
        private int _salary;
        private int _numofseat;
        private List<Student> _list;
        public Teacher() : base()
        {
            _list = new List<Student>();
        }
        public Teacher(string surname, DateTime date, string email, Address address, Key key, string photo, int salary, int numofseat) : base(surname, date, email, address, key, photo)
        {
            this._salary = salary;
            this._numofseat = numofseat;
        }
        public void add(Student h)
        {
            if (check_numofset(h.Специализация.ToString()))
                _list.Add(h);
        }
        public bool check_numofset(string keys)
        {
            bool flag = false;
            if ((_list.Count < _numofseat) && (keys == Специализация.ToString()))
                flag = true;
            else
            {
                flag = false;
            }
            return flag;
        }
        public List<Student> get()
        {
            return _list;
        }
        
        public void clear()
        {
            _list.Clear();
        }
        public void check_json(string name)
        {
            if (File.Exists($"Students_{name}'s.json") == false)
            {
                var file = File.Create($"Students_{name}'s.json");
                file.Close();
            }
        }

        public void writetojson(Student h, string name)
        {
            string data = "";
            check_json(name);
            List<Student> allofcurrentusers = readfromjson(name);
            if (allofcurrentusers.Exists(x => x.ФИО == h.ФИО)) data = "Nothing";
            else
            {
                File.WriteAllText($"Students_{name}'s.json", string.Empty);
                allofcurrentusers.Add(h);
                string serializedDBUsers = JsonConvert.SerializeObject(allofcurrentusers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText($"Students_{name}'s.json", serializedDBUsers);
            }

        }


        public void writetoxml(List<Student> list, string nam)
        {
            string data = "";
            if (File.Exists($"Students_{nam}'s.xml") == false)
            {
                XDocument xdoc = new XDocument();

                XElement students = new XElement("Студенты");
                for (int i = 0; i < list.Count; i++)
                {

                    XElement student = new XElement("Студент");
                    XElement name = new XElement("ФИО", list[i].ФИО);
                    XElement age = new XElement("ДатаРождения", list[i].ДатаРождения);
                    XElement email = new XElement("Почта", list[i].Почта);
                    XElement country = new XElement("Страна", list[i].Страна);
                    XElement city = new XElement("Город", list[i].Город);
                    XElement key = new XElement("Специализация", Enum.GetName(list[i].Специализация.GetType(), list[i].Специализация));
                    XElement photo = new XElement("Фото", list[i].Фото);
                    XElement group = new XElement("Группа", list[i].Группа);
                    XElement form = new XElement("ДневнаяФормаОбучения", list[i].ДневнаяФормаОбучения.ToString());
                    student.Add(name);
                    student.Add(age);
                    student.Add(email);
                    student.Add(country);
                    student.Add(city);
                    student.Add(key);
                    student.Add(group);
                    student.Add(photo);
                    student.Add(form);
                    students.Add(student);


                }
                xdoc.Add(students);
                xdoc.Save($"Students_{nam}'s.xml");

            }
            else
            {
                List<Student> allofcurrentusers = readfromxml(nam);
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load($"Students_{nam}'s.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                for (int i = 0; i < list.Count; i++)
                {
                    if (allofcurrentusers.Exists(x => x.ФИО == list[i].ФИО)) data = "Nothing";
                    else
                    {
                        XmlElement personElem = xDoc.CreateElement("Студент");
                        XmlElement nameElem = xDoc.CreateElement("ФИО");
                        XmlElement ageElem = xDoc.CreateElement("ДатаРождения");
                        XmlElement emailElem = xDoc.CreateElement("Почта");
                        XmlElement countryElem = xDoc.CreateElement("Страна");
                        XmlElement cityElem = xDoc.CreateElement("Город");
                        XmlElement keyElem = xDoc.CreateElement("Специализация");
                        XmlElement photoElem = xDoc.CreateElement("Фото");
                        XmlElement groupElem = xDoc.CreateElement("Группа");
                        XmlElement formElem = xDoc.CreateElement("ДневнаяФормаОбучения");

                        // создаем текстовые значения для элементов и атрибута

                        XmlText nameText = xDoc.CreateTextNode(list[i].ФИО);
                        XmlText ageText = xDoc.CreateTextNode(list[i].ДатаРождения.ToString());
                        XmlText emailText = xDoc.CreateTextNode(list[i].Почта);
                        XmlText countryText = xDoc.CreateTextNode(list[i].Страна);
                        XmlText cityText = xDoc.CreateTextNode(list[i].Город);
                        XmlText keyText = xDoc.CreateTextNode(list[i].Специализация.ToString());
                        XmlText photoText = xDoc.CreateTextNode(list[i].Фото);
                        XmlText groupText = xDoc.CreateTextNode(list[i].Группа);
                        XmlText formText = xDoc.CreateTextNode(list[i].ДневнаяФормаОбучения.ToString());


                        //добавляем узлы
                        nameElem.AppendChild(nameText);
                        ageElem.AppendChild(ageText);
                        emailElem.AppendChild(emailText);
                        countryElem.AppendChild(countryText);
                        cityElem.AppendChild(cityText);
                        keyElem.AppendChild(keyText);
                        photoElem.AppendChild(photoText);
                        groupElem.AppendChild(groupText);
                        formElem.AppendChild(formText);
                        // добавляем атрибут name
                        // добавляем элементы company и age
                        personElem.AppendChild(nameElem);
                        personElem.AppendChild(ageElem);
                        personElem.AppendChild(emailElem);
                        personElem.AppendChild(countryElem);
                        personElem.AppendChild(cityElem);
                        personElem.AppendChild(keyElem);
                        personElem.AppendChild(photoElem);
                        personElem.AppendChild(groupElem);
                        personElem.AppendChild(formElem);
                        // добавляем в корневой элемент новый элемент person
                        xRoot?.AppendChild(personElem);
                    }

                }
                xDoc.Save($"Students_{nam}'s.xml");
            }



        }
        public List<Student> readfromxml(string nam)
        {
            List<Student> list = new List<Student>();
            XDocument xDoc = XDocument.Load($"Students_{nam}'s.xml");
            XElement teachers = xDoc.Element("Студенты");
            foreach (XElement elem in teachers.Elements("Студент"))
            {
                XElement surname = elem.Element("ФИО");
                XElement date = elem.Element("ДатаРождения");
                XElement email = elem.Element("Почта");
                XElement country = elem.Element("Страна");
                XElement city = elem.Element("Город");
                XElement key = elem.Element("Специализация");
                XElement photo = elem.Element("Фото");
                XElement group = elem.Element("Группа");
                XElement form = elem.Element("ДневнаяФормаОбучения");

                Student student = new Student(surname.Value, DateTime.Parse(date.Value), email.Value, new Address(country.Value, city.Value), (Key)Enum.Parse(typeof(Key), key.Value, true),photo.ToString(), group.Value, bool.Parse(form.Value));
                list.Add(student);
            }
            return list;
        }
        public List<Student> readfromjson(string name)
        {
            
                string json = File.ReadAllText($"Students_{name}'s.json");
                List<Student> allofcurrentusers = JsonConvert.DeserializeObject<List<Student>>(json);
                return allofcurrentusers ?? new List<Student>();
            
        }
        public void writetosoap(List<Student> students, string name)
        {
            string data = "";
            if (File.Exists($"Students_{name}'s.soap") == false)
            {
                SoapFormatter formatter = new SoapFormatter();

                // создаем поток (soap файл)
                FileStream fs = new FileStream($"Students_{name}'s.soap", FileMode.OpenOrCreate);

                /*foreach (Human obj in humans)
                    formatter.Serialize(fs, obj);*/
                formatter.Serialize(fs, students.ToArray());
                fs.Close();
            }
            else
            {
                List<Student> reserv = new List<Student>();
                List<Student> allofcurrentusers = readfromsoap(name);

                for (int i = 0; i < allofcurrentusers.Count; i++)
                {
                    reserv.Add(allofcurrentusers[i]);
                }
                for (int i = 0; i < students.Count; i++)
                {
                    if (allofcurrentusers.Exists(x => x.ФИО == students[i].ФИО)) data = "Nothing";
                    else
                    {
                        reserv.Add(students[i]);
                    }
                }
                SoapFormatter formatter = new SoapFormatter();

                FileStream fs = new FileStream($"Students_{name}'s.soap", FileMode.OpenOrCreate);
                formatter.Serialize(fs, reserv.ToArray());
                fs.Close();
            }

        }
        public List<Student> readfromsoap(string name)
        {
            List<Student> students = new List<Student>();
            SoapFormatter formatter = new SoapFormatter();
            FileStream fs = new FileStream($"Students_{name}'s.soap", FileMode.OpenOrCreate);
            //Human h = formatter.Deserialize(fs) as Human;
            Student[] student = (Student[])formatter.Deserialize(fs);
            students = student.Cast<Student>().ToList();
            fs.Close();
            return students;
        }
        public int Зарплата
        {
            get => _salary;
            set => _salary = value;
        }
        public int КоличествоСтудентов
        {
            get => _numofseat;
            set => _numofseat = value;
        }
        public List<Student> Liststudent
        {
            get => _list;
            set => _list = value;
        }
    }
}

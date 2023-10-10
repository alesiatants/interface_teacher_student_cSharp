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
    public class Student:Human
    {
        private string _group;
        private bool _form;
        private List<CourseWork> _listcoursework;
        public Student() : base()
        {
            _listcoursework = new List<CourseWork>();
        }
        public Student(string name, DateTime date, string email, Address address, Key key, string photo,  string group, bool form) : base(name, date, email, address, key, photo)
        {
            this._group = group;
            this._form = form;
        }
        public void add(CourseWork coursework)
        {
            _listcoursework.Add(coursework);
        }
        public void clear()
        {
            _listcoursework.Clear();
        }
        public void check_json(string name)
        {
            if (File.Exists($"CourseWorks_{name}'s.json") == false)
            {
                var file = File.Create($"CourseWorks_{name}'s.json");
                file.Close();
            }
        }

        public void writetojson(CourseWork coursework, string name)
        {
            string data = "";
            check_json(name);
            List<CourseWork> allofcurrentusers = readfromjson(name);
            if (allofcurrentusers.Exists(x => x.Заголовок == coursework.Заголовок)) data = "Nothing";
            else
            {
                File.WriteAllText($"CourseWorks_{name}'s.json", string.Empty);
                allofcurrentusers.Add(coursework);
                string serializedDBUsers = JsonConvert.SerializeObject(allofcurrentusers, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText($"CourseWorks_{name}'s.json", serializedDBUsers);
            }

        }


        public void writetoxml(List<CourseWork> list, string nam)
        {
            string data = "";
            if (File.Exists($"CourseWorks_{nam}'s.xml") == false)
            {
                XDocument xdoc = new XDocument();

                XElement courseworks = new XElement("КурсовыеРаботы");
                for (int i = 0; i < list.Count; i++)
                {

                    XElement coursework = new XElement("КурсоваяРабота");
                    XElement title = new XElement("Тема", list[i].Заголовок);
                    XElement description = new XElement("Описание", list[i].Описание);
                    XElement date = new XElement("ДатаСдачи", list[i].ДатаСдачи);
                    
                    coursework.Add(title);
                    coursework.Add(description);
                    coursework.Add(date);
                    
                    courseworks.Add(coursework);


                }
                xdoc.Add(courseworks);
                xdoc.Save($"CourseWorks_{nam}'s.xml");

            }
            else
            {
                List<CourseWork> allofcurrentusers = readfromxml(nam);
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load($"CourseWorks_{nam}'s.xml");
                XmlElement xRoot = xDoc.DocumentElement;

                for (int i = 0; i < list.Count; i++)
                {
                    if (allofcurrentusers.Exists(x => x.Заголовок == list[i].Заголовок)) data = "Nothing";
                    else
                    {
                        XmlElement personElem = xDoc.CreateElement("КурсоваяРабота");
                        XmlElement titleElem = xDoc.CreateElement("Тема");
                        XmlElement descriptionElem = xDoc.CreateElement("Описание");
                        XmlElement dateElem = xDoc.CreateElement("ДатаСдачи");
                        

                        // создаем текстовые значения для элементов и атрибута

                        XmlText titleText = xDoc.CreateTextNode(list[i].Заголовок);
                        XmlText descriptionText = xDoc.CreateTextNode(list[i].Описание);
                        XmlText dateText = xDoc.CreateTextNode(list[i].ДатаСдачи.ToString());
                        


                        //добавляем узлы
                        titleElem.AppendChild(titleText);
                        descriptionElem.AppendChild(descriptionText);
                        dateElem.AppendChild(dateText);
                        
                        // добавляем атрибут name
                        // добавляем элементы company и age
                        personElem.AppendChild(titleElem);
                        personElem.AppendChild(descriptionElem);
                        personElem.AppendChild(dateElem);
                        
                        // добавляем в корневой элемент новый элемент person
                        xRoot?.AppendChild(personElem);
                    }

                }
                xDoc.Save($"CourseWorks_{nam}'s.xml");
            }



        }
        public List<CourseWork> readfromxml(string nam)
        {
            List<CourseWork> list = new List<CourseWork>();
            XDocument xDoc = XDocument.Load($"CourseWorks_{nam}'s.xml");
            XElement teachers = xDoc.Element("КурсовыеРаботы");
            foreach (XElement elem in teachers.Elements("КурсоваяРабота"))
            {
                XElement surname = elem.Element("Тема");
                XElement date = elem.Element("Описание");
                XElement email = elem.Element("ДатаСдачи");

                CourseWork work = new CourseWork(surname.Value,date.Value, DateTime.Parse(email.Value));
                list.Add(work);
            }
            return list;
        }
        public List<CourseWork> readfromjson(string name)
        {
            string json = File.ReadAllText($"CourseWorks_{name}'s.json");
            List<CourseWork> allofcurrentusers = JsonConvert.DeserializeObject<List<CourseWork>>(json);
            return allofcurrentusers ?? new List<CourseWork>();
        }
        public void writetosoap(List<CourseWork> coursework, string name)
        {
            string data = "";
            if (File.Exists($"CourseWorks_{name}'s.soap") == false)
            {
                SoapFormatter formatter = new SoapFormatter();

                // создаем поток (soap файл)
                FileStream fs = new FileStream($"CourseWorks_{name}'s.soap", FileMode.OpenOrCreate);

                /*foreach (Human obj in humans)
                    formatter.Serialize(fs, obj);*/
                formatter.Serialize(fs, coursework.ToArray());
                fs.Close();
            }
            else
            {
                List<CourseWork> reserv = new List<CourseWork>();
                List<CourseWork> allofcurrentusers = readfromsoap(name);

                for (int i = 0; i < allofcurrentusers.Count; i++)
                {
                    reserv.Add(allofcurrentusers[i]);
                }
                for (int i = 0; i < coursework.Count; i++)
                {
                    if (allofcurrentusers.Exists(x => x.Заголовок == coursework[i].Заголовок)) data = "Nothing";
                    else
                    {
                        reserv.Add(coursework[i]);
                    }
                }
                SoapFormatter formatter = new SoapFormatter();

                FileStream fs = new FileStream($"CourseWorks_{name}'s.soap", FileMode.OpenOrCreate);
                formatter.Serialize(fs, reserv.ToArray());
                fs.Close();
            }

        }
        public List<CourseWork> readfromsoap(string name)
        {
            List<CourseWork> students = new List<CourseWork>();
            SoapFormatter formatter = new SoapFormatter();
            FileStream fs = new FileStream($"CourseWorks_{name}'s.soap", FileMode.OpenOrCreate);
            //Human h = formatter.Deserialize(fs) as Human;
            CourseWork[] student = (CourseWork[])formatter.Deserialize(fs);
            students = student.Cast<CourseWork>().ToList();
            fs.Close();
            return students;
        }

        public string Группа
        {
            get => _group;
            set => _group = value;
        }
        public bool ДневнаяФормаОбучения
        {
            get => _form;
            set => _form = value;
        }
        public List<CourseWork> Курсовая
        {
            get => _listcoursework;
            set => _listcoursework = value;

        }
    }
}

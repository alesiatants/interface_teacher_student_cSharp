using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student_Teacher
{
    [Serializable]
    public class CourseWork
    {
        private string _title;
        private string _description;
        private DateTime _data;
        public CourseWork()
        {
            this._title = "Заголовок";
            this._description = "Описание";
            this._data = new DateTime(2022, 11, 12);
        }
        public CourseWork(string title, string description, DateTime data)
        {
            this._title = title;
            this._description = description;
            this._data = data;
        }
       
        
        public string Заголовок
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Описание
        {
            get { return _description; }
            set { _description = value; }
        }
        public DateTime ДатаСдачи
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}

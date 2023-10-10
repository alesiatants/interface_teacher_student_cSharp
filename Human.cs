using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Class_Student_Teacher
{
    [Serializable]
    public enum Key
    {
        [EnumMember(Value = "CSharp")]
        //[XmlEnum(Name="CSharp")]
        CSharp,
        [EnumMember(Value = "Scala")]
        //[XmlEnum(Name = "Scala")]
        Scala,
        [EnumMember(Value = "Python")]
        //[XmlEnum(Name = "Python")]
        Python,
        [EnumMember(Value = "Lisp")]
        //[XmlEnum(Name = "Lisp")]
        Lisp,
        [EnumMember(Value = "Java")]
        //[XmlEnum(Name = "Java")]
        Java,
        [EnumMember(Value = "JS")]
        //[XmlEnum(Name = "JS")]
        JS
    }
    [Serializable]
    public class Human
    {
        private string _surname;
        private DateTime _date;
        private string _email;
        private Address _address;
        private Key _key;
        private string _photo;
        public Human()
        {
            _surname = "Tantsiurenko";
            _date = new DateTime(2004, 07, 11);
            _email = "alesiatant@gmail.com";
            _address = new Address();
            _key = Key.CSharp;
        }
        public Human(string surname, DateTime date, string email, Address address, Key key, string photo)
        {
            this._surname = surname;
            this._date = date;
            this._email = email;
            this._address = address;
            this._key = key;
            this._photo = photo;
        }
        public string ФИО
        {
            get => _surname;
            set => _surname = value;
        }
        public DateTime ДатаРождения
        {
            get => _date;
            set => _date = value;
        }
        public string Почта
        {
            get => _email;
            set => _email = value;
        }
        public string Страна
        {
            get => _address.Страна;
            set => _address.Страна = value;
        }
        public string Город
        {
            get => _address.Город;
            set => _address.Город = value;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        //[XmlEnum(typeof(Key))]
        public Key Специализация
        {
            get => _key;
            set => _key = value;
        }
        public string Фото
        {
            get => _photo;
            set => _photo = value;
        }
    }
}

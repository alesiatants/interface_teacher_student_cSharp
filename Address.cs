using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student_Teacher
{
    [Serializable]
    public class Address
    {
        private string _country;
        private string _city;
        public Address()
        {
            _country = "Ukrain";
            _city = "Kherson";
        }
        public Address(string country, string city)
        {
            this._country = country;
            this._city = city;
        }
        public string Страна
        {
            get => _country;
            set => _country = value;
        }
        public string Город
        {
            get => _city;
            set => _city = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingToClass
{
    partial class Car
    {
        static Car()
        {
            _type = "Buisiness";
        }

        public DateTime GetDateRelease()
        {
            return _dateRelease;
        }

        public long GetSerialNumber()
        {
            return _serialNumber;
        }

        public static string GetType()
        {
            return _type;
        }

        public void SetType(string type)
        {
            _type = type;
        }

        public string GetManufacturedCompany()
        {
            return _manufacturedCompany;
        }

        public void SetManufacturedCompany(string manufacturedCompany)
        {
            _manufacturedCompany = manufacturedCompany;
        }

        public string GetManufacturedCountry()
        {
            return _manufacturedCountry;
        }

        public void SetManufacturedCountry(string manufacturedCountry)
        {
            _manufacturedCountry = manufacturedCountry;
        }
    }
}

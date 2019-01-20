using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingToClass
{
    partial class Car
    {
        private DateTime _dateRelease;
        private long _serialNumber;
        private SaleInfo infoForCustomer;
        private string _manufacturedCompany;
        private string _manufacturedCountry;
        private static string _type;

        public Car()
        {
            _manufacturedCountry = "Germany";
            _manufacturedCompany = "Mercedes Benz";
            _serialNumber = 7879399674;
            _dateRelease = DateTime.Today;
            infoForCustomer = new SaleInfo(0,0);
        }

        public Car(string manufacturedCompany, string manufacturedCountry, DateTime dateRelease, long serialNumber,int priceForOneCar,int quantityOnStore)
        {
            _manufacturedCountry = manufacturedCountry;
            _manufacturedCompany = manufacturedCompany;
            _serialNumber = serialNumber;
            _dateRelease = dateRelease;
            infoForCustomer = new SaleInfo(priceForOneCar, quantityOnStore);
        }

        public void SetSaleInfo(int price,int quantityOnStore)
        {
            infoForCustomer.SetQuantity(quantityOnStore);
            infoForCustomer.SetGetPriceForOneCar(price);
        }

        public bool SellingInfo(int requiredQuantity,string nameShop,DateTime dateOfSelling)
        {
            if (!infoForCustomer.Equals(requiredQuantity))
            {
                return false;
            }
            else
            {
                infoForCustomer.SetQuantity(requiredQuantity);
                infoForCustomer.SetWhichShop(nameShop);
                infoForCustomer.SetDateSelling(dateOfSelling);
                return true;
            }
        }

        public void GetSaleInfo(ref int price, ref string nameShop, ref DateTime dateOfSelling)
        {
            price = infoForCustomer.GetPriceForOneCar();
            nameShop = infoForCustomer.GetWhichShop();
            dateOfSelling = infoForCustomer.GetDateSelling();
        }
    }
}

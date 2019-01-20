using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingToClass
{
    public class SaleInfo
    {
        private int _priceForOneCar;
        DateTime _dateSelling;
        private int _quantityOnStore;
        private string _whichShop;

        public SaleInfo(int priceForOneCar,int quantityOnStore)
        {
            _priceForOneCar = priceForOneCar;
            _quantityOnStore = quantityOnStore;
            _whichShop = "No customer";
        }

        public SaleInfo(int priceForOneCar,int quantityOnStore,string whichShop, DateTime dateSelling)
        {
            _priceForOneCar = priceForOneCar;
            _quantityOnStore = quantityOnStore;
            _whichShop = whichShop;
            _dateSelling = dateSelling;
        }

        public int GetPriceForOneCar()
        {
            return _priceForOneCar;
        }

        public void SetGetPriceForOneCar(int priceForOneCar)
        {
            _priceForOneCar = priceForOneCar;
        }

        public DateTime GetDateSelling()
        {
            return _dateSelling;
        }

        public void SetDateSelling(DateTime dateSelling)
        {
            _dateSelling = dateSelling;
        }

        public int GetQuantity()
        {
            return _quantityOnStore;
        }

        public void SetQuantity(int quantityOnStore)
        {
            _quantityOnStore = quantityOnStore;
        }

        public string GetWhichShop()
        {
            return _whichShop;
        }

        public void SetWhichShop(string whichShop)
        {
            _whichShop = whichShop;
        }

    }
}

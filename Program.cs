using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducingToClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] mercedes = new Car[5];
            int i = 0;
            while (i != mercedes.Length)
            {
                mercedes[i] = new Car();
                i++;
            }

            Console.WriteLine(mercedes[0].GetManufacturedCountry());
            Console.ReadLine();
        }
    }
}

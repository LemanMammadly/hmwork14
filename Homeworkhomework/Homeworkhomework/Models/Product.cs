using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworkhomework.Models
{


    internal class Product
    {
        private static int Id = 1000;
        public string ProductType;
        public string Code;
        public string Name;
        public int Price;
        public  int DiscountedPrice;
        public static int TotalCount;


        public Product(string productType,int price)
        {
            ProductType = productType;
            Price = price;
            Code = $"{productType[0]}{Id}";
            Id++;
            TotalCount++;
            Console.WriteLine(Code);
            Console.WriteLine($"Cemi {TotalCount} obyekt yaradilib.");
        }

        public Product( int discountprice, string productType)
        {
            ProductType=productType;
            DiscountedPrice= discountprice;
            Code = $"{productType[0]}{Id}";
            Id++;
            TotalCount++;
            Console.WriteLine(Code);
            Console.WriteLine($"Cemi {TotalCount} obyekt yaradilib.");
        }


    }
}

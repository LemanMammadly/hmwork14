using System;
using Homeworkhomework.Extentions;
using Homeworkhomework.Models;
using Homeworkhomework.Enums;

namespace Homeworkhomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int a = 6;
            //Console.WriteLine(a.IsEven());


            //int[] arr2 = { 3, 4, 5, 6, 7, 5, 9, 5, 8 };
            //int[] arr3=arr2.GetValueIndexes(5);
            //foreach (int item in arr3)
            //{
            //    Console.WriteLine(item);
            //}

            //int a = 5;
            //Console.WriteLine(a.IsOdd());

            //string str1 = "hello w0rld";
            //Console.WriteLine(str1.IsContainsDigit()); 

            //string str2 = "Hello World hello world";
            //int[] arr1= str2.GetValueIndexes('o');

            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            


            #region Task2
            //while (true)
            //{
            //    Console.WriteLine("Product secmek isteyirsinizmi? y/n");
            //    string check = Console.ReadLine();
            //    if (check == "y")
            //    {
            //        Console.WriteLine("Siyahidan Id secin: ");

            //        foreach (var item in Enum.GetValues(typeof(ProductType)))
            //        {
            //            Console.WriteLine($"Id: {(int)item} Name: {item}");
            //        }
            //        string prdcttyp = Console.ReadLine();

            //        int prdctnum;




            //        while (!int.TryParse(prdcttyp, out prdctnum) || prdctnum < 1000 || prdctnum > 1003)
            //        {

            //            Console.WriteLine("Daxil etdiyiniz deyer sehvdir!");
            //            prdcttyp = Console.ReadLine();
            //        }
            //        if (prdctnum == 1000)
            //        {
            //            Console.WriteLine($"{(ProductType)prdctnum}");
            //            string productname1 = ($"{(ProductType)prdctnum}");
            //            Console.WriteLine("Qiymetini daxil edin");
            //            string pricestr1 = Console.ReadLine();
            //            int discountprice;
            //            int.TryParse(pricestr1, out discountprice);
            //            discountprice = (discountprice - ((discountprice * 20) / 100));
            //            Product produc2 = new Product(discountprice, productname1);

            //            Console.WriteLine($"Endirimli qiymeti: {produc2.DiscountedPrice}");

            //        }
            //        else if(prdctnum==1001 || prdctnum==1002 || prdctnum == 1003)
            //        {
            //            Console.WriteLine($"{(ProductType)prdctnum}");
            //            string productname = ($"{(ProductType)prdctnum}");
            //            Console.WriteLine("Qiymetini daxil edin");
            //            string pricestr = Console.ReadLine();
            //            int price;
            //            int.TryParse(pricestr, out price);
            //            Product produc1 = new Product(productname, price);
            //            Console.WriteLine($"Qiymeti: { produc1.Price}");
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //} 
            #endregion


        }
    }
}

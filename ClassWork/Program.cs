using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Places { get; set; }
    }
    
    public class Program
    {

        static string[] keywords = { "shoes, cars, chalk, oil, goat, door, sugar, razor, gall, egg" };

        public static void Main()
        {
            
            var pro = new List<Product>();
            pro.Add(new Product { Name = "Biro", Price = 100, Quantity = 5, Places = "Lagos" });
            pro.Add(new Product { Name = "chalk", Price = 1000, Quantity = 3, Places = "Lagos" });
            pro.Add(new Product { Name = "Bag", Price = 1500, Quantity = 4, Places = "Ogun" });
            pro.Add(new Product { Name = "Shoe", Price = 500, Quantity = 1, Places = "Ogun" });
            pro.Add(new Product { Name = "Books", Price = 2000, Quantity = 3, Places = "Abuja" });

            //var word = pro.GroupBy(x => x.Places)
            //              .Select(x => (x.Key, Grouped: x.Select(x => x)))
            //              .OrderBy(x => x.Key); 

            //foreach(var item in word)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach(var item2 in item.Grouped)
            //    {
            //        Console.WriteLine($"    productname:{item2.Name}: {item2.Price}");
            //    }
            //}

            var word = pro.Where(x => x.Price > 500)
                          .OrderByDescending(x => x.Quantity)
                          .ThenBy(x => x.Name)
            
            .Select(x => (ProductName: x.Name, ProQuantity: x.Quantity));

            foreach (var item in word)
            {
                Console.WriteLine($"{item.ProductName} : {item.ProQuantity}");
            }
            //var word = keywords.Where(z => z.Contains("a") && z.Contains("o"));

            //foreach (var item in word)
            //{
            //    Console.WriteLine(item);
            //}




            //Console.WriteLine("This application convert dollar, pound and euro to naira");

            //Console.WriteLine("Enter currency");
            //var currency = Console.ReadLine().ToUpper().Trim();

            //Console.WriteLine("\nEnter the amount in digit");
            //var amount =Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine(" ");
            //const double toNaira = 580;
            //string d  = "Dollars";
            //string p = "Pounds";
            //string e = "Euros";
            //string dol = "Dollar";
            //string eu = "Euro";
            //string pd = "pounds";

            //switch (currency)
            //{
            //    case "DOLLAR":
            //    case "D":
            //        if (amount <= 1)
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, dol);
            //        else
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, d);
            //        break;

            //    case "POUND":
            //    case "P":
            //        if(amount <= 1)
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, pd);
            //        else
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, p);
            //        break;

            //    case "EURO":
            //    case "E":
            //        if( amount <= 1)
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, eu);
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, e);
            //        break;

            //    default : Console.WriteLine("Invalid Input");
            //        break;

            //}
        }
    }
}

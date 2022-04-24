using System;
using System.Collections.Generic;

namespace ClassWork
{
    public class Program
    {
        static void Main()
        {
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
           
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(8);
            lst.Add(45);

            List<string> lst2 = new List<string>();
            lst2.Add("Hi");
            lst2.Add("Welcome");
            lst2.Add("to");
            lst2.Add("tutlane");

            Console.WriteLine("List1 element count: " + lst.Count);
            Console.WriteLine("list1 Capacity: " + lst.Capacity);
            foreach(int item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List2 Count: " + lst2.Count);
            Console.WriteLine("List2 Capacity: " + lst2.Capacity);
            foreach (string item in lst2)
            {
                Console.WriteLine(item);
            }
        }
    }
}

﻿using System;
using System.Collections;

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
           
            Hashtable htbl = new Hashtable();
            htbl.Add("msg", "Welcome");
            htbl.Add("site", "tutlane");
            htbl.Add(1, 20.5f);
            htbl.Add(2, 10);
            htbl[3] = "Tutorials";

            htbl.Remove("msg");
            htbl.Remove(1);

          
            Console.WriteLine("***Access element using foreach loop");
            foreach(DictionaryEntry item in htbl)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);    
            }

            Console.WriteLine("***Hashtable keys***");
            foreach(var item in htbl.Keys)
            {
                Console.WriteLine("Key = {0}", item);
            }

            Console.WriteLine("***Hashtable value***");
            foreach(var item in htbl.Values)
            {
                Console.WriteLine("Value = {0}", item);
            }
        }
    }
}

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

            ArrayList arrlist = new ArrayList();
            arrlist.Add("Welcome");
            arrlist.Add(100);
            arrlist.Add(20.5f);
            arrlist.Add("Tutlane");

            string msg = (string)arrlist[0];
            float num = (float)arrlist[2];

            Console.WriteLine("Element at [0]: " + msg);
            Console.WriteLine("Element at [2]: " + num);

            Console.WriteLine("***Access element with for loop***");
            for(int i = 0; i < arrlist.Count; i++)
            {
                Console.WriteLine(arrlist[i]);
            }

            Console.WriteLine("***Access element with foreach loop***");
            foreach(var item in arrlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}

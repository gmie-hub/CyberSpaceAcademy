using System;
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
           
            Queue que = new Queue();
            que.Enqueue("Welcome");
            que.Enqueue("Tutlane");
            que.Enqueue(20.5f);
            que.Enqueue(10);
            que.Enqueue(100);

            Console.WriteLine("Number of elements in a queue: {0}", que.Count);

            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Peek());
            Console.WriteLine(que.Peek());
            Console.WriteLine("Number of elements in a queue: {0}", que.Count);
        }
    }
}

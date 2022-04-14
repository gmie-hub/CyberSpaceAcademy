using System;

namespace ClassWork
{


    public class Program
    {
        static void Main()
        {
            Console.WriteLine("This can convert dollar, pounds and euros to naira");
            
            Console.WriteLine("Enter currency");
            var currency = Console.ReadLine().ToUpper().Trim();

            Console.WriteLine("\nEnter the amount");
            var amount =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine(" ");
            const double toNaira = 580;
            string d  = "Dollars";
            string p = "Pounds";
            string e = "Euros";

            switch (currency)
            {
                case "DOLLAR":
                case "D":
                        Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, d); 
                    break;

                case "POUND":
                case "P":
                    Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, p);
                    break;

                case "EURO":
                case "E":
                    Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, e);
                    break;

                default : Console.WriteLine("Invalid Input");
                    break;

            }

        }

        }
   
}

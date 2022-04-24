using System;
using System.Collections.Generic;

namespace ClassWork
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class Program
    {
        static void Main()
        {

            List<int> lst = new List<int>() { 1, 8, 45, 70};
            Console.WriteLine("Element at 0: " + lst[0]);
            Console.WriteLine("Element at 2: " + lst[2]);

            List<User> user = new List<User>()
            {
                new User{Id = 1, Name = "Jimi", Location = "Lagos"},
                new User{Id = 1, Name = "Sola", Location = "Ogun"},
                new User{Id = 1, Name = "Daniel", Location = "Rivers"},
                new User{Id = 1, Name = "Lateef", Location = "Ibadan"}
            };

            for (int i = 0; i < user.Count; i++)
                Console.WriteLine("Id: {0}, Name: {1}, Location: {2} ", user[i].Id, user[i].Name, user[i].Location);

            Console.WriteLine();

            foreach(var u in user)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Location: {2} ", u.Id, u.Name, u.Location);
            }
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

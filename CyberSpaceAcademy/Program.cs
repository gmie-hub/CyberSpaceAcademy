using System;

namespace CyberSpaceAcademy
{

    public class Program
    {
        static void Main(string[] args)
        {

            //var customer = new Customer(1);
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());

            //customer.promote();

            //Console.WriteLine(customer.Orders.Count);
            //var person = new Person();
            //person.SetBirthdate(new DateTime(1999, 09, 02));
            //Console.WriteLine(person.GetBirthdate());
            Console.Write("Enter F/M your gender: ");
            var input = Console.ReadLine().ToUpper().Trim();

            switch (input)
            {
                case "MALE":
                    goto case "M";
                case "FEMALE":
                case "F":
                    Console.WriteLine("You are female");
                    break;
                case "M":
                    Console.WriteLine("You are a female");
                    break ;
                default:
                    Console.WriteLine("Unknown gender");
                    break;
                
            }
            Console.WriteLine("End of main");
        }
    }
}

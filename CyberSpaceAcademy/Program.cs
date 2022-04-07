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

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
               
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("We are looking forward to weekend");
                    break;
            }
        }
    }
}

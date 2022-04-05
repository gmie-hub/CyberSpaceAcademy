using System;

namespace CyberSpaceAcademy
{

    public class Program
    {
        static void Main(string[] args)
        {
         
            //var customer = new Customer(1, "John");

            //var order = new Order();
            //customer.orders.Add(order);

            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            var person = new Person();
            person.SetBirthdate(new DateTime(1999, 09, 02));
            Console.WriteLine(person.GetBirthdate());
            
          
        }
    }
}

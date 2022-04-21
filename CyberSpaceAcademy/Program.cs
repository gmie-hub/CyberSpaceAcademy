using ClassLibrary.recap;
using System;
namespace CyberSpaceAcademy
{
   
    public class Program
    {
        public static void Main()
        {
            var employees = new Employee[]
            {
                new Employee(){FullName = "Warren Buffet"},
                new Employee(){FullName = "Bill Gate"},
                new Employee(){FullName = "Steve Jobs"}
            };

            var employees2 = new Employee[]
            {
                new Employee(){FullName = "John Piper"},
                new Employee(){FullName = "Charles Spurgeon"},
                new Employee(){FullName = "Arthur Pink"}
            };

            var staffs = new Staffs(employees);
            var staffs2 = new Staffs(employees2);

            foreach(var item in staffs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}

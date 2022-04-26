using ClassLibrary.recap;
using System;
using System.Collections.Generic;
namespace CyberSpaceAcademy
{
   
    public class Program
    {
        public static void Main()
        {

            int result = 0;
            Func<int, int, int> func = Add;
            result = func(10, 9);
            Console.WriteLine("Add result: {0}", result);

            func = Subtract;
            result = func(10, 9);
            Console.WriteLine("Subtract result: {0}", result);

            //prod.Sort(new SortNameProduct());
            //foreach(var p in prod)
            //{
            //    Console.WriteLine("{0}\t{1} ", p.Name, p.Quantity);
            //}
            //var employees = new Employee[]
            //{
            //    new Employee(){FullName = "Warren Buffet"},
            //    new Employee(){FullName = "Bill Gate"},
            //    new Employee(){FullName = "Steve Jobs"}
            //};

            //var employees2 = new Employee[]
            //{
            //    new Employee(){FullName = "John Piper"},
            //    new Employee(){FullName = "Charles Spurgeon"},
            //    new Employee(){FullName = "Arthur Pink"}
            //};

            //var staffs = new Staffs(employees);
            //var staffs2 = new Staffs(employees2);

            //foreach(var item in staffs)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}

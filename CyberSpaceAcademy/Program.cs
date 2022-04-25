using ClassLibrary.recap;
using System;
using System.Collections.Generic;
namespace CyberSpaceAcademy
{
   
    public class Program
    {
        public static void Main()
        {

            var prod = new List<Product>()
            {
                new Product(){Name = "Milo", Quantity = 10},
                 new Product(){Name = "Peak", Quantity = 12},
                  new Product(){Name = "Sugar", Quantity = 3},
                   new Product(){Name = "Indomie", Quantity = 60},
                    new Product(){Name = "Soap", Quantity = 5},
                     new Product(){Name = "Cream", Quantity = 2},
                      new Product(){Name = "Shoe", Quantity = 3},
                       new Product(){Name = "Brush", Quantity = 2},
                        new Product(){Name = "Biscuit", Quantity = 30},
                         new Product(){Name = "Perfume", Quantity = 1},
            };

            prod.Sort(new SortProduct<Product>());
            foreach (var p in prod)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

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
    }
}

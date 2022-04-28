using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
    
    public class Program
    {
        public static void Main()
        {
            var emp = new List<Employee>();

            emp.Add(new Employee { Id = 1, Name = "James", Age = 22, Gender = "M", Salary = 90000});
            emp.Add(new Employee { Id = 2, Name = "Jane", Age = 20, Gender = "F", Salary = 110000 });
            emp.Add(new Employee { Id = 3, Name = "David", Age = 25, Gender = "M", Salary = 95000 });
            emp.Add(new Employee { Id = 4, Name = "Teni", Age = 20, Gender = "F", Salary = 150000 });
            emp.Add(new Employee { Id = 5, Name = "Stones", Age = 35, Gender = "M", Salary = 100000 });
            emp.Add(new Employee { Id = 6, Name = "Lauren", Age = 30, Gender = "F", Salary = 200000 });
            emp.Add(new Employee { Id = 7, Name = "Dayo", Age = 30, Gender = "M", Salary = 170000 });
            emp.Add(new Employee { Id = 8, Name = "Sandra", Age = 27, Gender = "F", Salary = 250000 });
            emp.Add(new Employee { Id = 9, Name = "Scott", Age = 35, Gender = "M", Salary = 200000 });
            emp.Add(new Employee { Id = 10, Name = "Ashake", Age = 32, Gender = "F", Salary = 250000 });

            var word = emp.Where(x => x.Age > 25)
                          .OrderByDescending(x => x.Age);
                           
            foreach (var item in word)
            {
                Console.WriteLine($"Id: {item.Id}   Name: {item.Name}  " +
                    $"  Age: {item.Age}    Gender: {item.Gender}    Salary: {item.Salary}");
            }
            Console.WriteLine();

            var word2 = emp.Where(x => x.Gender == "F")
                           .OrderBy(x => x.Id);
                          
            foreach (var item in word2)
            {
              
                 Console.WriteLine($"Id: {item.Id}   Name: {item.Name}   Age: {item.Age}   Salary: {item.Salary}");  
            }
            Console.WriteLine();

            var word3 = emp.Where(x => x.Age == 20 || x.Age == 30 || x.Age == 35);
                           //.OrderBy(x => x.Name);

            foreach (var item in word3)
            {
                Console.WriteLine($"Id: {item.Id}   Name: {item.Name}  " +
                    $"  Age: {item.Age}    Gender: {item.Gender}    Salary: {item.Salary}");
            }

            Console.WriteLine();

            var word4 = emp.Where(x => x.Gender.Contains("F"))      
                           .Where(x => x.Id > 1 && x.Id < 8);
                          
            foreach (var item in word4)
            {
                Console.WriteLine($"Id: {item.Id}   Name: {item.Name}  " +
                    $"  Age: {item.Age}    Gender: {item.Gender}    Salary: {item.Salary}");
            }











            //var pro = new List<Product>();
            //pro.Add(new Product { Name = "Biro", Price = 100, Quantity = 5, Places = "Lagos" });
            //pro.Add(new Product { Name = "chalk", Price = 1000, Quantity = 3, Places = "Lagos" });
            //pro.Add(new Product { Name = "Bag", Price = 1500, Quantity = 4, Places = "Ogun" });
            //pro.Add(new Product { Name = "Shoe", Price = 500, Quantity = 1, Places = "Ogun" });
            //pro.Add(new Product { Name = "Books", Price = 2000, Quantity = 3, Places = "Abuja" });

            //var word = pro.GroupBy(x => x.Places)
            //              .Select(x => (x.Key, Grouped: x.Select(x => x)))
            //              .OrderBy(x => x.Key); 

            //foreach(var item in word)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach(var item2 in item.Grouped)
            //    {
            //        Console.WriteLine($"    productname:{item2.Name}: {item2.Price}");
            //    }
            //}

            //var word = pro.Where(x => x.Price > 500)
            //              .OrderByDescending(x => x.Quantity)
            //              .ThenBy(x => x.Name)

            //.Select(x => (ProductName: x.Name, ProQuantity: x.Quantity));

            //foreach (var item in word)
            //{
            //    Console.WriteLine($"{item.ProductName} : {item.ProQuantity}");
            //}
            //var word = keywords.Where(z => z.Contains("a") && z.Contains("o"));

            //foreach (var item in word)
            //{
            //    Console.WriteLine(item);
            //}




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

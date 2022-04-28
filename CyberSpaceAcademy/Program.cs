using ClassLibrary.recap;
using System;
using System.Collections.Generic;
using System.Linq;
namespace CyberSpaceAcademy
{
   
    public class Program
    {
        public static void Main()
        {

            var allSales = Sales.GetSales();
            var allItems = Items.GetItems();

            var data = allSales.GroupJoin(allItems,
                                c => c.Id,
                                x => x.SalesId, (k, GroupedItem) => new
                                {
                                    Id = k.Id,
                                    Category = k.CategoryName,
                                    GroupedItem
                                }

                );

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Category}");
                Console.WriteLine();
                foreach (var item2 in item.GroupedItem)
                    
                {
                    Console.WriteLine($"Quantity: {item2.RollNumber},     Item: {item2.ItemName}," +
                        $"      Amount: {item2.Amount}      Id: {item2.SalesId}");
                 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            var sumall = allItems.Sum(x => x.Amount);
                Console.WriteLine($"Total Amount: {sumall}");

            Console.WriteLine();
            var rollAverage = allItems.Average(x => x.RollNumber);
            Console.WriteLine($"Average RollNumber: {rollAverage}");

            Console.WriteLine();
            var data2 = from d in allSales
                        join c in allItems
                        on d.Id equals c.SalesId into GroupedItem
                        from f in GroupedItem.DefaultIfEmpty()
                        select new
                        {
                            d.Id,
                            d.CategoryName,
                            GroupedItem

                        };
            foreach (var item3 in data2)
            {
                Console.WriteLine($"{item3.CategoryName}");
                foreach (var item4 in item3.GroupedItem)
                {
                    Console.WriteLine($"Quantity: {item4.RollNumber},     Item: {item4.ItemName}," +
                       $"      Amount: {item4.Amount}      Id: {item4.SalesId}");
                }
            }








            //int[] evennumbers = { 2, 4, 4, 6, 8, 10, 10, 11, 12, 14, 16, 18, 20 };
            //int[] oddnumbers = {1, 3, 4, 5, 12, 7, 9, 11, 13, 15, 17, 18, 19 };

            ////Aggregate Operators

            //var numbers = evennumbers.Union(oddnumbers)
            //                         .Sum(x => x);
            //Console.WriteLine(numbers);

            //Console.WriteLine();
            ////Min
            //var number = evennumbers.Min(x => x);
            //Console.WriteLine(number);

            //Console.WriteLine();
            ////Average
            //var anumber = evennumbers.Average(x => x);
            //Console.WriteLine(anumber);

            //Console.WriteLine();
            //var allsum = evennumbers.Aggregate((a, b) => a * b);
            //Console.WriteLine(allsum);

            ////Union
            //var allnumbers = evennumbers.Union(oddnumbers)
            //                             .OrderBy(x => x);

            //var numbers = evennumbers.Where(x => x > 10)
            //                         .Union(evennumbers.Where( x => x < 10));
            //foreach (var i in allnumbers)
            //{
            //    Console.WriteLine(i);
            //}

            ////intersect
            //var queuenumbers = evennumbers.Intersect(oddnumbers)
            //                              .OrderBy(x => x);
            //foreach (var i in queuenumbers)
            //{
            //    Console.WriteLine($"Intersect::{i}");
            //}

            ////except
            //var exceptnumbers = oddnumbers.Except(evennumbers);
            //foreach (var i in exceptnumbers)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine();
            ////Distinct
            //var distinctnumbers = evennumbers.Distinct();
            //foreach (var i in distinctnumbers)
            //{
            //    Console.WriteLine(i);
            //}

            //var allstudent = Student.GetClasses();
            //var teacher = Standard.GetStandard();

            //var data = from d in teacher
            //           join c in allstudent
            //           on d.Id equals c.Standard into GroupedStudent
            //           from g in GroupedStudent.DefaultIfEmpty()
            //           select new
            //           {
            //               d.Id,
            //               d.ClassTeacher,
            //               classstudent = g == null ? "no student" : g.Name,
            //               classnum  = g == null ? 0 : g.RollNo,
            //               GroupedStudent
            //           };

            //foreach(var item in data)
            //{
            //    Console.WriteLine($"name: {item.ClassTeacher},   id: {item.Id}" +
            //        $"      Roll no: {item.classnum},   student: {item.classstudent}");
            //}

            //var data = teacher.GroupJoin(allstudent,
            //                   c => c.Id,
            //                    x => x.Standard, (k, GroupedStudent) => new
            //                    {
            //                        Id = k.Id,
            //                        teachername = k.ClassTeacher,
            //                        GroupedStudent
            //                    }
            //    );

            //foreach (var item in data)
            //{
            //    Console.WriteLine($"Name:  {item.teachername}");
            //    foreach (var items in item.GroupedStudent)
            //    {
            //        Console.WriteLine($"    {items.Name}    {items.RollNo}     {items.Gender}");
            //    }
            //}

            //var data = from c in allstudent
            //           join x in teacher
            //           on c.Standard equals x.Id
            //           select new
            //           {
            //               c.Name,
            //               x.ClassTeacher,
            //           };

            //var newdata = allstudent.Join(teacher,
            //   c => c.Standard,
            //   x => x.Id, (bt, xl) => new
            //   {
            //       bt.Name,
            //       xl.ClassTeacher,
            //       Id = bt.Standard,
            //       bt.Gender,
            //       xl.Fees
            //   }).Where(c => c.Id > 6)
            //   .OrderByDescending(x => x.Fees);
            //foreach (var alldata in newdata)
            //{
            //    Console.WriteLine($"StudentName: {alldata.Name},  " +
            //        $"Teacher:  {alldata.ClassTeacher}, Fees:  {alldata.Name}");
            //}
        }
    }
}

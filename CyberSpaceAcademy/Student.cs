using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSpaceAcademy
{
    public class Student
    {
        public int RollNo { get; set; } 
        public string Name { get; set; }    
        public int Standard { get; set; }
        public Gender Gender { get; set; }

        public static List<Student> GetClasses()
        {
            return new List<Student>
            {
                new Student{ RollNo = 101, Name = "Thomas", Gender = Gender.Male, Standard = 10 },
                 new Student{ RollNo = 102, Name = "Chris", Gender = Gender.Male, Standard = 8 },
                  new Student{ RollNo = 103, Name = "Luise", Gender = Gender.Female, Standard = 10 },
                   new Student{ RollNo = 104, Name = "Raw", Gender = Gender.Male, Standard = 8 },
                    new Student{ RollNo = 105, Name = "Kate", Gender = Gender.Female, Standard = 6 },
                     new Student{ RollNo = 106, Name = "John", Gender = Gender.Male, Standard = 6 },
                      new Student{ RollNo = 107, Name = "Ema", Gender = Gender.Female, Standard = 6 },
                       new Student{ RollNo = 108, Name = "Ravi", Gender = Gender.Male },

            };
        }
    }
    public enum Gender
    {
        Male,
        Female,
    }

    public class Standard
    {
        public int Id { get; set; }
        public string ClassTeacher { get; set; }    
        public double Fees { get; set; }

        public static List<Standard> GetStandard()
        {
            return new List<Standard>
            {
                new Standard{Id = 10, ClassTeacher = "Max", Fees = 100.0},
                new Standard{Id = 8, ClassTeacher = "Ajayi", Fees = 800.0},
                new Standard{Id = 6, ClassTeacher = "Femi", Fees = 600.0},
                new Standard{Id = 4, ClassTeacher = "Rheva", Fees = 400.0},
            };
        }

    }

    //public class SortNameProduct : IComparer<Product>
    //{
    //    public int Compare(Product x, Product y)
    //    {
    //        return String.Compare(x.Name, y.Name);
    //    }
    //}






    //    public class Staffs : IEnumerable
    //    {

    //        public Staffs(Employee[] employees)
    //        {
    //            employeeEnumerator = new EmployeeEnumerator(employees);
    //        }

    //        private readonly EmployeeEnumerator employeeEnumerator;
    //        public IEnumerator GetEnumerator()
    //        {
    //            return employeeEnumerator;
    //        }
    //    }

    //    public class EmployeeEnumerator : IEnumerator
    //    {

    //        public EmployeeEnumerator(Employee[] employees)
    //        {
    //            this.EmployeeList = employees;
    //        }

    //        private int counter = -1;
    //        public Employee[] EmployeeList { get; set; }
    //        public object Current => EmployeeList[counter];

    //        public bool MoveNext()
    //        {
    //            counter++;

    //            if (counter > EmployeeList.Length -1)
    //                return false;

    //            return true;
    //        }

    //        public void Reset()
    //        {
    //        }
    //    }

    //    public class Employee
    //    {
    //        public int Level { get; set; }
    //        public string Title { get; set; }
    //        public string FullName { get; set; }

    //        public override string ToString()
    //        {
    //            return $"{this.FullName}";
    //        }
    //    }
}
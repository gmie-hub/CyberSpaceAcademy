using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSpaceAcademy
{
    public class Product : IOrder
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Order { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Quantity: {Quantity}";
        }
    }

    public class SortProduct<T> : IComparer<T>  where T : IOrder 
    {
        public int Compare(T x, T y)
        {

            if(x.Order < y.Order)
                return 1;
            if (x.Order > y.Order)
                return -1;
            else
                return 0;

        }

    }

    public interface IOrder
    {
        int Order { get; set; }
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
using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class Employee
    {

        private string name, alias;
        private decimal salary = 3000.00m;

        public Employee(string name, string alias)
        {
            this.name = name;
            this.alias = alias;
        }

        public void PrintEmployee()
        {

            Console.WriteLine("Name: {0} \nAlias: {1}", name, alias);
            Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
        }

        public decimal Salary
        {
            get { return salary; }
        }
    }

    public class Tax
    {

        public static decimal CalcTax(Employee e)
        {
            return 0.08m * e.Salary;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Employee e = new Employee("Jimi", "Gmie");
            e.PrintEmployee();
        }
    }
}

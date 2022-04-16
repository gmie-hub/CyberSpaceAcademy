using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class User
    {

        public string Name;
        private string Location;

        public User()
        {
            Console.WriteLine("Base class constructor");
        }

        public void GetUserInfo(string loc)
        {
            Location = loc;
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
        }
    }

    public class Details : User
    {

        public int Age;

        public Details()
        {
            Console.WriteLine("Derived class constructor");
        }

        public void GetDetails()
        {

            Console.WriteLine("Age: {0}", Age);
        }
    }

    public class Program
    {

        public static void Main()
        {

            Details d = new Details();
            d.Name = "Olaosebikan OLuwafolajimi";
            d.Age = 23;
            d.GetUserInfo("Lagos");
            d.GetDetails();
        }
    }
}

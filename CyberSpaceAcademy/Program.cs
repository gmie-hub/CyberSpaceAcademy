using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    interface IName
    {
        public void GetName(string x);
    }

    interface ILocation
    {
        public void GetLocation(string x);
    }

    interface IAge
    {
        public void GetAge(int x);
    }

    public class User : IName, ILocation, IAge
    {
        public void GetName(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }
        public void GetLocation(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }
        public void GetAge(int a)
        {
            Console.WriteLine("Age: {0}", a);
        }
    }
    public class Program
    {
        public static void Main()
        {
            User u = new User();
            u.GetName("Jimi");
            u.GetLocation("Lagos");
            u.GetAge(23);
        }
    }
}

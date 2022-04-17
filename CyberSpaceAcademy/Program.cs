using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    abstract public class Info
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to tutlane");
        }
        public int age = 32;
        abstract public void GetDetails(string x, string y);
    }

    public class User : Info
    {
        public override void GetDetails(string a, string b)
        {
            Welcome();  
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", age);
        }
    }

    public class Program
    {
        public static void Main()
        {
            User u = new User();
            Console.WriteLine("****Abstract Class Example****");
            u.GetDetails("Jimi", "Lagos");
        }
    }
}

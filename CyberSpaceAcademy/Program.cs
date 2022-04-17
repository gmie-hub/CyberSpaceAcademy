using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    abstract public class Info
    {
        abstract public void GetDetails(string x, string y, int z);
    }

    public class User : Info
    {
        public override void GetDetails(string a, string b, int c)
        {
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
            Console.WriteLine("Age: {0}", c);
        }
    }

    public class Program
    {
        public static void Main()
        {
            User u = new User();
            Console.WriteLine("****Abstract Class Example****");
            u.GetDetails("Jimi", "Lagos", 30);
        }
    }
}

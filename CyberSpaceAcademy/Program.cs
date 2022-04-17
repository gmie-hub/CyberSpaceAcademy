using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class BClass
    {
        public BClass()
        {
            Console.WriteLine("Welcome To Tutlane");
        }

        public BClass(string a, string b)
        {
            Console.WriteLine("Name: {0}", a);
            Console.WriteLine("Location: {0}", b);
        }
    }

    public class DClass : BClass
    {
        public DClass() : base()
        {

        }

        public DClass(string x, string y) : base(x, y)
        {

        }
    }

    public class Program
    {

        public static void Main()
        {

            DClass d = new();    
            DClass d1 = new("Jimi", "Lagos");
        }
    }
}

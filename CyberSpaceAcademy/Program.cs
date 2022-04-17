using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class User
    {
        public string name = "Jimi";
        public string location = "Lagos";
        public int age = 20;

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }

    public class Details : User
    {
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Age: {0}", age);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Details d = new Details();
            d.GetInfo();
        }
    }
}

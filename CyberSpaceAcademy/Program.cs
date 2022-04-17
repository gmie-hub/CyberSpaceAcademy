using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public  class BClass
    {

        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# Tutorial");
        }
    }

    public class DClass : BClass
    {

        public override void GetInfo()
        {
            Console.WriteLine("Welcome To Tutlane");
        }
    }

    public class Program
    {

        public static void Main()
        {
            DClass d = new DClass();
            d.GetInfo();
            
            BClass b = new BClass();
            b.GetInfo();
        }
    }
}

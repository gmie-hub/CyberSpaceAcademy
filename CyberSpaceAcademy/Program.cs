using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class BClass 
    {

        public virtual string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("Learn C# Tuturial");
        }
    }

    public class DClass : BClass
    {
        private string name;

        public override string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "No Value";
                }
            }
        }

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

            d.Name = String.Empty;
            Console.WriteLine(d.Name);
        }
    }
}

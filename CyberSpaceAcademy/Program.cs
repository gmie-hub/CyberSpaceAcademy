using System;

namespace CyberSpaceAcademy
{

    public class Geeks
    {
       
        static Geeks()
        {
            Console.WriteLine("Static Constructor");
        }

        public Geeks(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        public string geeks_details(string name, int id)
        {
            return "Name: " + name + "Id: " + id;
        }
        public static void Main()
        {

            Geeks obj = new Geeks(1);
            Console.WriteLine(obj.geeks_details("GFG ", 1));

            Geeks obj1 = new Geeks(2);
            Console.WriteLine(obj1.geeks_details("GeeksforGeeks ", 2));
        }
    }
}

using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{
    public class GenericClass<T>
    {
        public T msg;
        public void GenericMethod(T name, T location)
        {
            Console.WriteLine("{0}", msg);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Location: {0}", location);
        }
    }    
    public class Program
    {
        public static void Main()
        {
            GenericClass<string> gclass = new GenericClass<string>();
            gclass.msg = "Welcome to Tutlane";
            gclass.GenericMethod("Jimi", "Lagos");
        }
    }
}

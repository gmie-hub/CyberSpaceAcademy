using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{
    public class SampleClass
    {
        public void GMethod<T>(T a, T b)
        {
            Console.WriteLine("Param1: {0}", a);
            Console.WriteLine("Param: {0}", b);
        }
    }    
    public class Program
    {
        public static void Main()
        {
            SampleClass s = new SampleClass();
            s.GMethod<int>(1, 2);
            s.GMethod("Jimi", "Lagos");
            Console.ReadLine();
        }
    }
}

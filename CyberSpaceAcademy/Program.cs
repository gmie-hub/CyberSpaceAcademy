using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class Calculate
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("a + b = {0}", a + b);
        }

        public void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }

    public class Program
    {

        public static void Main()
        {

            Calculate calc = new Calculate();
            calc.AddNumbers(1, 2);
            calc.AddNumbers(1, 2, 3);
        }
    }
}

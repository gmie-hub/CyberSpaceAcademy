using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{
    public delegate void SampleDelegate(int a, int b);
    public class MathOperation
    {

        public void Add(int a, int b)
        {
            Console.WriteLine("Add result: {0}", a + b);
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtract result: {0}", x - y);
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply result {0}", x * y);
        }
    }
    public class Program
    {
        public static void Main()
        {
            MathOperation m = new MathOperation();
            SampleDelegate dgt = m.Add;
            dgt += m.Subtract;
            dgt += m.Multiply;
            dgt(10, 9);
        }
    }
}

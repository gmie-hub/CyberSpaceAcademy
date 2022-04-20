using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{
    public delegate T SampleDelegate<T>(T a, T b);
    public class MathOperation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }    
    public class Program
    {
        public static void Main()
        {
            MathOperation m = new MathOperation();
            SampleDelegate<int> dlgt = new SampleDelegate<int>(m.Add);
            Console.WriteLine("Addition result: " + dlgt(10, 9));
            dlgt = m.Subtract;
            Console.WriteLine("Subtraction Result:" + dlgt(10, 9));
        }
    }
}

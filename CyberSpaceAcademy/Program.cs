using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{
   
    public class Program
    {
        public static void Main()
        {
            //peg:
            //string input = Console.ReadLine();
            //Nullable<int> a = int.TryParse(input, out int age) ? age : 0;

            //int i = a.HasValue ? a.Value : 0;

            //Console.WriteLine(i);
            //goto peg;

            //string input = "Hi";
            //string output = input ?? "String is null";

            //Console.WriteLine(output);

            //Figure o = new Figure() {X = 100};
            //Figure o2 = new Figure() {X = 10};
            //Figure o3 = new Figure() {X = 100};
            //Figure o4 = new Figure() {X = 30};
            //Figure plus = o + (o2 + o3) - o4;
            //Console.WriteLine(plus.X);

            //bool isEqual = o == o2;
            //Console.WriteLine(isEqual);

            //bool isEqual2 = o2 >= o3;
            //Console.WriteLine(isEqual2);

            int[] array = new int[5] {1, 2, 3, 4, 5};
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}

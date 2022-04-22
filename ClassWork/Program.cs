using System;

namespace ClassWork
{
    public class Program
    {
        static void Main()
        {
            //Console.WriteLine("This application convert dollar, pound and euro to naira");

            //Console.WriteLine("Enter currency");
            //var currency = Console.ReadLine().ToUpper().Trim();

            //Console.WriteLine("\nEnter the amount in digit");
            //var amount =Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine(" ");
            //const double toNaira = 580;
            //string d  = "Dollars";
            //string p = "Pounds";
            //string e = "Euros";
            //string dol = "Dollar";
            //string eu = "Euro";
            //string pd = "pounds";

            //switch (currency)
            //{
            //    case "DOLLAR":
            //    case "D":
            //        if (amount <= 1)
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, dol);
            //        else
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, d);
            //        break;

            //    case "POUND":
            //    case "P":
            //        if(amount <= 1)
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, pd);
            //        else
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, p);
            //        break;

            //    case "EURO":
            //    case "E":
            //        if( amount <= 1)
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, eu);
            //            Console.WriteLine(amount + "{0}" + " = " + amount * toNaira, e);
            //        break;

            //    default : Console.WriteLine("Invalid Input");
            //        break;

            //}


            int[][] jarray = new int[3][];
            jarray[0] = new int[5] { 1, 2, 3, 4, 5};
            jarray[1] = new int[3] { 10, 20, 30 };
            jarray[2] = new int[] {12, 50, 60, 70, 32};

            Console.WriteLine("***Jagged array with multi-dimensional element***\n");
            for (int i = 0; i < jarray.Length; i++)
            {
                Console.Write("Element[{0}]: ", i);
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write("{0}{1}", jarray[i][j], j == (jarray[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }

            int[][,] jarray2 = new int[2][,];
            jarray2[0] = new int[2, 2]
            {
                {15, 24},
                {43, 54}
            };
            jarray2[1] = new int[,]
            {
                {11, 12},
                {13, 14},
                {25, 26}
            };
            Console.WriteLine("\nJagged array with multi-dimensional element\n");

            for(int i = 0; i < jarray2.Length; i++)
            {
                Console.Write("Element[{0}]: ", i);
                for (int j = 0; j < jarray2[i].GetLength(0); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < jarray2[i].GetLength(1); k++)
                    {
                        Console.Write("{0}{1}", jarray2[i][j, k], k == (jarray2[i].GetLength(1) - 1) ? "" : " ");
                    }
                    Console.Write("{0}{1}", "}", j < jarray2.GetLength(0) ? ", " : "");
                }
                Console.WriteLine();
            }
        }

    }
}

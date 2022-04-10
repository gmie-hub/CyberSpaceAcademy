using System;

namespace ClassLearning
{ 
  
    public class Program
    {
        static void Main()
        {
            Point[] points = new Point[20];
            int i = 0;
             
            do
            {
                points[i] = new Point() { X = i * 2, Y = i * 3 };
                Console.WriteLine(points[i]);
                i++;
            }

            while (i < points.Length);
            //Point[] points = new Point[20];

            //for (int i = 0; i < points.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        continue;
            //    }
            //    points[i] = new Point() { X = i * 2, Y = i * 3 };
            //}
            
            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i]);
            //}
        }

    }

    public class Point
    {

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X = {X}, Y = {Y}";
        }
    }
}

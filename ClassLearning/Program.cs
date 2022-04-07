using System;

namespace ClassLearning
{ 
  
    public class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person();
            //person.Name = "Jimi";
            //person.Introduce("MIke");
            //   int i = 0;
            //bisi:;

            //    Console.WriteLine(++i);

            //    if (i <= 5)
            //    {
            //        goto bisi;

            //    for(int i = 100; i >= 1; i -= 2)

            //{
            //    Console.WriteLine(i);
            //}

            int counter = 101;

            while (--counter > 1)
            {
                if (counter % 2 == 0)
                {

                    Console.Write(counter == 2 ? $"{counter}" : $"{counter}, ");
                }
               
            }

        }
    }
}

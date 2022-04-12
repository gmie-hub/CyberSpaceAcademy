using System;

namespace CyberSpaceAcademy
{

    public class Geeks
    {
       
        private Geeks()
        {

        }

        public static int counter_geeks;
        
        public static int geeks_counter()
        {
             return counter_geeks++; 
        }
        public static void Main()
        {

            Geeks.counter_geeks = 99;
            Geeks.geeks_counter();
            do
            {
                
                Console.WriteLine(Geeks.counter_geeks);
                counter_geeks++;
            }

            while (counter_geeks <= 105);
           
        }
    }
}

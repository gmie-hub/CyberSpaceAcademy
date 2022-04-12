using System;

namespace CyberSpaceAcademy
{

    public class Geeks
    {
        private Geeks()
        {

        }

        public static int count_geeks;

        public static int geeks_count()
        {
            return ++count_geeks;
        }
        static void Main()
        {

            Geeks.count_geeks = 99;
            Geeks.geeks_count(); 
            Console.WriteLine(Geeks.count_geeks);

            Geeks.geeks_count();
            Console.WriteLine(Geeks.count_geeks);
        }
    }
}

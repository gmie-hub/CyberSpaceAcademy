using System;

namespace CyberSpaceAcademy
{
    public class GFG
    {

        public string name;
        public string subject;

        public void reader(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My favourite subject is " + subject);
        }
    }

    public class GeeksforGeeks : GFG
    {

        public GeeksforGeeks()
        {

            Console.WriteLine("GeeksforGeeks");
        }
    }

    public class Sumo
    {
        public static void Main()
        {

            GeeksforGeeks geeks = new GeeksforGeeks();
            geeks.reader("Jimi", "C#");
        }
    }

    
}

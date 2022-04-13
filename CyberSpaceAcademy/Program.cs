using System;

namespace CyberSpaceAcademy
{

    public class EncapDemo
    {

        private string studentName;
        private int studentAge;

        public string Name
        {
            get
            {
                return studentName;
            }

            set
            {
                studentName = value;
            }
        }

        public int Age
        {

            get
            {
                return studentAge;
            }

            set
            {
                studentAge = value;
            }
        }
    }

    public class Geek
    {

        static void Main()
        {

            EncapDemo demo = new EncapDemo();
            demo.Name = "Jimi";
            demo.Age = 18;

            Console.WriteLine("Name: " + demo.Name);
            Console.WriteLine("Age: " + demo.Age);
        }
    }
}

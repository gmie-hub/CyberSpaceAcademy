using System;

namespace CyberSpaceAcademy
{

    public class Program
    {
        public static void Main()
        {

            string topic;
            string category;

            topic = "Inheritance";

            switch (topic)
            {
                case "Introduction to c#":
                case "Variables":
                case "Data types":

                    category = "Basics";
                    break;

                case "Loops":
                case "If statements":
                case "Jump statements":

                category = "Control flow";
                    break ;

                case "Class & Objects":
                case "Inheritance":
                case "Constructors":

                    category = "OOPs Concepts";
                    break;

                default:
                    category = "Not mentioned";
                    break;
            }
            Console.WriteLine("Category is " + category);
        }
    }

   
}

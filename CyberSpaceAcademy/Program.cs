using System;

namespace CyberSpaceAcademy
{
   public class Dog
    {
        string name;
        string breed;
        int age;
        string color;

        public Dog( string name, string breed, int age, string color)
        {

            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public string GetName()
        {
            return name;
        }

        public string GetBreed()
        {
            return breed;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetColor()
        {
            return color;
        }

        public string ToString()
        {
            return ("Hi my name is " + this.GetName() + ".\nMy breed, age and color are " +
                this.GetBreed() + ", " + this.GetAge() + " and " + this.GetColor());
        }
    }
    public class Program
    {
        public static void Main()
        {
            Dog tuffy = new Dog("tuffy", "papillion", 5, "white");
            Console.WriteLine(tuffy.ToString());
        }
    }
}

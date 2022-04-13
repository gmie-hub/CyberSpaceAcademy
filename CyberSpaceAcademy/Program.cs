using System;

namespace CyberSpaceAcademy
{
    public class Program
    {

        static void Main()
        {
            People p = new People();

            Person person = p[1];
            Console.WriteLine(person.Name);
        }
    }
    public class Person
    {

        public string Name { get; set; }
    }

    public class People
    {

        private readonly Person[] names =
        {

            new Person{Name = "Bill Gates"},
            new Person{Name = "Prolifik Lexzy"},
            new Person{Name = "Scott Aniel"},
            new Person{Name = "Matt Redman"}
        };

        public Person this[int position]
        {
            get
            {
                return names[position];
            }
        }
    }

}

using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public interface Animal
    {
        string Name { get; set; }
        int Age { get; set; }
        AnimalTypes Type { get; set; }



        //public static void Main()
        //{
        //    Animal animal = new Animal() { Name = "Goat", Age = 30};
        //    Console.WriteLine(animal.Name);
        //    Console.WriteLine(animal.Age);
        //}
        //public static void Main()
        //{
        //    int[] num = new[] { 1, 2, 3, 4, 5 };
        //    PrintNumbers(num);

        //}

        //public static void PrintNumbers(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}

        //private string _name;
        //private int _age;
        //    public Animal()
        //    {
        //        Console.WriteLine("Constructor called");
        //    }

        //    public string Name 
        //    { 
        //        get 
        //        { 
        //            return _name; 
        //        }
        //        set
        //        {
        //            _name = value;
        //        }
        //    }

        //    public int Age
        //    {
        //        get
        //        {
        //            return _age;
        //        }
        //        set 
        //        { 
        //            _age = value; 
        //        }
        //    }
        //}


    }
}

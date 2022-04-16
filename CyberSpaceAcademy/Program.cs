using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class User
    {

        public string name, location;
        public long marks;

        public User(string name, string location)
        {
            this.name = name;
            this.location = location;
        }

        public void GetUserDetails()
        {
            Console.WriteLine("Name: {0} \nLocation: {1}", name, location);
           
            Console.WriteLine("Marks: {0}", Exams.GetPercentage(this));
        }
    }

    public class Exams
    {
        public static double GetPercentage(User u)
        {
            return ((double)470 / 600) * 100;
           
        }
    }

    public class program
    {

        public static void Main()
        {

            User u = new User("Olaosebikan Oluwafolajimi", "Lagos");
            u.GetUserDetails();
            Console.WriteLine("\npress enter key to exit");
            Console.ReadLine(); 
        }
    }
}

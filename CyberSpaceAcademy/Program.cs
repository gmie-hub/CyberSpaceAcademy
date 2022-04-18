using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    interface IUser
    {
        public void GetDetails(string x);
    }
    public class User : IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }
    }
    public class User1 : IUser
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }
    }
    public class Program
    {
        public static void Main()
        {
            User u = new User();
            u.GetDetails("Jimi");

            User1 u1 = new User1();
            u1.GetDetails("Lagos");
           
        }
    }
}

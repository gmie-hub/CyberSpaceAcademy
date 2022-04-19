using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{
    public class Maths
    {

        public delegate void SampleDelegate();
        public event SampleDelegate SampleEvent;
        public void Add(int a, int b)
        {
            if (SampleEvent != null)
            {
                SampleEvent();
                Console.WriteLine("Add result: {0}", a + b);
            }
            else
            {
                Console.WriteLine("Not subscribed to event");
            }
        }

        public void Subtract(int x, int y)
        {
            if(SampleEvent != null)
            {
                SampleEvent();
                Console.WriteLine("subtract result: {0}", x - y);
            }
            else
            {
                Console.WriteLine("Not subscribed to event");
            }
        }
    }
    public class Operations
    {

        Maths m;
        public int a { get; set; }
        public int b { get; set; }
        public Operations(int x, int y)
        {
            m = new Maths();
            m.SampleEvent += SampleEventHandler;
            a = x;
            b = y;
        }

        public void SampleEventHandler()
        {
            Console.WriteLine("SampleEvent Handler: Calling Method");
        }

        public void AddOperation()
        {
            m.Add(a, b);
        }

        public void SubOperation()
        {
            m.Subtract(a, b);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("****Event Example****");
            Operations op = new Operations(10, 9);
            op.AddOperation();
            op.SubOperation();
        }
    }
}

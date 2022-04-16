using ClassLibrary.recap;
using System;

namespace CyberSpaceAcademy
{

    public class Laptop
    {

        private string brand;
        private string model;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public void LaptopDetails()
        {
            Console.WriteLine("Brand: {0}", brand);
            Console.WriteLine("Model: {0}", model);
        }

        public void LaptopKeyboard()
        {
            Console.WriteLine("Type using keyboard");
        }

        private void MotherBoardInfo()
        {
            Console.WriteLine("Motherboard inforrmation");
        }

        private void InternalProcesspr()
        {
            Console.WriteLine("Processor information");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Laptop l = new();
            l.Brand = "Hp";
            l.Model = "Elite Book folio 9470m";
            l.LaptopDetails();
            l.LaptopKeyboard();
        }
    }
}

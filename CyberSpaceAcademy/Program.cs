using System;

namespace CyberSpaceAcademy
{
   
    public class Program
    {
        public static void Main()
        {
            ShoppingBag<Bag> shoppingBag = new ShoppingBag<Bag>();
            shoppingBag.AddItem(new Bag());
            var counter = 0;
          
        }
    }

    public class ShoppingBag<T> where T : Bag
    {
        private T[] _items = new T[10];
        private int _index = 0;
        public void AddItem(T item)
        {

            _items[_index++] = item;
        }
        public T Item { get; set; }

        private T item;
        public T GetItem(int index)
        {
            return item;
        }
        public void SetItem(T Bag)
        {
            item = Bag;
        }
    }

    public class Bag
    {
        public Bag()
        {

           
        }
    }
}

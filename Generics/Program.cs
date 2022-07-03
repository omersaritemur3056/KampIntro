using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            sehirler.Add("İstanbul");
            Console.WriteLine(sehirler.Count);

            Console.WriteLine("------------------------------");

            MyList<string> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T> //Generic bir class oldu bu
    {
        T[] _array;

        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;
        }

        //propfull ile şu yapı oluşur. Bu yapı .Count metotundaki get kısmını gösteriyoruz
        private int _count;

        public int Count
        {
            //get { return _count; }
            //set { _count = value; }

            get { return _array.Length; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskList
{
    internal class IntArrayList
    {
        int[] _arr;
        public int Count { get; private set; }
        public int Capacity { get; set; }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public IntArrayList()
        {
            Capacity = 5;
            _arr = new int[Capacity];
        }
        public int this[int num]
        {
            get { return _arr[Count]; }
            set { _arr[Count] = value; }
        }
        public void Add(int a)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Capacity + Count);
            }
            _arr[Count] = a;
            Count++;
        }
        public void IndexOf(int value)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i] == value)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        public void GetInfo()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public override string ToString()
        {
              string a = "{";
            for (int i = 0; i < Count; i++)
            {
                if (i > 0)
                {
                    a =a + " , ";
                }
                a += _arr[i].ToString();
            }
            a += "}";
            return a;
        }
    }
}


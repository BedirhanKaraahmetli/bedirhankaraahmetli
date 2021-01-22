using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Bedirhan");
            names.Add("Engin");
            names.Add("Serkan");
            names.Add("Ali Emir");
            Console.WriteLine(names.Count);
        }
    }

    class MyDictionary<T>
    {
        T[] names;

        public MyDictionary()
        {
            names = new T[0];
        }
        public void Add(T name)
        {
            T[] tempArray = names;
            names = new T[names.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                names[i] = tempArray[i];
            }

            names[names.Length - 1] = name;
            
        }
        public int Count
        {
            get { return names.Length; }
        }

    }
}

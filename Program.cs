using System;

using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> isimler = new MyList<string>();
            //isimler.Add("engin");
            //isimler.Add("kerem");


            //Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //dictionary.Add(1, "kerem");
            //dictionary.Add(2, "kerem");
            //dictionary.Add(3, "kerem");

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item);
            //}

            //MyDictionary<int, int> myDictionary = new MyDictionary<int, int>();

            //myDictionary.Add(1, 2);
            //myDictionary.Add(3, 4);

            //Console.WriteLine(myDictionary);

            MyDictionary<int, int> myDictionary = new MyDictionary<int, int>();
            
            myDictionary.Add(1, 2);
            myDictionary.Add(3, 4);

            myDictionary.WriteLine();
           

        }
    }
}

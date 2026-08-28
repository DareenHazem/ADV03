using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ADV03
{
    internal class Print
    {
        public static void PrintList<T>(String Label,List<T> list)
        {
            if(list is not null && list.Count > 0 && Label is not null)
            {
                Console.Write($"{Label}: "); 
                foreach (T item in list)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintDictionary<T1,T2>(String Label, SortedDictionary<T1,T2> dict)
        {
            if (dict is not null && dict.Count > 0 && Label is not null)
            {
                Console.Write($"{Label}: ");
                foreach(KeyValuePair<T1,T2> item in dict)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }
}

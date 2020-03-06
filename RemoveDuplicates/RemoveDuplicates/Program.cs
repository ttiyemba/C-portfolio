using System;
using System.Collections.Generic;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void removeDuplicates(string setence)
        {

            string[] split = setence.Split(' ', '\t');

            HashSet<string> hash = new HashSet<string>();

            for (int i = 0; i < split.Length; i++)
            {
                hash.Add(split[i]);


            }

            foreach (var e in hash)
            {
                Console.WriteLine(e);
            }






            
        }

    }
}

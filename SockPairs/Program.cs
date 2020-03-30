using System;
using System.Collections.Generic;



namespace SockPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Socks("aabccc"));

        }

        public static int Socks(string pairs)
        {

            int count = 0;


            HashSet<char> dist = new HashSet<char>();

            for (int i = 0; i < pairs.Length; i++)
            {

                if (!dist.Contains(pairs[i]))
                {
                    dist.Add(pairs[i]);
                }
                else
                {
                    count++;
                    dist.Remove(pairs[i]);
                }




            }
            return count;
        }
    }
}







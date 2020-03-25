using System;
using System.Linq;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(IsIsogram("hello"));

            
        }

        public static bool IsIsogram(string word){
        return word.Where(char.IsLetter).GroupBy(char.ToLower).All(t => t.Count() ==1)
        }

    }
}

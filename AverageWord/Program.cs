using System;
using System.Text.RegularExpressions;

namespace AverageWord
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine(AverageWordLength("Dude, this is so awesome!"));
           
        }

        static double AverageWordLength(string s ){

            string[] spit = s.Split(" ");
            double Length = (double)spit.Length;
            string formatted = Regex.Replace(s,@"[^0-9a-zA-Z:]+","");
            double totalwordcount = (double)formatted.Length;
            double result =  totalwordcount/Length;
            

            
           
            
            return result;
        }
    }
}

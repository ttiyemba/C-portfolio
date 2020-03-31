using System;

namespace Symmetrical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.Console.WriteLine(SymmetricalNumbers(12567));
        }


        static bool SymmetricalNumbers(int num){

            int orig = num;

            int pop ;
            int reverse = 0;

            while(num !=0){

                pop = num%10;

                num /= 10;

                reverse = (reverse * 10 ) +  pop;
            }

            

            return reverse == orig;
        }
    }
}

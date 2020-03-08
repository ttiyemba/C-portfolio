using System;

namespace Split_a_String_in_Balanced_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(balancedString("RLLLLRRRLR"));
        }

        public static int balancedString(string s)
        {
            int balancedCount = 0;
            int count = 0;

            for(int i = 0; i<s.Length; i++)
            {
                char current = s[i];

                if(current == 'L')
                {
                    count++;
                }else if(current == 'R')
                {
                    count--;
                }

                if(count == 0)
                {
                    balancedCount++;
                }

                
            }
            return balancedCount;
        }
    }
}

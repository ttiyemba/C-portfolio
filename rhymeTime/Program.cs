using System;
using System.Text.RegularExpressions;

namespace rhymeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(DoesRyhme("Sam I am!", "Green eggs and ham."));
        }


        static bool DoesRyhme(string a, string b )

        {
            string aFormatted = Regex.Replace(a,@"[^0-9a-zA-Z:,]+","");
            string bFormatted = Regex.Replace(b,@"[^0-9a-zA-Z:,]+","");

            bool flag = false;
            int count = 0;
            //init an empty array called s1
            char[] s1 = {};
            //init an empty array called s2
            char[] s2 = {};
            //getting the length to use for my first loop
            int maxLength = Math.Max(aFormatted.Length,bFormatted.Length);

            for (int i = 0; i < maxLength; i++)
            {
                //using regex to replace all special characters
                s1 = aFormatted.Replace(" ","").ToLower().ToCharArray();
                s2 = bFormatted.Replace(" ","").ToLower().ToCharArray();
                
                //s1 = a.ToLower().Replace(" ", "").Split(',');
                //s2 = b.ToLower().Replace(" ", "").Split(',');
            }

            //getting the length to use for my second loop 
            int Length = Math.Max(s1.Length, s2.Length);

            

            for (int i = 0; i < Length; i++)
            {
                //checking the last character of the two arrays and incrementing the count variable
                if (s1[s1.Length - 1] ==  s2[s2.Length - 1])
                {
                    count++;
                }
            }

            //if  count is bigger than 3 I consider it to rhyme

            if(count >=2){

                //settinging the flag to true
                flag = true;

            }



            //returning the flag boolean
            foreach (var item in s2)
            {
                System.Console.WriteLine(item);
            }

            return flag;
        }
    }
}

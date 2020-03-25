using System;

namespace isIsogram2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine( isIsogram2("helo"));
        }

        public static bool isIsogram2(string word){

            String temp = "";
            Boolean iso = true;

            for(int i = 0; i < word.Length; i++){
                if(!temp.Contains(word[i])){
                    temp += word[i];
                }
                else{
                    iso = false;
                }
            }
            return iso;
        }
    }
}

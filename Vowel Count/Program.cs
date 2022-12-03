using System;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            
            Console.WriteLine(Vowel_Count(str));
        }
        static public int Vowel_Count(string str)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o','u' };
            int coincidences = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int b = 0; b < vowels.Length; b++)
                {
                    if (str[i]==vowels[b])
                    {
                        coincidences++;
                    }
                }
            }
            return coincidences;
        }
    }
}

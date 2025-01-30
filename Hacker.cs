using System.Diagnostics.Tracing;

namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anagram...
            string word1 = "lemon";
            char[] a = [];
            a = word1.ToCharArray();

            string word2 = "melon";
            char[] b = [];
            b = word2.ToCharArray();
            int c =0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j] )
                    {
                        c++; 
                        break;
                    }
                    
                }
                continue;
                

            }
            if (c == a.Length)
            {
                Console.WriteLine("Word is an Anagram");
            }
            else
            {
                Console.WriteLine("Word is not an Anagram");
            }
        }
    }
}

using System.Diagnostics.Tracing;

namespace HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Three sum...
            int[]nums = { -1, 0, 1, 2, -1, -4};

            for (int i = 0; i < nums.Length; i++)  
            {
                for (int j = 0; j < nums.Length; j++) 
                {
                    for (int k = 0; k < nums.Length; k++) 
                    {
                        if (nums[i] + nums[j] + nums[k] == 0 && i != j && j != k && i != k)
                        {
                            Console.WriteLine("[" + nums[i] + " " + nums[j] + " " + nums[k] + "]");

                        }
                        
                        break; 
                    }
                   
                }
                 
            }






            //Anagram...
            string word1 = "lemon";
            char[] a = [];
            a = word1.ToCharArray();

            string word2 = "melon";
            char[] b = [];
            b = word2.ToCharArray();
            int c = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
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

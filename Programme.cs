namespace Exeercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,7,11,13,15 };
            int target = 20;

            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    int n = target;
                    if (i!=j && nums[i] + nums[j] == n )
                    {
                        Console.WriteLine("[" + i + "]" + "," + "[" + j + "]");
                    }
                    

                }
                
            }



            Console.Write("Enter a Word: ");
            string w1 = Convert.ToString(Console.ReadLine());

            char[] w2 = w1.ToCharArray();


            bool isPalindrome = false;

            for (int i = 0; i <= w2.Length; i++)
            {

                int n = 1;
                if (w2[i] == w2[w2.Length - n])
                {
                    n++;
                    Console.WriteLine("This word is a palindrome");

                    break;

                }
                else if (w2[i] != w2[w2.Length - n])
                {
                    Console.WriteLine("This word is not a palindrome");
                    break;
                }


            }




            Console.Write("Enter a number1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            if (n1 != 0 && n2 != 0)
            {


                int n;
                for (int i = 1; i < n1; i++)
                {
                    if (n1 % i == 0 && n2 % i == 0 && i != 1)
                    {
                        n = i;

                        Console.WriteLine("The LCM of " + n1 + " and " + n2 + " is " + n);
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }


        }
    }
}

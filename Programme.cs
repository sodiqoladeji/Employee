﻿using System.Diagnostics;

namespace Exeercise3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Time Conversion...
            string s = "11:05:45AM";
            char[] t = s.ToCharArray();
            int h1 = Convert.ToInt32(t[0]) - 48;
            int h2 = Convert.ToInt32(t[1]) - 48;
            char[] t1 = new char[8];
            if (t[8] == 'P')
            {
                
                if ((h1 == 0 && h2 <= 9) || (h1 ==1 && h2 <=2))
                {
                    h1 = h1 + 1;
                    h2 = h2 + 2;
                    char c1 = Convert.ToChar(h1 + 48);
                    char c2 = Convert.ToChar(h2 + 48);
                    t[0] = c1;
                    t[1] = c2;

                }

                if (h1 == 2 && h2 == 4)
                {
                    t[0] = '0';
                    t[1] = '0';
                }
                
                
                for (int i = 0; i < 8; i++)
                {
                    t1[i] = t[i];
                }
                Console.WriteLine(t1);
            }
            else if (t[8] == 'A')
            {
                
                for (int i = 0; i < 8; i++)
                {
                    t1[i] = t[i];
                }
                Console.WriteLine(t1);
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }






            //Plus Minus...
            int[] arr = { -1, -2, 0, 3, 4, 5 };
            double pos = 0;
            double neg = 0;
            double zer = 0;
            int n = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }
                else if (arr[i] == 0)
                {
                    zer++;
                }


            }

            Console.WriteLine((pos / n));
            Console.WriteLine((neg / n));
            Console.WriteLine((zer / n));



            //Compare the Triplets...
            int[] a = [10, 25, 70];
            int[] b = [15, 9, 40];
            int[] c = [0, 0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i])
                {
                    c[0]++;

                }
                else if (a[i] < b[i])
                {
                    c[1]++;
                }
                else if (a[i] == b[i])
                {

                }


            }
            Console.WriteLine(c[0] + "," + c[1]);




            //Simple Array Sum...
            int[] nums = [6, 7, 5, 3, 4, 9];
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                result = result + nums[i];



            }
            Console.WriteLine(result);




            int[] num = { 2, 7, 11, 13, 15 };
            int target = 20;


            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    int na = target;
                    if (i != j && num[i] + num[j] == na)
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

                int ni = 1;
                if (w2[i] == w2[w2.Length - ni])
                {
                    ni++;
                    Console.WriteLine("This word is a palindrome");

                    break;

                }
                else if (w2[i] != w2[w2.Length - ni])
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


                int nu;
                for (int i = 1; i < n1; i++)
                {
                    if (n1 % i == 0 && n2 % i == 0 && i != 1)
                    {
                        nu = i;

                        Console.WriteLine("The LCM of " + n1 + " and " + n2 + " is " + nu);
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

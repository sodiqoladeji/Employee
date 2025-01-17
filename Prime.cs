namespace Exercise2
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            //Prime numbers between 1 and 100
            int primenumber;
            int divisor;


            for (primenumber = 2; primenumber <= 100; primenumber++)
            {
                int number = 2;

                for (divisor = 2; divisor <= primenumber / number; divisor++)
                {
                    if (primenumber % 2 != 0 && primenumber % number != 0 && primenumber % divisor != 0)
                    {

                        Console.WriteLine(primenumber);
                        break;

                    }

                }



            }


            //Factorial of a number...

            int f;
            int n;
            int result = 1;


            while (true)
            {
                Console.WriteLine("Enter a number");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                else
                {
                    result = 1; 
                    for (f = 1; f <= n; f++)
                    {
                        result = result * f;
                    }
                    Console.WriteLine(result);
                }
            }

        }

    }


}

   



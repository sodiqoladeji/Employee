namespace Exeercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());


            if (n1!=0 && n2 !=0)
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

namespace SecondProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee01 = new Employee(01, "FullTimeEmployee", 2800, 198);
            var employee02 = new Employee(02, "Contractor", 5000, 3, 1700);
            var employee03 = new Employee(03, "PartTimeEmployee", 15, 65, 82);

            Console.WriteLine(employee01.Pay());
            Console.WriteLine(employee02.Pay());
            Console.WriteLine(employee03.Pay());
            
            Console.ReadLine();
        }
    }
}

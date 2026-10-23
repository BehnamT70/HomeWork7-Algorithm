namespace QuestionTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number : ");
            int n = int.Parse(Console.ReadLine()!);

            if (n < 2)
            {
                Console.WriteLine("It is not a Prime Number.");
                return;
            }

            if (n == 2)
            {
                Console.WriteLine("It is a Prime Number.");
                return;
            }

            if (n % 2 == 0)
            {
                Console.WriteLine("It is not a Prime Number.");
                return;
            }

            for (int i = 3; i <= n / i; i += 2)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("It is not a Prime Number.");
                    return;
                }
            }

            Console.WriteLine("It is a Prime Number.");
            Console.ReadKey();
        }
    }
}

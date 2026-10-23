namespace QuestionOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number : ");
            long n = long.Parse(Console.ReadLine()!);

            int count = 0;

            do
            {
                count++;
                n /= 10;
            }
            while (n > 0);

            Console.WriteLine($"Result : {count}");
            Console.ReadKey();
        }
    }
}

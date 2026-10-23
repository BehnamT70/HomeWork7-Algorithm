namespace QuestionThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number : ");
            long n = long.Parse(Console.ReadLine()!);

            n = Math.Abs(n);
            int sum = 0;

            while (n > 0)
            {
                int digit = (int)(n % 10);
                sum += digit;
                n /= 10;
            }

            Console.WriteLine("Sum of Digits: " + sum);
        }
    }
}

namespace QuestionSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number : ");
            long n = long.Parse(Console.ReadLine()!);

            long reversed = 0;

            while (n != 0)
            {
                long digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }

            Console.WriteLine("Reciprocal Number : " + reversed);
            Console.ReadKey();
        }
    }
}

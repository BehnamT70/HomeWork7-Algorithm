namespace QuestionFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a Number : ");
            long n = long.Parse(Console.ReadLine()!);

            if (n < 0)
            {
                Console.WriteLine("It is not a Palindrome Number");
                return;
            }

            long original = n;
            long reversed = 0;

            while (n > 0)
            {
                long digit = n % 10;
                reversed = reversed * 10 + digit;
                n /= 10;
            }

            if (original == reversed)
            {
                Console.WriteLine("It is a Palindrome Numberت.");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome Number.");
            }
            Console.ReadKey();
        }
    }
}

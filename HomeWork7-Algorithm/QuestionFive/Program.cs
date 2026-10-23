namespace QuestionFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Two Integers: ");

            string[] input = Console.ReadLine()!.Split(
                ' ',
                StringSplitOptions.RemoveEmptyEntries
            );

            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);

            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                long remainder = a % b;
                a = b;
                b = remainder;
            }

            Console.WriteLine("reatest Common Divisor : " + a);
            Console.ReadKey();
        }
    }
}

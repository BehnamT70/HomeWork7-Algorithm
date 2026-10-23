namespace QuestionSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n;

            do
            {
                Console.Write("Please Enter a Non-Negative Integer: ");

                if (!long.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("The Input is Invalid.");
                    n = -1;
                }
                else if (n < 0)
                {
                    Console.WriteLine("A Negative Number is not Acceptable. Please Try Again.");
                }

            } while (n < 0);

            if (n == 0)
            {
                Console.WriteLine("0");
                return;
            }

            string binary = "";

            while (n > 0)
            {
                long remainder = n % 2;
                binary = remainder + binary;
                n /= 2;
            }

            Console.WriteLine("Binary Representation : " + binary);
            Console.ReadKey();
        }
    }
}

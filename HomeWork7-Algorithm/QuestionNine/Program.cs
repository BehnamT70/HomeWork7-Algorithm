namespace QuestionNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of Elements in the Array: ");
            int n = int.Parse(Console.ReadLine()!);

            int[] arr = new int[n];
            HashSet<int> numbers = new HashSet<int>();

            bool hasDuplicate = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please Enter a Number {i + 1} : ");
                arr[i] = int.Parse(Console.ReadLine()!);

                if (numbers.Contains(arr[i]))
                {
                    hasDuplicate = true;
                }
                else
                {
                    numbers.Add(arr[i]);
                }
            }

            if (hasDuplicate)
            {
                Console.WriteLine("There is a Duplicate Value.");
            }
            else
            {
                Console.WriteLine("There are no Duplicate Values.");
            }
            Console.ReadKey();
        }
    }
}

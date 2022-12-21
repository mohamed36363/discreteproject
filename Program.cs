namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber, endNumber;

            Console.Write("Enter Start Number: ");
            startNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter End Number: ");
            endNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("the perfect number between " + startNumber + " and " + endNumber + "is: ");

            for (int i = startNumber; i <= endNumber; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine("\t" + i);
            }
            Console.ReadKey();
        }
    }
}
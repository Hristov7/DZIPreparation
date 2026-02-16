namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            bool flag = true;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j < n; j++)
            for (int i = 0; i <= n/ 2 ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ISPrimeNumber(i) && ISPrimeNumber(j))
                    {
                        int sum = i + j;
                        if (sum == n)
                        {
                            Console.WriteLine($"Намерена двойка: p={i}, q={j}");
                            flag = false;
                        }
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Не съществуват прости числа p и q, такива че n = p + q.");
            }
        }

        public static bool ISPrimeNumber(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i < number; i++)
                if (number % i == 0) return false;

            return true;
        }
    }
}

namespace StrikingContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] averages = new double[n];

            for (int i = 0; i < n; i++)
            {
                int[] rates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x >= 2 && x <= 9).ToArray();
                if(rates.Length == 0)
                {
                    averages[i] = 0;
                }
                else
                {
                    double averageOfRates = rates.Average(x => x);
                    averages[i] = averageOfRates;
                }
            }
            double averageOfAllStrikers = averages.Average(x => x);

            for (int i = 0; i < n; i++)
            {
                int percentage = (int)Math.Floor(averages[i] / averageOfAllStrikers * 100);
                Console.WriteLine($"{i+1}: Средна стойност {averages[i]:f3} в проценти {percentage}%");
            }
        }
    }
}
/*
5
8 6 4 10 0 3 3 4 7 6
4 1 8 0 7 7 4 10 2 6
7 6 5 2 2 10 4 8 1 5
5 10 3 10 10 2 10 6 6 0
0 0 6 1 8 0 7 3 2 2

*/
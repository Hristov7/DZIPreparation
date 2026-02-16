namespace Dzi_AI
{
    public class Program
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            //List<int> numbers = Console.ReadLine().Split('\n',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> numbers = new();
            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            int biggestNumber = numbers.Max();
            int maxA = biggestNumber + 1;
            Console.WriteLine($"Max Element = {maxA}");

            string maxDigit = new string(maxA.ToString().OrderByDescending(a => a).ToArray());
            int maxDigitInt = int.Parse(maxDigit);
            Console.WriteLine($"Max Digit = {maxDigitInt}");
            Console.WriteLine($"Next Max Digit = {++maxDigitInt}");
        }
    }
}
/*
10
5
26
999
5005
13133
20
1504
55080
1199
202

8
26
3
701
20
15
999
100
202

5
25
6
998
998
20

*/
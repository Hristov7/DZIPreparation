namespace Nmerologiq
{
    public class Program
    {
        public static void Main()
        {
            List<int> personalNumbers = new();
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                string[] niz = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int den = int.Parse(niz[0]);
                int mesec = int.Parse(niz[1]);
                int godina = int.Parse(niz[2]);

                int sum = Sum(den, mesec, godina);
                int personalNumber = PersonalNumber(sum);
                while (personalNumber != 11 && personalNumber != 22 && personalNumber > 9)
                {
                    personalNumber = PersonalNumber(personalNumber);
                }
                personalNumbers.Add(personalNumber);
            }
            IGrouping<int, int> group = personalNumbers.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key).FirstOrDefault();

            int mostCommonPersonalNumber = group.Key;
            int occurencies = group.Count();
            Console.WriteLine($"The most common personal number is {mostCommonPersonalNumber} - {occurencies} times.");

            string characteristicQuality = mostCommonPersonalNumber switch
            {
                1 => "Independence",
                2 => "Diplomacy",
                3 => "Natural talent",
                4 => "Organizational skills",
                5 => "Free spirit",
                6 => "Caring and protection",
                7 => "Philosophical skills",
                8 => "Professionals",
                9 => "Tolerance and humanity",
                11 => "Visionaries with ideas",
                22 => "Confidence and intuition",

            };

            Console.WriteLine($"Characteristic quality: {characteristicQuality}");
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int PersonalNumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }
    }
}
/*
10
25-12-1998
01-04-2002
14-03-2000
29-08-1983
23-05-1977
07-06-1998
13-02-1981
05-10-2002
04-08-1994
06-07-2011

*/
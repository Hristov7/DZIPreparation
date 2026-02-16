namespace ITCompany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new(n);
            List<int> longestPeriods = new();
            list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int count = 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1 && count > 1)
                {
                    longestPeriods.Add(count);
                    break;
                }
                if (list[i] <= list[i + 1]) count++;
                else
                {
                    longestPeriods.Add(count);
                    count = 1;
                }
            }

            int longestPeriod = longestPeriods.Max();
            Console.WriteLine($"Longest period with bigger profit is {longestPeriod} mounths.");

            int minProfit = list.Min();
            int indexOfMinProfit = list.IndexOf(minProfit);
            if(indexOfMinProfit == list.Count - 1)
            {
                int previousMonthProfit = list[indexOfMinProfit - 1];
                double percentage = ((double)(previousMonthProfit - minProfit) / previousMonthProfit) * 100;
                Console.WriteLine($"Smaller with {percentage:f2}%");
            }
            else
            {
                int nextMonthProfitIndex = list[minProfit + 1];
                int nextMinProfit = list[nextMonthProfitIndex];
                double percentage = ((double)(nextMinProfit - minProfit) / nextMinProfit) * 100;
                Console.WriteLine($"Smaller with {percentage:f2}%");
            }
        }
    }
}
/*
Управител на IT компания получава доклад за печалбата ѝ за n (n ≤ 100) месеца назад в хиляди лева. Той иска да разбере най-големия брой последователни месеци, през които компанията е имала печалба не по-ниска от тази на предходния месец и с колко процента най-ниската печалба за периода на доклада е по-малка от печалбата за следващия месец.
Създайте приложение, което чете от стандартния вход два реда: от първия ред се чете едно естествено число n – броят на месеците в доклада и от втория ред – n естествени числа, разделени с точно един интервал – печалбите (в хиляди лева). Приложението намира най-големия брой последователни месеци, през които компанията е имала печалба не по-малка от тази на предходния месец и с колко процента най-ниската печалба за периода на доклада е по-малка от печалбата за следващия месец. Ако най-ниската печалба се достига в последния за доклада месец, то тя се сравнява с предпоследния месец от доклада. Гарантирано е, че има само един месец с най-ниска печалба и входните данни се подават коректно.
Приложението извежда на стандартния изход търсената информация в следния формат:
На първия ред се извежда: The longest period with bigger profit is <брой последователни месеци> mounths.
На втория ред се извежда: Smaller with <процент> %.
Дробните числа да се форматират до втория знак след десетичната запетая.
Примерен вход:
10
5 3 4 6 7 1 2 3 4 5
Изход:
Longest period with bigger profit is 5 mounths.
Smaller with 50.00%
*/
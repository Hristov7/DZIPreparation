namespace Chisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new();
            int a = int.Parse(Console.ReadLine()!);
            int b = int.Parse(Console.ReadLine()!);
            for (int i = a; i <= b; i++)
            {
                numbers = Number(i, numbers);
            }
            int mostCommonNumber = numbers.OrderByDescending(x => x.Value).ThenBy(x => x.Key).FirstOrDefault().Key;
            int occurencies = numbers[mostCommonNumber];
            Console.WriteLine($"Digit {mostCommonNumber} - {occurencies}");
        }

        public static Dictionary<int,int> Number(int number, Dictionary<int,int> numbers)
        {
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (!numbers.ContainsKey(digit))
                {
                    numbers[digit] = 1;
                }
                else
                {
                    numbers[digit]++;
                }
            }
            return numbers;
        }
    }
}
/*
Дадени са две цели числа a и b (0 < a < b ). Обхождат се последователно всички цели числа от a до b включително. Коя цифра се среща най-много пъти в записа на числата и колко пъти се среща тя?
Създайте приложение, което въвежда от стандартния вход две цели числа a и b, намира и извежда на стандартния изход цифрата, която се среща най-много пъти в записа на числата от интервала [a, b], както и броя срещания на цифрата. Ако има две и повече цифри, които се срещат максимален брой пъти, да се изведе най-малката от тях.
Числата a и b се въвеждат на отделни редове.
На стандартния изход се извежда търсената информация в следния формат:
Digit <цифра> - <брой срещания> times
Примерен вход:
10
20

2024
3027

454
455

*/
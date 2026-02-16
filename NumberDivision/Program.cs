namespace NumberDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> validNumbers = new();
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine()!);
                if(IsDivisibleByItsNumber(number))
                {
                    validNumbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Something went wrong!");
                }
            }
            Console.WriteLine(string.Join(' ', validNumbers.OrderBy(x=>x)));
        }

        public static bool IsDivisibleByItsNumber(int number)
        {
            try
            {
                while (number > 0)
                {
                    int digit = number % 10;
                    if (number % digit != 0) return false;
                    number /= 10;
                }
            }
            catch (DivideByZeroException db)
            {
                Console.WriteLine($"{db.GetType().Name} => {db.Message}");
                return false;
            }
            return true;
        }
    }
}
/*
 Да се напише метод, който по дадено цяло число да казва дали то се дели на всяка една от цифрите си. Създайте приложение, което по въведено цяло число n и n на брой цели числа, извежда на един ред, разделени с интервал, всички въведени числа, които се делят на всяка от цифрите си, сортирани във възходящ ред. Програмата да прихваща възможните изключения и да извежда съобщението "Something went wrong!". При възникнало изключение, програмата да не спира.
Пример:
Вход:
5
24
23
105
-12
1230
Изход:
Something went wrong!
Something went wrong!
-12 24
 */
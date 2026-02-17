namespace CheteneNaFail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                try
                {
                    string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int a = int.Parse(parts[0]);
                    int b = int.Parse(parts[1]);
                    int c = int.Parse(parts[2]);
                    IsValidTriangle(a, b, c);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something went wrong!");
                }
            }
        }

        public static void IsValidTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if(c>=a && c>= b)
                {
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine("Правоъгълен триъгълник.");
                    }
                    else
                    {
                        Console.WriteLine("Валиден, но не правоъгълен триъгълник.");
                    }
                }
                else if (b >= a && b >= c)
                {
                    if (a * a + c * c == b * b)
                    {
                        Console.WriteLine("Правоъгълен триъгълник.");
                    }
                    else
                    {
                        Console.WriteLine("Валиден, но не правоъгълен триъгълник.");
                    }
                }
                else if (a >= b && a >= c)
                {
                    if (b * b + c * c == a * a)
                    {
                        Console.WriteLine("Правоъгълен триъгълник.");
                    }
                    else
                    {
                        Console.WriteLine("Валиден, но не правоъгълен триъгълник.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Това не е валиден триъгълник.");
            }
        }
    }
}
/*
Да се напише програма, която чете цели числа от файл и проверява дали всеки ред може да образува валиден триъгълник и ако да – дали е правоъгълен.
Вход:
Файл с име triangles.txt, в който всеки ред съдържа три цели числа, разделени с интервал. Числата представляват дължините на страните на триъгълник.
Изход:
За всеки ред от файла програмата извежда:
Ако числата не могат да образуват триъгълник, извежда:
Това не е валиден триъгълник.
Ако числата образуват валиден триъгълник, проверява дали триъгълникът е правоъгълен по теоремата на Питагор:
Ако е правоъгълен:
Правоъгълен триъгълник.
Ако не е правоъгълен:
Валиден, но не правоъгълен триъгълник.
Преди проверката по Питагор да се сортират страните така, че хипотенузата (най-дългата страна) да е винаги на последно място.
Обработка на грешки:
Ако възникне изключение по време на четене или преобразуване на числата (например ред съдържа букви или липсва файл), програмата извежда: Something went wrong!
triangles.txt
3 4 5
6 6 6
10 6 8
1 1 3
a b c
Примерен изход (от програмата):
Правоъгълен триъгълник.
Валиден, но не правоъгълен триъгълник.
Правоъгълен триъгълник.
Това не е валиден триъгълник.
Something went wrong!

*/
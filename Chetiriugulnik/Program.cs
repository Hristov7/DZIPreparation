namespace Chetiriugulnik
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
                    int[] sides = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    int a = sides[0], b = sides[1], c = sides[2], d = sides[3];

                    if (IsValid(sides))
                    {
                        string type = DetermingType(a, b, c, d);
                        Console.WriteLine($"Chetiriugulnikut e {type}");
                    }
                    else
                    {
                        Console.WriteLine("Невалиден четириъгълник.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Грешка при обработка на файла!");
                }
            }
        }

        public static bool IsValid(int[] sides)
        {
            sides = sides.OrderBy(s => s).ToArray();
            return sides[0] + sides[1] + sides[2] > sides[3];
        }

        public static string DetermingType(int a, int b, int c, int d)
        {
            if (a == b && b == c && c == d) return "Kvadrat";
            else if (a == c && b == d) return "Pravougulnik";
            else return "Proizvolen chetiriugulnik";
        }
    }
}

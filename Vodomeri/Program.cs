namespace Vodomeri
{
    internal class Program
    {
        private static double cenaZaVoda = 2.39;
        private static double cenaOtvejdaneOtpadniVodi = 0.29;
        private static double cenaPrechistvaneOtpadniVodi = 0.59;
        static void Main(string[] args)
        {
            List<double> indiviuduals = new();
            string fileName = Console.ReadLine();

            string[] lines = File.ReadAllLines(fileName);
            string[] str = lines[0].Split('-', StringSplitOptions.RemoveEmptyEntries);
            double obshtoPotreblenie = double.Parse(str[1]) - double.Parse(str[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] potreblenie = lines[i].Split("-", StringSplitOptions.RemoveEmptyEntries);
                double a = double.Parse(potreblenie[1]) - double.Parse(potreblenie[0]);
                indiviuduals.Add(a);
            }
            double sumOfIndividuals = indiviuduals.Sum();

            double razlikaMejduWholePart = obshtoPotreblenie - sumOfIndividuals;
            double koeficent = razlikaMejduWholePart / obshtoPotreblenie;

            Console.WriteLine($"Общо потребление по общия водомер: {obshtoPotreblenie}");
            Console.WriteLine($"Общо потребление по индивидуалните водомери: {sumOfIndividuals}");
            Console.WriteLine($"Разлика за преразпределение: {razlikaMejduWholePart}");
            Console.WriteLine($"Коефициент за преразпределяне: {koeficent:F2}");
            Console.WriteLine();
            Console.WriteLine("Фактури за всяко домакинство:");
            Console.WriteLine();

            for (int i = 0; i < indiviuduals.Count; i++)
            {
                double individual = indiviuduals[i];
                double razpredeleno = individual * koeficent;

                double indWater = individual * cenaZaVoda;
                double indSewage = individual * cenaOtvejdaneOtpadniVodi;
                double indClean = individual * cenaPrechistvaneOtpadniVodi;

                // Цени за разпределено потребление
                double distWater = razpredeleno * cenaZaVoda;
                double distSewage = razpredeleno * cenaOtvejdaneOtpadniVodi;
                double distClean = razpredeleno * cenaPrechistvaneOtpadniVodi;

                // Суми
                double totalNoVat = indWater + indSewage + indClean + distWater + distSewage + distClean;
                double vat = totalNoVat * 0.20;
                double totalWithVat = totalNoVat + vat;

                Console.WriteLine($"Апартамент {i + 1}:");
                Console.WriteLine($"Индивидуално потребление: {individual} куб.м.");
                Console.WriteLine($"----Цена индивидуално потребление: {indWater:F2} лв.");
                Console.WriteLine($"----Отвеждане на отпадни води: {indSewage:F2}");
                Console.WriteLine($"----Пречистване на отпадни води: {indClean:F2}");
                Console.WriteLine($"Разпределени кубици от общия: {razpredeleno:F2} куб.м.");
                Console.WriteLine($"----Цена разпределени кубици от общия: {distWater:F2} лв.");
                Console.WriteLine($"----Отвеждане на отпадни води: {distSewage:F2}");
                Console.WriteLine($"----Пречистване на отпадни води: {distClean:F2}");
                Console.WriteLine($"Общо: {totalNoVat:F2} лв.");
                Console.WriteLine($"- Начислено ДДС: {vat:F2}");
                Console.WriteLine($"Фактура: {totalWithVat:F2}");
                Console.WriteLine();
            }
        }
        public static double CenaVoda(double kubici)
        {
            return kubici * cenaZaVoda;
        }
    }
}

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new();
            string input = Console.ReadLine();
            input = input.Replace(" ", "");
            foreach (char letter in input)
            {
                if(char.IsUpper(letter))
                {
                    input = input.Replace(letter, '0');
                }
                else if (char.IsLower(letter))
                {
                    input = input.Replace(letter, '1');
                }
            }
            //input = Regex.Replace(input, @"\p{Lu}", "0");
            //input = Regex.Replace(input, @"\p{Ll}", "1");

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.IsDigit(input[i]) && char.IsDigit(input[i + 1]))
                {
                    string number = input.Substring(i, 2);
                    if (int.Parse(number)>9 && !numbers.Contains(number))
                    {
                        numbers.Add(number);
                    }
                }
            }
            Console.WriteLine(input);
            Console.WriteLine($"{string.Join("\n", numbers.OrderBy(x=>x))}");
        }
    }
}
/*
26. Създайте приложение с име Zad26, което чете от стандартния вход последователност от знаци, заменя всички главни букви с цифрата 0 и всички малки букви с цифрата 1, премахва интервалите и извежда получения резултат.
Програмата да извлича всички двуцифрени числа от обработеното текстово съдържание без повторения и да ги извежда във възходящ ред.
Примерен вход:
Кодът за достъп до компютъра на Мария е 987123@567!.

Изход:
01111111111111111111111111011111987123@567!.
10
11
12
19
23
56
67
71
87
98

 */
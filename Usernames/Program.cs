namespace Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> userNames = ValidUsernames(input);
            Console.WriteLine(string.Join('\n', userNames));
        }
        public static List<string> ValidUsernames(string[] input)
        {
            List<string> validUserNames = new();
            foreach (string item in input)
            {
                bool flag = false;
                if (item.Length <= 3 || item.Length >= 16)
                {
                    continue;
                }

                foreach (char symbol in item)
                {
                    if (!char.IsLetter(symbol) && !char.IsDigit(symbol) && symbol != '_' && symbol != '-') break;
                    else flag = true;
                }
                if(flag) validUserNames.Add(item);
            }
            return validUserNames;
        }
    }
}
// sh, too_long_username, !lleg@l ch@rs, jeffbutt

//Jeff, john45, ab, cd, peter-ivanov, @smith

namespace TelephoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()!.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;
            while((command=Console.ReadLine())!= "End")
            {
                string[] parts = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string commandPart = parts[0];
                switch (commandPart)
                {
                    case "Add":
                        if (!list.Contains(parts[1])) list.Add(parts[1]);
                        break;

                    case "Remove":
                        if (list.Contains(parts[1])) list.Remove(parts[1]);
                        break;

                    case "Bonus phone":
                        string oldPhone = parts[1].Split(':')[0];
                        string newPhone = parts[1].Split(':')[1];

                        int indexOfOldPhone = list.IndexOf(oldPhone);
                        if (indexOfOldPhone != -1)
                        {
                            list.Insert(indexOfOldPhone + 1, newPhone);
                        }
                        break;

                    case "Last":
                        string phone = parts[1];
                        if (list.Contains(phone))
                        {
                            list.Remove(phone);
                            list.Add(phone);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
/*
SamsungA50, MotorolaG5, IphoneSE
Add - Iphone10
Remove - IphoneSE
End

SamsungA50, MotorolaG5, HuaweiP10
Last - SamsungA50
Add - MotorolaG5
End

HuaweiP20, XiaomiNote
Remove - Samsung
Bonus phone - XiaomiNote:Iphone5
End

*/
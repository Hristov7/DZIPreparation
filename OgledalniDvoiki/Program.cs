namespace OgledalniDvoiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new();
            Dictionary<string, string> ogledalniDvoiki = new();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                words.Add(Console.ReadLine().ToLower());
            }

            for (int i = 0; i < words.Count; i++)
            {
                for (int j = i + 1; j < words.Count; j++)
                {
                    if (!IsPalindrom(words[i]) && !IsPalindrom(words[j]))
                    {
                        if (OgledalnaDuma(words[i], words[j]))
                        {

                            if (!ogledalniDvoiki.ContainsKey(words[i]) && !ogledalniDvoiki.ContainsKey(words[j]))
                            {
                                string[] ordered = new string[] { words[i], words[j] }.OrderBy(x=>x).ToArray();
                                ogledalniDvoiki[ordered[0]] = ordered[1];
                            }

                        }
                    }
                }
            }
            if(ogledalniDvoiki.Count > 0)
            {
                foreach (KeyValuePair<string, string> pair in ogledalniDvoiki.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"({pair.Key}, {pair.Value})");
                }
            }
            else
            {
                Console.WriteLine("Nqma ogledalni dvoiki");
            }
        }

        public static bool IsPalindrom(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (word == reversed)
            {
                return true;
            }
            else return false;
        }

        public static bool OgledalnaDuma(string word, string comparedWord)
        {
            string reversedComparedWord = new string(comparedWord.Reverse().ToArray());
            if (word == reversedComparedWord)
            {
                return true;
            }
            else return false;
        }
    }
}
/*
 
 Даден е списък от думи (низове). Две думи се наричат огледална двойка, ако едната дума е равна на огледалния образ на другата (т.е. обратно изписване), но не е палиндром.
Твоята задача е да намериш всички уникални огледални двойки в списъка.
Вход:
Списък от n думи. Всяка дума е съставена само от малки латински букви.
Изход:
Изведи всички уникални огледални двойки под формата на (дума1, дума2), като дума1 < дума2 лексикографски. Ако няма такива двойки, изведи "Няма огледални двойки".
Пример:
Вход:
9
Loop
Pool
Deed
Peed
Live
Evil
Loop
Deed
evil

Изход:
(evil, live)
(loop, pool)
Забележка:
•  "deed" и "deed" не са огледална двойка – те са една и съща дума.
•  (pool, loop) и (loop, pool) се броят за една двойка, но се извеждат подредени.
Вход:
6
Abc
Cba
Dog
God
Abba
baba

Изход: 
(abc, cba)
(dog, god)
Вход:
5
Top
Pot
Note
Eton
test

Изход:
(eton, note)
(pot, top)


*/
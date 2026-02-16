namespace VuvejdaneNaUchiteli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            List<Teacher> teachers = new List<Teacher>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine()!;
                string lessonType = Console.ReadLine()!;
                int yearsOfPractice = int.Parse(Console.ReadLine()!);
                teachers.Add(new Teacher(name, lessonType, yearsOfPractice));
            }

            Console.WriteLine($"{string.Join('\n', teachers.OrderBy(x => x.Name))}");

            double averageExperience = teachers.Average(x => x.YearsOfPractice);
            Console.WriteLine($"Sredniqt staj na uchitelite e: {averageExperience:f2} godini.");

            int maxYearOfExperience = teachers.Max(t => t.YearsOfPractice);
            List<Teacher> mostExperiencedTeachers = teachers.Where(t => t.YearsOfPractice == maxYearOfExperience).ToList();
            Console.WriteLine($"{string.Join('\n', mostExperiencedTeachers)}");

            IEnumerable<IGrouping<string, Teacher>> groupsOfTeachers = teachers.GroupBy(t => t.LessonType);

            foreach (IGrouping<string, Teacher> group in groupsOfTeachers)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
            }

            IEnumerable<IGrouping<string, Teacher>> groupedTeachersByExperience = teachers.GroupBy(t =>
            {
                if (t.YearsOfPractice < 5) return $"Начинаещ учител";
                else if (t.YearsOfPractice >= 5 && t.YearsOfPractice <= 25) return $"Опитен учител";
                else return $"Ветеран в образованието";
                
            });

            foreach (IGrouping<string, Teacher> group in groupedTeachersByExperience)
            {
                Console.WriteLine($"{group.Key}:");
                foreach (Teacher teacher in group)
                {
                    Console.WriteLine($"{teacher.ToString()}");
                }
            }
        }
    }
}
/*
3
Иван Иванов
Математика
15
Галя Маринова
История
5
Мария Георгиева
Математика
30

*/
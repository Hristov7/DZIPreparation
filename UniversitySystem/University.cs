namespace UniversitySystem
{
    public class University
    {
        public University(string name)
        {
            Name = name;
            Faculty = new List<Faculty>();
        }

        public string Name { get; set; }
        public List<Faculty> Faculty { get; set; }

        public void AddFaculty(Faculty faculty)
            {
                if(faculty != null)
                this.Faculty.Add(faculty);
        }

        public void PrintUniversityInfo()
        {
            Console.WriteLine($"{this.Name}, Faculties:");
            foreach (Faculty faculty in this.Faculty)
            {
                Console.WriteLine($"Faculty: {faculty.Name}");
            }
        }
    }
}

namespace UniversitySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University ("SoftUni");
            Faculty faculty1 = new Faculty("Computer Science");
            Address address1 = new Address("123 Main St", "Sofia");
            Student student1 = new Student("John Doe", 20, address1);
            faculty1.AddStudent(student1);
            university.AddFaculty(faculty1);
            university.PrintUniversityInfo();

        }
    }
}

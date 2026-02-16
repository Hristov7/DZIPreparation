namespace UniversitySystem
{
    public class Student
    {
        public Student(string name, int facultyNumber, Address address)
        {
            Name = name;
            FacultyNumber = facultyNumber;
            Address = address;
        }

        public string Name { get; set; }
        public int FacultyNumber { get; set; }
        public Address Address { get; set; }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"{this.Name} in {this.FacultyNumber} with Address: {this.Address}");
        }
    }
}

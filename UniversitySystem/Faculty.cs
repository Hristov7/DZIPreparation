namespace UniversitySystem
{
    public class Faculty
    {
        public Faculty(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public void AddStudent(Student student)
        {
            if(student != null)
            this.Students.Add(student);
        }

        //public void RemoveStudent(Student student)
        //{
        //    if(student != null && Students.Contains(student))
        //        this.Students.Remove(student);
        //}

        public void PrintStudents()
        {
            foreach (Student student in this.Students)
            {
                student.PrintStudentInfo();
            }
        }
    }
}

namespace VuvejdaneNaUchiteli
{
    public class Teacher
    {
        private string _name;
        private string _lessonType;
        private int _yearsOfPractice;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LessonType
        {
            get { return _lessonType; }
            set { _lessonType = value; }
        }
        public int YearsOfPractice
        {
            get { return _yearsOfPractice; }
            set { _yearsOfPractice = value; }
        }

        public Teacher(string name, string lessonType, int yearsOfPractice)
        {
            Name = name;
            LessonType = lessonType;
            YearsOfPractice = yearsOfPractice;
        }

        public override string ToString()
        {
            return $"{this.Name} e uchitel po {this.LessonType} ot {this.YearsOfPractice} godini ";
        }
    }
}

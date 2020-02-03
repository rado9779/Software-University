namespace P03_StudentSystem
{
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.grade = grade;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public double grade { get; set; }
    }
}
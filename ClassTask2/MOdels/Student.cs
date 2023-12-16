

namespace ClassTask2.MOdels
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }


        public Student(string name, string surname, int age, int point)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Point = point;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {SurName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Point: {Point}");
        }

    }
}

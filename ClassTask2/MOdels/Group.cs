

namespace ClassTask2.MOdels
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Studens{ get; set; }

        public void AddStudent(Student student)
        {
            Studens.Add(student);
        }
        public void GetAllStudents()
        {
            foreach (var item in Studens)
            {
                Console.WriteLine(item);
            }
        }




    }
}

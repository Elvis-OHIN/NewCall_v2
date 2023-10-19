using Models;

namespace Services;

public static class StudentService
{
    static List<Student> Students { get; }
    static int nextId = 3;
    static StudentService()
    {
        Students = new List<Student>
        {
            new Student ( 1, "Classic Italian", "Classic Italian","FA" ),
            new Student ( 2, "Veggie", "Classic Italian" , "FE" )
        };
    }

    public static List<Student> GetAll() => Students;

    public static Student? Get(int id) => Students.FirstOrDefault(p => p.Id == id);

    public static void Add(Student Student)
    {
        Student.Id = nextId++;
        Students.Add(Student);
    }

    public static void Delete(int id)
    {
        var Student = Get(id);
        if(Student is null)
            return;

        Students.Remove(Student);
    }

    public static void Update(Student Student)
    {
        var index = Students.FindIndex(p => p.Id == Student.Id);
        if(index == -1)
            return;

        Students[index] = Student;
    }
}

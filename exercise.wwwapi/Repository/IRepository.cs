

using exercise.wwwapi.Models.StudentModels;

namespace exercise.wwwapi.Repository
{
    public interface IRepository
    {
        Student AddStudent(Student student);
        IEnumerable<Student> GetStudents();
        Student GetStudent(string name);
        Student UpdateStudent(string name, StudentPut student);
        Student DeleteStudent(string name);

    }
}

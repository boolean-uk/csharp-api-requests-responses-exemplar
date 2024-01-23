

using exercise.wwwapi.Data;
using exercise.wwwapi.Models.StudentModels;

namespace exercise.wwwapi.Repository
{
    public class Repository : IRepository
    {
        private StudentCollection _db;
        public Repository(StudentCollection db)
        {
            _db = db;
        }
        public Student AddStudent(Student student)
        {           
            return _db.Add(student); 
        }

        public Student DeleteStudent(string name)
        {
            return _db.DeleteStudent(name);
        }

        public Student GetStudent(string name)
        {
            return _db.GetStudent(name);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _db.GetAllStudents();
        }

        public Student UpdateStudent(string name, StudentPut student)
        {
            throw new NotImplementedException();
            //return _db.UpdateStudent(student);
        }
    }
}

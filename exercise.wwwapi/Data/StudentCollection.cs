

using exercise.wwwapi.Models.StudentModels;

namespace exercise.wwwapi.Data
{
    public class StudentCollection
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() { FirstName="Nathan",LastName="King" },
            new Student() { FirstName="Dave", LastName="Ames" }
        };

        public Student Add(Student student)
        {            
            _students.Add(student);

            return student;
        }

        public List<Student> GetAllStudents()
        {
            return _students.ToList();
        }
        public Student GetStudent(string name)
        {
            return _students.FirstOrDefault(s => s.FirstName==name);
        }
        public Student DeleteStudent(string name)
        {
            var student = _students.FirstOrDefault(s => s.FirstName == name);
            if (student != null)
            {
                _students.RemoveAll(s => s.FirstName==name);
            }
            return student;
        }
        public Student UpdateStudent(string name, StudentPut model)
        {
            var target = _students.FirstOrDefault(s =>s.FirstName==name);
            target.FirstName = model.FirstName;
            target.LastName = model.LastName;
            return target;
        }
    };


}

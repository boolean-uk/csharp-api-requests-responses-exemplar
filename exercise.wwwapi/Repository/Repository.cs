

using exercise.wwwapi.Data;
using exercise.wwwapi.Models.LanguageModels;
using exercise.wwwapi.Models.StudentModels;

namespace exercise.wwwapi.Repository
{
    public class Repository : IRepository
    {
        private StudentCollection _dbStudent;
        private LanguageCollection _languageCollection;
        public Repository(StudentCollection dbStudent, LanguageCollection _dbLanguage)
        {
            _dbStudent = dbStudent;
            _languageCollection = _dbLanguage;
        }

        public Language AddLanguage(Language language)
        {
            return _languageCollection.Add(language);
        }

        public Student AddStudent(Student student)
        {           
            return _dbStudent.Add(student); 
        }

        public Language DeleteLanguage(string name)
        {
            throw new NotImplementedException();
        }

        public Student DeleteStudent(string name)
        {
            return _dbStudent.DeleteStudent(name);
        }

        public Language GetLanguage(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Language> GetLanguages()
        {
            return null;
        }

        public Student GetStudent(string name)
        {
            return _dbStudent.GetStudent(name);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _dbStudent.GetAllStudents();
        }

        public Language UpdateLanguage(string name, LanguagePut language)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(string name, StudentPut student)
        {
            return _dbStudent.UpdateStudent(name, student);            
        }
    }
}

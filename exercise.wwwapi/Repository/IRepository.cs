

using exercise.wwwapi.Models.LanguageModels;
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

        Language AddLanguage(Language language);
        IEnumerable<Language> GetLanguages();
        Language GetLanguage(string name);
        Language UpdateLanguage(string name, LanguagePut language);
        Language DeleteLanguage(string name); 
    }
}

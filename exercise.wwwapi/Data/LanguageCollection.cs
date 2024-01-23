using exercise.wwwapi.Models.LanguageModels;

namespace exercise.wwwapi.Data
{

    public class LanguageCollection
    {
        private static List<Language> _languages = new List<Language>()
        {
            new Language(){ name="Java" },
            new Language(){ name="C#" }
        };
        public Language Add(Language language)
        {
            _languages.Add(language);
            return language;
        }
    }
}

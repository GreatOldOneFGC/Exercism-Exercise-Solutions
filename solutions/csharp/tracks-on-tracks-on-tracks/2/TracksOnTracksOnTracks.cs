public static class Languages
{
    private const string C_SHARP = "C#";
    private const string CLOJURE = "Clojure";
    private const string ELM = "Elm";

    public static List<string> NewList() => [];

    public static List<string> GetExistingLanguages() => [C_SHARP, CLOJURE, ELM];

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language) => languages.Contains(language);

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0)
        {
            return false;
        }

        return languages[0] == C_SHARP || (languages[1] == C_SHARP && (languages.Count == 2 || languages.Count == 3));
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages) => languages.Distinct().Count() == languages.Count;
}

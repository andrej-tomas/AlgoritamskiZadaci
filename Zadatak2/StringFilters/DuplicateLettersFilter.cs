using System.Text;

namespace Zadatak2.StringFilters;

public class DuplicatelettersFilter : IStringFilter
{
    public string Filter(string word)
    {
        HashSet<char> uniqueLetters = new();

        for (int i = 0; i < word.Length; i++)
        {
           uniqueLetters.Add(word[i]);
        }

        return GenerateFilteredString(uniqueLetters);
    }

    private static string GenerateFilteredString(HashSet<char> letters)
    {
        StringBuilder stringBuilder = new();

        foreach (char c in letters)
        {
            stringBuilder.Append(c);
        }

        return stringBuilder.ToString();
    }
}

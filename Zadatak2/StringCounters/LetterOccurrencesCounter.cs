using System.Text;

namespace Zadatak2.StringCounters;

public class LetterOccurrencesCounter : ICounter<string>
{
    public string Count(string word)
    {
        Dictionary<char, int> letters = new();

        for (int i = 0; i < word.Length; i++)
        {
            if (!letters.ContainsKey(word[i]))
                letters.Add(word[i], 1);
            else
                letters[word[i]]++;
        }

        return GenerateWordResult(letters);
    }

    private static string GenerateWordResult(Dictionary<char, int> letters)
    {
        StringBuilder result = new();
        foreach (KeyValuePair<char, int> pair in letters)
        {
            result.Append($"{pair.Key}{pair.Value}");
        }
        return result.ToString();
    }
}

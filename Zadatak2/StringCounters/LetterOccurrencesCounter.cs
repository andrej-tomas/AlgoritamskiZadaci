namespace Zadatak2.StringCounters;

public class LetterOccurrencesCounter : ICounter<Dictionary<char, int>>
{
    public Dictionary<char, int> Count(string word)
    {
        Dictionary<char, int> letters = new();

        for (int i = 0; i < word.Length; i++)
        {
            if (!letters.ContainsKey(word[i]))
                letters.Add(word[i], 1);
            else
                letters[word[i]]++;
        }

        return letters;
    }
}

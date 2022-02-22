using System.Text;

namespace Zadatak2.StringFilters;

public class DuplicatelettersFilter : IStringFilter<Dictionary<char, int>>
{
    public string Filter(Dictionary<char, int> letters)
    {
        StringBuilder result = new();
        foreach (KeyValuePair<char, int> kvp in letters)
        {
            result.Append(kvp.Key);
        }

        return result.ToString();
    }
}

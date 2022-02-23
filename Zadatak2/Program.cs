using Zadatak2.StringCounters;
using Zadatak2.StringFilters;

namespace Zadatak2;

public class Program
{
    static void Main(string[] args)
    {
        var word = GetWordFromUser();   
        ICounter<string> counter = new LetterOccurrencesCounter();
        var result = counter.Count(word);
        var filterChoice = GetFilterChoiceFromUser();

        if (filterChoice.Equals("a"))
            Console.WriteLine(result);
        else
            Console.WriteLine(new DuplicatelettersFilter().Filter(word));
    }

    private static string GetWordFromUser()
    {
        string input;
        do
        {
            Console.WriteLine("Enter a word to count the occurrences of letters: ");
            input = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(input));

        return input.Replace(" ", "").ToLower();
    }

    private static string GetFilterChoiceFromUser()
    {
        string choice;
        do
        {
            Console.WriteLine("Would you like to:");
            Console.WriteLine("(a) Display letters with number of occurrences.");
            Console.WriteLine("(b) Display the filtered word.");
            Console.WriteLine("Type 'a' or 'b' and press enter.");
            choice = Console.ReadLine();
        } while (string.IsNullOrEmpty(choice) || !(choice.Equals("a") || choice.Equals("b")));

        return choice;
    }
}

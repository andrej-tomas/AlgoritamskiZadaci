using Zadatak1.StringCheckers;
using Zadatak1.StringCheckers.Palindrome;

namespace Zadatak1;
public class Program
{
    static void Main(string[] args)
    {
        Checker checker = new(new PalindromeChecker(), new PalindromeResultPrinter());
        var result = checker.CheckString(GetWordFromUser());
        checker.PrintResult(result);
    }

    public static string GetWordFromUser()
    {
        string word;

        do
        {
            Console.WriteLine("Enter a word to check if it is a palindrome: ");
            word = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(word));

        return word;
    }
}

namespace Zadatak1.StringCheckers.Palindrome;
public class PalindromeResultPrinter : IResultPrinter
{
    public void Print(bool result)
    {
        if (result)
            Console.WriteLine("Entered word is a palindrome.");
        else
            Console.WriteLine("Entered word is not a palindrome.");
    }
}


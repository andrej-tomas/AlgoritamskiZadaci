namespace Zadatak2.ResultPrinters;

public class LetterOccurrencesPrinter : IResultPrinter<Dictionary<char, int>>
{
    public void Print(Dictionary<char, int> letters)
    {
        foreach (KeyValuePair<char, int> kvp in letters)
        {
            Console.Write("{0}{1}", kvp.Key, kvp.Value);
        }

        Console.WriteLine();
    }
}

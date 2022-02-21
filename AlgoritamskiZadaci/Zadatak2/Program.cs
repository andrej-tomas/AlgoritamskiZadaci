namespace AlgoritamskiZadaci.Zadatak2;

/*
* 
*   2. zadataka: 
*   Napisati konzolnu aplikaciju I nacrtati algoritam koji za zadati ulaz formira izlaze:
*
*   Ulaz: string vrednost
*   
*   Izlaz: 
*   a) Broj ponavljanja svakog karaktera.Primer: ulaz:  aaabbbcvcntrt izlaz: a3b3c2v1n1t2r1
*   b) Profiltriran uzlaz Primer:  aaabbbcvcntrt Izlaz: abcvntr
*   
*/
public class Zadatak2
{
    static void Main(string[] args)
    {
        string input;
        do
        {
            Console.WriteLine("Enter a word to count the occurrences of letters: ");
            input = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(input));

        string choice;
        do
        {
            Console.WriteLine("Would you like to:");
            Console.WriteLine("(a) Display letters with number of occurrences.");
            Console.WriteLine("(b) Display the filtered word.");
            Console.WriteLine("Type 'a' or 'b' and press enter.");
            choice = Console.ReadLine();
        } while (string.IsNullOrEmpty(choice) || !(choice.Equals("a") || choice.Equals("b")));


        if (choice.Equals("a"))
            DisplayLetterOccurences(CountLetterOccurrences(input));
        else
            DisplayLetterOccurences(CountLetterOccurrences(input), true);
    }

    public static Dictionary<char, int> CountLetterOccurrences(string word)
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

    public static void DisplayLetterOccurences(Dictionary<char, int> letters, bool simplified = false)
    {
        foreach (KeyValuePair<char, int> kvp in letters)
        {
            if (simplified)
                Console.Write(kvp.Key);
            else
                Console.Write("{0}{1}", kvp.Key, kvp.Value);
        }

        Console.WriteLine();
    }

}
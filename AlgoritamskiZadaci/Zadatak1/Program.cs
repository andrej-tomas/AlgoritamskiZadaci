namespace AlgoritamskiZadaci.Zadatak1;

/*  
*  
*  1. zadatak: 
*  Napisati konzolnu aplikaciju I nacrtati algoritam koji za zadati ulaz daje rezultat(true/false) po sledećem pravilu:
*  
*  Ulaz: string vrednost
*  
*  Izlaz: Da li je ( true / false ) input string Palindrom(Palindrom je reč, broj, fraza ili red elemenata koji se
*  podjednako čitaju i sleve na desno i s desne na levo )
*  
*/

public class Zadatak1
{
    static void Main(string[] args)
    {
        
        string word;

        do
        {            
            Console.WriteLine("Enter a word to check if it is a palindrome: ");
            word = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(word));            

        bool isPalindrome = IsPalindrome(word);

        if (isPalindrome)
            Console.WriteLine($"\"{word}\" is a palindromic word.");
        else
            Console.WriteLine($"\"{word}\" is not a palindromic word.");
    }

    public static bool IsPalindrome(string word)
    {
        //word = word.ToLower();
        int length = word.Length;
        int halfLength = length / 2;
        bool isPalindrome = false;

        for (int i = 0; i < halfLength; i++)
            if (word[i] == word[length - i - 1])
                isPalindrome = true;

        return isPalindrome;
    }
}

namespace Zadatak1.StringCheckers.Palindrome;
public class PalindromeChecker : IStringChecker
{
    public bool CheckString(string word)
    {
        int length = word.Length;
        int halfLength = length / 2;

        for (int i = 0; i < halfLength; i++)
        {
            if (word[i] != word[length - i - 1])
                return false;
        }            

        return true;
    }
}


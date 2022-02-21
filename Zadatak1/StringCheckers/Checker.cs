namespace Zadatak1.StringCheckers;
public class Checker
{
    private readonly IStringChecker _checker;
    private readonly IResultPrinter _resultPrinter;

    public Checker(IStringChecker checker, IResultPrinter resultPrinter)
    {
        _checker = checker;
        _resultPrinter = resultPrinter;
    }

    public bool CheckString(string word)
    {
        return _checker.CheckString(word);
    }

    public void PrintResult(bool answer)
    {
        _resultPrinter.Print(answer);
    }
}


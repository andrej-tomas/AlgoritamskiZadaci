namespace Zadatak2.ResultPrinters;

public interface IResultPrinter<T>
{
    void Print(T t);
}

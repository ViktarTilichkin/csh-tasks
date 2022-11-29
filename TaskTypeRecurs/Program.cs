// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task7();
    }
    #region Задача 1
    static void Task1()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int number0 = 0;
        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            int sum = number0 + result;
            number0 = result;
            result = sum;
        }
        Console.WriteLine(result);
        Console.WriteLine(NumberFibonaci(number));
    }
    static int NumberFibonaci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return NumberFibonaci(n - 2) + NumberFibonaci(n - 1);
    }
    #endregion
    #region Задача 7.
    // 7. Дана строка. Написать метод по подсчёту количеству вхождений символа
    // (подстроки). Метод возвращает символ (подстроку), количество вхождений, перое
    // и последнее вхождение в строку. (использовать IndexOf, LastIndexOf, Split и тд
    // запрещено)
    static void Task7()
    {
        string? text = Console.ReadLine();
        string? symbol = Console.ReadLine();
        if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
        {
            Console.WriteLine(MethodAllSearch(text, symbol));
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    static (string, int, int, int) MethodAllSearch(string text, string symbol)
    {
        int count = 0;
        int indexFirst = -1;
        int indexLast = -1;
        int LengthSymbol = symbol.Length;
        for (int i = 0; i <= text.Length - LengthSymbol; i++)
        {
            string temp = "";
            for (int j = i; j <= i + (LengthSymbol - 1); j++)
            {
                temp += text[j];
            }
            if (temp == symbol)
            {
                if (indexFirst == -1)
                {
                    indexFirst = i;
                }
                indexLast = i;
                count++;
            }
        }
        return (symbol, count, indexFirst, indexLast);
    }
    #endregion
}

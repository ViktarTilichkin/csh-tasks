// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
    }


    #region Задача1
    // 1. На входе дано три массива заполненных случайными числами. Написать метод
    // по подсчёту общего количества чётных чисел в массивах. (ref)
    static void Task1()
    {
        int[] arrayNumber = { 15, 58, 16, 819, 156, 651, 1568 };
        int[] arrauNumber2 = { 1649, 13, 15, 17, 16, 18, 25, 16 };
        int[] arrauNumber3 = { 1651, 6548, 1989, 2165, 46165, 121, 21, 64, 655, 564 };
        int count = 0;
        Console.WriteLine(EvenNumbersArray(ref count, arrayNumber));
        Console.WriteLine(EvenNumbersArray(ref count, arrauNumber2));
        Console.WriteLine(EvenNumbersArray(ref count, arrauNumber3));
        Console.WriteLine(count);

    }
    static int EvenNumbersArray(ref int count, params int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    #endregion

    #region Задача 2
    // 2. Написать метод, который проверяет является ли введнная строка почтовым
    // адрессом и возвращающий домен почты.(out)
    static void Task2()
    {
        Console.WriteLine("задача 2");
        Console.WriteLine("Введите email");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine(ChekEmail(input, out string domen));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static bool ChekEmail(string email, out string domen)
    {
        domen = "";
        email = email.Trim();
        bool resultEmail = false;
        int symbol1 = 0;
        for (int i = email.Length - 1; i > -1; i--)
        {
            if (!resultEmail && email[i] != '.' && email[i] != '@')
            {
                domen += email[i];
            }
            else if (email[i] == '.')
            {
                domen += email[i];
                symbol1++;
            }
            else if (email[i] == '@')
            {
                domen += email[i];
                break;
            }
        }
        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] == ' ')
            {
                symbol1 = 2;
            }
        }
        if (symbol1 == 1)
        {
            resultEmail = true;
            string result = new string(domen.ToCharArray().Reverse().ToArray());
            Console.WriteLine($"Email domen {result}");
            return resultEmail;
        }
        else
        {
            Console.WriteLine(domen = "is not email");
            return resultEmail;
        }
    }

    #endregion

    #region Задача 3
    // 3. Написать метод, который удаляет из строки заданный символ. Символ является
    // входным параметром-значением. Строка должна быть параметром-ссылкой и
    // результатом. (ref)
    static void Task3()
    {
        Console.WriteLine("Task 3");
        Console.WriteLine("Enter the string");
        string? text = Console.ReadLine();
        Console.WriteLine("Enter the symbol");
        string? symbol = Console.ReadLine();
        if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
        {
            CustomReplace(ref text, symbol);
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static void CustomReplace(ref string text, string symbol)
    {
        string text11 = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].ToString() != symbol)
            {
                text11 += text[i];
            }
        }
        text = text11;
    }

    #endregion

    #region Задача 4
    // 4. Написать метод выполняющий сложение парметов, если параметры одного типа
    // данных возвращать true и результат сложение, в противном случае false (out)
    static void Task4()
    {
        Console.WriteLine("Задача 4");

    }
    #endregion

    #region Задача 5
    // 5. Пользователь вводит строку и разделитель. Написать метод возвращающий
    // наличие в строке разделителя, если разделитель есть вернуть строку разбитую
    // данным разделителем (out)
    static void Task5()
    {
        Console.WriteLine("Зачада 5");
        Console.WriteLine("Введите строку");
        string? input = Console.ReadLine();
        Console.WriteLine("Введите разделитель");
        string? input2 = Console.ReadLine();
        if (!string.IsNullOrEmpty(input) && !string.IsNullOrEmpty(input2))
        {
            Console.WriteLine(CustomSplit(input, input2, out _));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static bool CustomSplit(string text, string symbol, out string newString)
    {
        bool result = false;
        newString = "";
        for (int i = 0; i < text.Length - symbol.Length; i++)
        {
            string[] temp = new string[symbol.Length];
            for (int j = 0; j < symbol.Length; j++)
            {
                temp[j] = text[i + j].ToString();
            }
            if (temp[0].Equals(symbol))
            {
                result = true;
            }
        }
        return result;
    }

    #endregion

    #region Задача 6
    // 6. Написать метод возвращающий разность между найбольшим и наименьшим
    // значением из списка. Результат разности возращать через out, метод для поиска
    // минимального и максимального написать с использованием params
    static void Task6()
    {
        Console.WriteLine("Задача 6");
        int[] numbers = { 1, 68, 45, 1, 8, -5, 6, 9, 100 };
        MetMinMaxCustom(out int result, numbers);
        Console.WriteLine(result);
    }

    static void MetMinMaxCustom(out int result, params int[] numbers)
    {
        int numMin = numbers[0];
        int numMax = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numMin > numbers[i])
            {
                numMin = numbers[i];
            }
            if (numMax < numbers[i])
            {
                numMax = numbers[i];
            }
        }
        result = numMax - numMin;
    }


    #endregion

    #region Задача 7
    // 7. Написать метод который принимает строку, если строка содержит только 0 и 1
    // вернуть true, а 0 и 1 перевести в 10-ную систему счисления, в противном случае
    // false (out)
     static void Task7()
    {
        Console.WriteLine("Задача 7");
        int[] numbers = { 1, 68, 45, 1, 8, -5, 6, 9, 100 };
        
    }
    #endregion

    #region Задача 8
    // 8. На входе метода набор 0 и 1 перевести в 16-ную систему счисления (params)
    static void Task8()
    {
        Console.WriteLine("Задача 8");
        int[] numbers = { 1, 68, 45, 1, 8, -5, 6, 9, 100 };
        
    }
    #endregion
}


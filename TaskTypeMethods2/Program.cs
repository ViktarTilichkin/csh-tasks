// See https://aka.ms/new-console-template for more information

internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
    }


    #region Задача1
    // 1. На входе дано три массива заполненных случайными числами. Написать метод
    // по подсчёту общего количества чётных чисел в массивах. (ref)
    // static void Task1()
    // {
    //     int[] arrayNumber = { 15, 58, 16, 819, 156, 651, 1568 };
    //     int[] arrauNumber2 = { 1649, 13, 15, 17, 16, 18, 25, 16 };
    //     int[] arrauNumber3 = { 1651, 6548, 1989, 2165, 46165, 121, 21, 64, 655, 564 };
    //     int result = EvenNumbersArray(arrayNumber, arrauNumber2, arrauNumber3);

    // }
    // static int EvenNumbersArray(params int[] array)
    // {
    //     return 50;
    // }

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
    
    #endregion

    #region Задача 5
    // 5. Пользователь вводит строку и разделитель. Написать метод возвращающий
    // наличие в строке разделителя, если разделитель есть вернуть строку разбитую
    // данным разделителем (out)
    #endregion

    #region Задача 6
    // 6. Написать метод возвращающий разность между найбольшим и наименьшим
    // значением из списка. Результат разности возращать через out, метод для поиска
    // минимального и максимального написать с использованием params
    #endregion

    #region Задача 7
    // 7. Написать метод который принимает строку, если строка содержит только 0 и 1
    // вернуть true, а 0 и 1 перевести в 10-ную систему счисления, в противном случае
    // false (out)
    #endregion

    #region Задача 8
    // 8. На входе метода набор 0 и 1 перевести в 16-ную систему счисления (params)
    #endregion
}


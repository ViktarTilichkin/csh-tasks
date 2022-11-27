// See https://aka.ms/new-console-template for more information

internal class Program
{
    #region  Общий
    static object Method(object obj1, object obj2)
    {
        if (obj1 is int number1 && obj2 is int number2)
        {
            return number1 + number2; //return (int => object)
        }
        return $"{obj1} {obj2}";  //return (string => object)
    }
    #endregion

    static void Main(string[] args)
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        Task7();
    }


    #region Задача 1 
    // Пользователь вводит имя и фамилию. Необходимо создать метод возвращающую строку вида «Привет, {имя} {фамилия}»
    static void Task1()
    {
        Console.WriteLine("Введите имя");
        string? firstname = Console.ReadLine();
        Console.WriteLine("Введите фамилию");
        string? lastname = Console.ReadLine();
        if (!string.IsNullOrEmpty(firstname) && !string.IsNullOrEmpty(lastname))
        {
            Console.WriteLine(MethodHello(firstname, lastname));
        }
    }
    static object MethodHello(string firstname, string lastname)
    {
        return $"Hello, {firstname} {lastname}";
    }

    #endregion
    #region Задача 2
    // 2. Напишите метод, который принимает строку в маленьком регистре и возаращает
    // строку, где каждое слово начинается с большого регистра hschool company -> Hschool Company

    static void Task2()
    {
        Console.WriteLine("Введите строку");
        string? text = Console.ReadLine();
        if (!string.IsNullOrEmpty(text))
        {
            Console.WriteLine(MethodConvert(text));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static string MethodConvert(string text)
    {
        string[] result = text.Split(" ");
        string result1 = "";
        foreach (string item in result)
        {
            result1 += Char.ToUpper(item[0]) + item.Remove(0, 1) + " ";
        }
        return result1;

    }
    #endregion 
    #region Задача 3 
    // 3. Напишите метод, который принимает статичный массив строк. Необходимо отфильтровать значения и оставить только те, где длина строк до 2 символов.
    //  [“by”, “belarus”, “de”, “ru”, “germany”] -> [“by”, “de”, “ru”]
    static void Task3()
    {
        string[] text = { "by", "belarus", "de", "ru", "germany" };
        Console.WriteLine(string.Join(",", MethodReplace(text)));
    }
    static string[] MethodReplace(string[] text)
    {
        string[] result = new string[100];
        int i = 0;
        foreach (string item in text)
        {
            if (item.Length < 3)
            {
                result[i] += item;
                i++;
            }
        }
        return result;
    }
    #endregion
    #region Задача 4
    //     4. На входе массив. Реализовать метод проверки на то что в массиве только числа.
    // Метод возвращает true, если в массиве только числа и false в противном случае

    static void Task4()
    {
        string[] input = { "1", "5", "8", "15", "25" };
        Console.WriteLine(string.Join(", ", input));
        Console.WriteLine(MethodInputInt(input));
    }
    static bool MethodInputInt(string[] text)
    {
        foreach (string item in text)
        {
            if (!decimal.TryParse(item, out _))
            {
                return false;
            }
        }
        return true;

    }

    #endregion
    #region Задача 5
    // 5. На входе n – количество элементов массива (вводится с клавиатуры). Далее
    // производится заполнение массива с слуйчными числами. Реализуйте два метода
    // для поиска минимального и максимального значения.

    static void Task5()
    {
        Console.WriteLine("введите длинну массива");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int numberindex))
        {
            double[] numbers = new double[numberindex];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(-100, 100);
            }
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine(MethodMinNumber(numbers));
            Console.WriteLine(MethodMaxNumber(numbers));
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    static double MethodMinNumber(double[] number)
    {
        double numberMin = number[0];
        for (int i = 0; i < number.Length; i++)
        {
            if (numberMin > number[i])
            {
                numberMin = number[i];
            }
        }
        return numberMin;
    }
    static double MethodMaxNumber(double[] number)
    {
        double numberMax = number[0];
        for (int i = 0; i < number.Length; i++)
        {
            if (numberMax < number[i])
            {
                numberMax = number[i];
            }
        }
        return numberMax;
    }


    #endregion
    #region Задача 6 
    // 6. На входе n – количество элементов массива (вводится с клавиатуры). Далее
    // производится заполнение массива с слуйчными числами. Реализуйте методы
    // подсчета и вывода количества элементов массива меньше и больш среднего значения.
    
     static void Task6()
    {
        Console.WriteLine("Задача");
        Console.WriteLine("введите длинну массива");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int numberindex))
        {
            double[] numbers = new double[numberindex];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(-100, 100);
            }
            double arraySumm = 0;
            double arrayMean = arraySumm / numbers.Length;
            foreach (double item in numbers)
            {
                arraySumm += item;
            }
            Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine(string.Join(", ", MethodMeanMin(numbers, arrayMean)));
            Console.WriteLine(string.Join(", ", MethodMeanMax(numbers, arrayMean)));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static double[] MethodMeanMin(double[] input, double arrayMean)
    {
        int i = 0;
        double[] result = new double[i];
        foreach (double item in input)
        {
            if (item < arrayMean)
            {
                result[i] = item;
                i++;
            }
        }
        return result;
    }
    static double[] MethodMeanMax(double[] input, double arrayMean)
    {
        int i = 0;
        double[] result = new double[i];
        foreach (double item in input)
        {
            if (item > arrayMean)
            {
                result[i] = item;
                i++;
            }
        }
        return result;
    }

    #endregion
    #region Задача 7
    // 7. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только числа. Второй для получения суммы всех элементов массива. Если
    // результат метода проверки – true, то вызывать новый метод, возвращающий
    // сумму всех элементов массива
    static void Task7()
    {
        Console.WriteLine("Задача 7");
        Console.WriteLine("Введите массив чисел");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
           string[] array = input.Split(" ");
            if (MethodInputInt(array))
            {
                double[] number = new double[array.Length];
                Array.Copy(array , number, array.Length);
                Console.WriteLine(MethodSummArray(number));
            }
        }

    }
    static double MethodSummArray(double[] input)
    {
        double result = 0;
        foreach (double item in input)
        {
            result += item;
        }
        return result;
    }

    #endregion
    #region Задача 8
    // 8. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только строки. Второй для получения суммы всех строчных элементов массива.
    // Если результат метода проверки – true, то вызывать новый метод, возвращающую
    // конкатенацию всех строчных элементов массива
    #endregion
    #region Задача 9
    // 9. На входе 2 массива, размерность которых вводится с клавиатуры, а значения
    // заполняются случайными числами. Реализуйте 2 метода. Первый что массивы
    // имеют одинаковую размерность и все элементы отличаются. Второй произвести
    // поэлементное умножение. Если результат метода проверки – true, то вызывать
    // новый метод, возвращающий вывод элементов через запятую
    #endregion
    #region Задача 10
    // 10. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только числа. Второй для получения только четных элементов массива. Если
    // результат метода проверки – true, то вызывать новую метод, возвращающий
    // массив с четными элементами массива
    #endregion
    #region Задача 11
    // 11. На входе число. Необходимо создать метод, возвращающий факториал числа.
    // Пример фактериала 4! = 1 * 2 * 3 * 4
    #endregion
    #region Задача 12
    // 12. На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // палиндром и false в противном случае
    #endregion
    #region Задача 13
    // 13. На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // анаграмма и false в противном случае
    #endregion
    #region Задача 14
    // 14. Реализовать метод возвращающий разность между НОК и НОД для двух чисел
    #endregion
    #region Задача 15
    // 15. Реазуйте методы перевода чисел из десятичной системы счисления в 2-ую и 16-
    // ую
    #endregion
}
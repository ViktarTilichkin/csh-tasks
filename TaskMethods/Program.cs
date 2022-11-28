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
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
        Task13();
        Task14();
        Task15();
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
    static bool MethodInputInt(params object[] text)
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
        object[] input = { "5", "12", "213", "14" };
        Console.WriteLine(string.Join(", ", input));
        if (MethodInputInt(input))
        {
            Console.WriteLine(MethodSummArray(input));
        }
        else
        {
            Console.WriteLine("array has not numbers");
        }
    }
    static double MethodSummArray(object[] input)
    {
        double result = 0;
        foreach (object item in input)
        {
            double number = Convert.ToDouble(item);
            result += number;

        }
        return result;
    }
    #endregion
    #region Задача 8
    // 8. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только строки. Второй для получения суммы всех строчных элементов массива.
    // Если результат метода проверки – true, то вызывать новый метод, возвращающую
    // конкатенацию всех строчных элементов массива
    static void Task8()
    {
        Console.WriteLine("Задача 7");
        object[] input = { "HE", "LLO", "LITL", "PROG666" };
        Console.WriteLine(string.Join(" ", input));
        if (MethodInputString(input))
        {
            Console.WriteLine(CustomJoin(input));
        }
        else
        {
            Console.WriteLine("array contains numbers");
        }
    }
    static bool MethodInputString(params object[] input)
    {
        foreach (object item in input)
        {
            if (decimal.TryParse(item.ToString(), out _))
            {
                return false;
            }
        }
        return true;
    }
    static string CustomJoin(object[] input, string symbol = ", ")
    {
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            string? text = input[i].ToString();
            result += text + symbol;
        }
        result = result.Remove(result.Length - 2, 2);
        return result;
    }

    #endregion
    #region Задача 9
    // 9. На входе 2 массива, размерность которых вводится с клавиатуры, а значения
    // заполняются случайными числами. Реализуйте 2 метода. Первый что массивы
    // имеют одинаковую размерность и все элементы отличаются. Второй произвести
    // поэлементное умножение. Если результат метода проверки – true, то вызывать
    // новый метод, возвращающий вывод элементов через запятую
    static void Task9()
    {
        Console.WriteLine("Задача 9");
        Console.WriteLine("Введите длинну первого массива");
        string? input = Console.ReadLine();
        Console.WriteLine("Введите длинну второго массива");
        string? input2 = Console.ReadLine();
        if (int.TryParse(input, out int LengthFirst) && int.TryParse(input2, out int LengthSecond))
        {
            int[] arrayFirst = new int[LengthFirst];
            int[] arraySecond = new int[LengthSecond];
            for (int i = 0; i < LengthFirst; i++)
            {
                arrayFirst[i] = new Random().Next(10, 12);
            }
            for (int i = 0; i < LengthSecond; i++)
            {
                arraySecond[i] = new Random().Next(15, 20);
            }
            Console.WriteLine(string.Join(", ", arrayFirst));
            Console.WriteLine(string.Join(", ", arraySecond));
            if (EqualLengthArray(arrayFirst, arraySecond))
            {
                Console.WriteLine(CustomJoinInt(arrayFirst, "! "));
                Console.WriteLine(CustomJoinInt(arraySecond, "% "));
            }
            else
            {
                Console.WriteLine(string.Format("Multiplication arrayFist {0}", MultiplicationNumbres(arrayFirst)));
                Console.WriteLine(string.Format("Multiplication arraySecond {0}", MultiplicationNumbres(arraySecond)));
            }
        }
        else
        {
            Console.WriteLine("Entered not a number");
        }

    }
    static bool EqualLengthArray(int[] array1, int[] array2)
    {
        if (array1.Length == array2.Length)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
    static int MultiplicationNumbres(params int[] array)
    {
        int result = 1;
        foreach (int item in array)
        {
            result = result * item;
        }
        return result;
    }
    static string CustomJoinInt(int[] input, string symbol = ", ")
    {
        string result = "";
        foreach (int item in input)
        {
            result += item.ToString() + symbol;
        }
        result.Remove(result.Length - 3, 2);
        return result;
    }

    #endregion
    #region Задача 10
    // 10. На входе массив. Реализуйте 2 метода. Первый для проверки, что в массиве
    // только числа. Второй для получения только четных элементов массива. Если
    // результат метода проверки – true, то вызывать новую метод, возвращающий
    // массив с четными элементами массива
    static void Task10()
    {
        Console.WriteLine("Задача 7");
        string[] input = { "12", "11", "14", "9" };
        Console.WriteLine(string.Join(" ", input));
        if (MethodInputInt(input))
        {
            Console.WriteLine(string.Join(", ", EvenNumbers(input)));
        }
        else
        {
            Console.WriteLine("array contains numbers");
        }
    }

    static double[] EvenNumbers(string[] input)
    {
        double[] result = new double[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (Convert.ToDouble(input[i]) % 2 == 0)
            {
                int Length = result.Length;
                double[] array = new double[Length + 1];
                Array.Copy(result, array, Length);
                array[Length] = Convert.ToDouble(input[i]);
                result = array;
            }
        }
        return result;
    }
    #endregion
    #region Задача 11
    // 11. На входе число. Необходимо создать метод, возвращающий факториал числа.
    // Пример фактериала 4! = 1 * 2 * 3 * 4
    static void Task11()
    {
        Console.WriteLine("Задача 11");
        Console.WriteLine("Введите число");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine(Factorial(number));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    #endregion
    #region Задача 12
    // 12. На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // палиндром и false в противном случае

    static void Task12()
    {
        Console.WriteLine("Задача 12");
        Console.WriteLine("Введите слово");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine(MetPalindrom(input));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static bool MetPalindrom(string text)
    {
        string result = "";
        for (int i = text.Length - 1; 0 <= i; i--)
        {
            result += text[i];
        }
        if (result.Equals(text))
        {
            return true;
        }
        return false;
    }
    #endregion
    #region Задача 13
    // 13. На входе строка. Необходимо создать метод, возвращающий true, если это слово
    // анаграмма и false в противном случае

    static void Task13()
    {
        Console.WriteLine("Задача 13");
        Console.WriteLine("Введите слово");
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Console.WriteLine(MetAnagram(input));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static bool MetAnagram(string text)
    {

        return false;
    }
    #endregion
    #region Задача 14
    // 14. Реализовать метод возвращающий разность между НОК и НОД для двух чисел
    static void Task14()
    {
        Console.WriteLine("Задача 14");
        Console.WriteLine("Число");
        string? input = Console.ReadLine();
        Console.WriteLine("Число");
        string? inputSecond = Console.ReadLine();
        if (int.TryParse(input, out int numberA) && int.TryParse(inputSecond, out int numberB))
        {
            Console.WriteLine(MethodNOKNOD(numberA, numberB));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static int MethodNOKNOD(int numberA, int numberB)
    {
        int NOD = 1;
        int NOK = 1;
        int minNumber = numberA > numberB ? numberB : numberA;
        int maxNumber = numberA * numberB;
        for (int i = 1; i <= minNumber; i++)
        {
            if (numberA % i == 0 && numberB % i == 0)
            {
                NOD = i;
            }
        }
        for (int i = 1; i <= maxNumber; i++)
        {
            if (i % numberA == 0 && i % numberB == 0)
            {
                NOK = i;
                break;
            }
        }
        Console.WriteLine($"NOD - {NOD}");
        Console.WriteLine($"NOK - {NOK}");
        return NOK - NOD;
    }

    #endregion
    #region Задача 15
    // 15. Реазуйте методы перевода чисел из десятичной системы счисления в 2-ую и 16-ую
    static void Task15()
    {
        Console.WriteLine("Задача 15");
        Console.WriteLine("Введите число");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("error");
        }
    }
    static string MethodConvertBinary(int number)
    {
        string result = "";


        return result;
    }
    static bool MethodConvert16numsys(int number)
    {

        return false;
    }
    #endregion
}
// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }
    #region Задача 1
    //     1. Написать методы с ипользованием лямбда-оператора по выполнению
    // арифметических операций (+, -, /, *, % и другие). Вызов данных методов произвести
    // с использованием тернарного switch в методе.
    static void Task1()
    {
        int number1 = 10;
        int number2 = 22;
        string? opr = Console.ReadLine();
        if (!string.IsNullOrEmpty(opr))
        {
            System.Console.WriteLine(Switch(opr: opr, number1: number1, number2: number2));
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    static int MethodSum(int number, int number1) => number + number1;
    static int MethodDeference(int number, int number1) => number - number1;
    static int MethodMultiplication(int number, int number1) => number * number1;
    static int MethodDivision(int number, int number1) => number / number1;

    static string Switch(int number1, int number2, string opr) => opr switch
    {
        "+" => MethodSum(number1, number2).ToString(),
        "-" => MethodDeference(number1, number2).ToString(),
        "*" => MethodMultiplication(number1, number2).ToString(),
        "/" => MethodDivision(number1, number2).ToString(),
        _ => string.Format("No resultations {0}", opr)
    };
    #endregion
    #region Задача 2
    // 2. Написать метод по рассчету средней скорости на участке и выводе сообщения
    // превысил водитель скорость или нет. Метод должен принимать во сколько
    // водитель въехал в участок контроля скорости и время во сколько выехал из
    // участка, в виде HH:MM:SS, длинну учатска контроля скорости и среднюю
    // допустимую скорость участка
    // В задаче использовать необязательные парметры, локальные методы.
    static void Task2()
    {
        Console.WriteLine("Задача 2");
        Console.WriteLine("Введите время старта HH:MM:SS");
        string? input = Console.ReadLine();
        Console.WriteLine("Введите время финиша HH:MM:SS");
        string? input2 = Console.ReadLine();
        if (!string.IsNullOrEmpty(input) && !string.IsNullOrEmpty(input2))
        {
            MetSpeed(input, input2, roadLength: 5);
        }
        else
        {
            Console.WriteLine("error input");
        }
    }
    static void MetSpeed(string timeStart, string timeFinish, double roadLength = 1, double topspeed = 90)
    {
        double startT = convertorTime(timeStart);
        double finishT = convertorTime(timeFinish);
        if (startT < finishT)
        {
            double averageSpeed = roadLength / (finishT - startT);
            if (averageSpeed > (topspeed + 10))
            {
                Console.WriteLine($"Водитель превысел скорость на {averageSpeed - topspeed}");
            }
            else
            {
                Console.WriteLine($"водитель не нарушал, средняя скорость {averageSpeed}, разрешенная {topspeed}");

            }
        }
        else
        {
            Console.WriteLine("error input");
        }
        double convertorTime(string time)
        {
            time.Trim();
            string[] arrayTime = time.Split(":");
            double hour = Convert.ToDouble(arrayTime[0]);
            double minuts = Convert.ToDouble(arrayTime[1]);
            double second = Convert.ToDouble(arrayTime[2]);
            double result = hour + minuts / 60 + second / 3600;
            return result;
        }
    }

    #endregion
    #region Задача 3 
    // 3. Написать метод увеличению размера массива и заполнения его значениями
    // В задаче использовать необязательные парметры, локальные методы.
    static void Task3()
    {
        Console.WriteLine("Задача 3");
        string[] text = { "new string[0]" };
        Console.WriteLine(string.Join(", ", text));
        object[] array = MetArrayConvert(text, 10, "string");
        Console.WriteLine(string.Join(", ", array));
    }

    static object[] MetArrayConvert(object[] array, int addlength = 1, string def = "0")
    {
        object[] newArray = new object[array.Length + addlength];
        Array.Copy(array, newArray, array.Length);
        for (int i = array.Length; i < newArray.Length; i++)
        {
            newArray[i] = def;
            Console.WriteLine(newArray[i]);
        }
        array = new object[array.Length + addlength];
        Array.Copy(newArray, array, newArray.Length);
        return array;
    }
    #endregion

    #region Задача 4
    // 4. Написать метод по расчету корней квадратного уравнения с использованием
    // локального метода
    static void Task4()
    {
        Console.WriteLine("Задача 4");
        Console.WriteLine("Введите число А для проверки: ");
        string? input1 = Console.ReadLine();
        Console.WriteLine("Введите число B для проверки: ");
        string? input2 = Console.ReadLine();
        Console.WriteLine("Введите число С для проверки: ");
        string? input3 = Console.ReadLine();
        Console.WriteLine($"Получившиеся уровнение дискриминанта: {input1}*x^2+{input2}*x+{input3}=0");
        if (double.TryParse(input1, out double numberA) &&
            double.TryParse(input2, out double numberB) &&
            double.TryParse(input3, out double numberC))
        {
            MetDiskriminant(numberA, numberB, numberC, out _, out _);
        }
        else
        {
            Console.WriteLine("error");
        }

    }
    static void MetDiskriminant(double numberA, double numberB, double numberC, out object? numberX1, out object? numberX2)
    {
        numberX1 = null;
        numberX2 = null;
        double resultDiscriminant = Math.Pow(numberB, 2) - 4 * numberA * numberC;
        if (resultDiscriminant > 0)
        {
            double rootnumberX1 = (-numberB + Math.Sqrt(resultDiscriminant) / (2 * numberA));
            double rootnumberX2 = (-numberB - Math.Sqrt(resultDiscriminant) / (2 * numberA));
            string message = rootnumberX1 > rootnumberX2 ? $"Корень X2: {rootnumberX2}. Корень X1: {rootnumberX1}." : $"Корень X1: {rootnumberX1}. Корень X2: {rootnumberX2}.";
            numberX1 = rootnumberX1;
            numberX2 = rootnumberX2;
            Console.WriteLine($"D = {resultDiscriminant}. {message}");
        }
        else if (resultDiscriminant == 0)
        {
            double rootnumberX1 = (-numberB) / (2 * numberA);
            numberX1 = rootnumberX1;
            Console.WriteLine($"D = 0, уровнение имеет один корень: {rootnumberX1}");
        }
        else
        {
            Console.WriteLine("D<0. Нет корней");
        }
    }

    #endregion
}

// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        Task1();
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
    #endregion
    #region Задача 3 
    // 3. Написать метод увеличению размера массива и заполнения его значениями
    // В задаче использовать необязательные парметры, локальные методы.
    #endregion
    #region Задача 4
    // 4. Написать метод по расчету корней квадратного уравнения с использованием
    // локального метода
    #endregion
}

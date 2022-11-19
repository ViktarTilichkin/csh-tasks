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
        Task3();
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
}
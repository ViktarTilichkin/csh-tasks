// // 1. Объявить оперменные и поменять в их значения три раза (string, int, bool, double)

{
    Console.WriteLine("Задача №1 ");
    string text = "asd";
    int number = 1;
    double numberB = 99.1;
    bool istrue = !int.TryParse(text, out _);
    Console.WriteLine($"Text = {text} Int = {number} Double = {numberB} Bool = {istrue}");
    text += "121";
    number = number * (int)numberB;
    numberB = number * 3;
    istrue = istrue == true ? false : true;
    Console.WriteLine($"Text = {text} Int = {number} Double = {numberB} Bool = {istrue}");
}
// // 2. Произвести все все комбинации неявного преобразования (byte, int, long, float, double, decimal)

{
    Console.WriteLine("Задача 2");
    byte number = 199;
    Console.WriteLine($"Введено число {number} ");
    int numberInt = number;
    long numberLong = numberInt;
    float numberFloat = numberLong;
    double numberDouble = numberFloat;
    decimal numberDecimal = (decimal)numberDouble;
    Console.WriteLine(number.GetType());
    Console.WriteLine(numberInt.GetType());
    Console.WriteLine(numberLong.GetType());
    Console.WriteLine(numberFloat.GetType());
    Console.WriteLine(numberDouble.GetType());
    Console.WriteLine(numberDecimal.GetType());
}

// // 3. Произвести все все комбинации явного преобразования (byte, int, long, float, double, decemel)

{
    Console.WriteLine("Задача 2");
    decimal numberDecimal = 199;
    Console.WriteLine($"Введено число {numberDecimal} ");
    double numberDouble = (double)numberDecimal;
    float numberFloat = (float)numberDouble;
    long numberLong = (long)numberFloat;
    int numberInt = (int)numberLong;
    byte numberByte = (byte)numberInt;
    Console.WriteLine(numberDecimal.GetType());
    Console.WriteLine(numberDouble.GetType());
    Console.WriteLine(numberFloat.GetType());
    Console.WriteLine(numberLong.GetType());
    Console.WriteLine(numberInt.GetType());
    Console.WriteLine(numberByte.GetType());
}

// // 4. Ввести два числа, произвести арифметические над числами и 
// // записать результат в первое число (+, -, /, *, %)

{
    Console.WriteLine("Задачана №4");
    Console.WriteLine("Введите число 1");
    string? input1 = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    string? input2 = Convert.ToString(Console.ReadLine());
    if (int.TryParse(input1, out int numberA) && int.TryParse(input2, out int numberB))
    {
        numberA = (numberA + (numberB - numberA / numberB) * numberB) % numberB;
        Console.WriteLine($"Результат: {numberA}");
    }
    else
    {
        Console.WriteLine("Введено не число");
    }
}

// // 5. Ввести число и увеличить его на 1 всеми доступными способами

{
    Console.WriteLine("Задачана №5");
    Console.WriteLine("Введите число для увеленичения на 1");
    int input1 = Convert.ToInt32(Console.ReadLine());
    input1 = input1 + 1;
    input1++;
    input1 += 1;
    ++input1;
    Console.WriteLine(input1);
}

// // 6. Ввести строку, если строка число найти остаток от деления на 5, в противном случае вывести 
// // сообщение, что введено не число

{
    Console.WriteLine("Задачана №6");
    Console.WriteLine("Введите число ");
    string? input1 = Convert.ToString(Console.ReadLine());
    if (int.TryParse(input1, out int numberA))
    {
        Console.WriteLine($" введено число {numberA} остаток от деления на 5: {numberA % 5}");
    }
    else
    {
        Console.WriteLine("Введено не число");
    }
}

// // 7. Ввести две строки, если строки числа вывести их сумму, в противном случае вывести сообщение 
// // какие строки не являются числом

{
    Console.WriteLine("Задачана №7");
    Console.WriteLine("Введите число 1 ");
    string? input1 = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите число 2 ");
    string? input2 = Convert.ToString(Console.ReadLine());
    if (int.TryParse(input1, out _) && int.TryParse(input2, out int _))
    {
        Console.WriteLine($"Сумма чисел: {input1 + input2}");
    }
    else
    {
        string message1 = int.TryParse(input1, out _) ? "число 1 введено верно" : "вместо числа 1 ввели строку";
        string message2 = int.TryParse(input2, out _) ? "число 2 введено верно" : "вместо числа 2 ввели строку";
        Console.WriteLine($"{message1}, {message2}");
    }
}

// 8. Ввести два числа, если 1 число больше 2, то произвести деление 1 на 2, если 2 больше 1 вывести
//  разность между 2 и 1, в противном случае вернуть 0.0 и 
// результат увеличить на 10 (if-else, тернаный оператор)

{
    Console.WriteLine("Задачана №8");
    Console.WriteLine("Введите число 1 ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2 ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result;
    if (numberA > numberB)
    {
        result = numberA / numberB;
    }
    else if (numberB > numberA)
    {
        result = numberB - numberA;
    }
    else
    {
        result = 0;
        Console.WriteLine("Вывели 0.0");
    }
    string resultTernar = numberA > numberB ? $"{numberA / numberB + 10}" : $"{numberB - numberA - 10}";
    Console.WriteLine($"Результат {result} и {resultTernar}");
}

// 9. Ввести две строки, если две строки числа то ввести арифметический оператор, b в зависисмоти 
// от арфметического оператора произвести то действие в проитивных случаях произвести вывод сообщений.
//  Сделать проверку на null оператора (if-else, switch, сокращенный switch)

{
    Console.WriteLine("Задачана №9");
    Console.WriteLine("Введите число 1 ");
    string? input1 = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите число 2 ");
    string? input2 = Convert.ToString(Console.ReadLine());
    double result = 0;
    if (int.TryParse(input1, out int numberA) && int.TryParse(input2, out int numberB))
    {
        Console.WriteLine("Введите оператор + - * / %");
        string? oper = Convert.ToString(Console.ReadLine());
        if (!(oper == null))
            switch (oper)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
                case "%":
                    result = numberA % numberB;
                    break;
                default:
                    Console.WriteLine("Не верный оператор");
                    break;

            }
        else
        {
            Console.WriteLine("оператор не обнаружен");
        }
        Console.WriteLine($"Арифметический результат: {result}");
    }
    else
    {
        Console.WriteLine($"Ошибка ввода");
    }
}
// 10. Ввести две строку и произвести сложение данных строк всеми известными способами
{
    Console.WriteLine("Задачана №10");
    Console.WriteLine("Введите строку 1 ");
    string? input1 = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите строку 2 ");
    string? input2 = Convert.ToString(Console.ReadLine());
    string result1 = input1 + input2;
    input1 += input2;
    Console.WriteLine($"результат способа 1: {result1}. Результат способа 2: {input1}");
}

// 11. Ввести строку до 5 символов, если строка число то вывести для кажкой цифры в числе кратно оно двум либо нет, 
// то есть 6352 => 6 крастно двум, 3 не кратно двум, 5  не кратно двум, 2  крастно двум (if-else, тернаный оператор)
{
    Console.WriteLine("Задачана №11");
    Console.WriteLine("Введите строку 1 ");
    string? input1 = Convert.ToString(Console.ReadLine());
    string message = "";
    string message1 = "";
    string message2 = "";
    string message3 = "";
    string message4 = "";
    if (!(input1 == null))
    {
        if ((input1.Length == 5) && int.TryParse(input1, out _))
        {
            message = input1[0] % 2 == 0 ? $"{input1[0]} кратно двум" : $"{input1[0]} не кратно двум";
            message1 = input1[1] % 2 == 0 ? $"{input1[1]} кратно двум" : $"{input1[1]} не кратно двум";
            message2 = input1[2] % 2 == 0 ? $"{input1[2]} кратно двум" : $"{input1[2]} не кратно двум";
            message3 = input1[3] % 2 == 0 ? $"{input1[3]} кратно двум" : $"{input1[3]} не кратно двум";
            message4 = input1[4] % 2 == 0 ? $"{input1[4]} кратно двум" : $"{input1[4]} не кратно двум";

        }
        else if ((input1.Length == 4) && int.TryParse(input1, out _))
        {
            message = input1[0] % 2 == 0 ? $"{input1[0]} кратно двум" : $"{input1[0]} не кратно двум";
            message1 = input1[1] % 2 == 0 ? $"{input1[1]} кратно двум" : $"{input1[1]} не кратно двум";
            message2 = input1[2] % 2 == 0 ? $"{input1[2]} кратно двум" : $"{input1[2]} не кратно двум";
            message3 = input1[3] % 2 == 0 ? $"{input1[3]} кратно двум" : $"{input1[3]} не кратно двум";
        }
        else if ((input1.Length == 3) && int.TryParse(input1, out _))
        {
            message = input1[0] % 2 == 0 ? $"{input1[0]} кратно двум" : $"{input1[0]} не кратно двум";
            message1 = input1[1] % 2 == 0 ? $"{input1[1]} кратно двум" : $"{input1[1]} не кратно двум";
            message2 = input1[2] % 2 == 0 ? $"{input1[2]} кратно двум" : $"{input1[2]} не кратно двум";
        }
        else if ((input1.Length == 2) && int.TryParse(input1, out _))
        {
            message = input1[0] % 2 == 0 ? $"{input1[0]} кратно двум" : $"{input1[0]} не кратно двум";
            message1 = input1[1] % 2 == 0 ? $"{input1[1]} кратно двум" : $"{input1[1]} не кратно двум";
        }
        else if ((input1.Length == 1) && int.TryParse(input1, out _))
        {
            message = input1[0] % 2 == 0 ? $"{input1[0]} кратно двум" : $"{input1[0]} не кратно двум";
        }
        else
        {
            Console.WriteLine("Слишком длинное число");
        }
    }
    else
    {
        Console.WriteLine("Пустота");
    }
    Console.WriteLine($"Проверка на кратрность {message} {message1} {message2} {message3} {message4}");
}
{
    Console.WriteLine("Задачана №11");
    Console.WriteLine("Введите строку до 5 цифр ");
    string? input1 = Convert.ToString(Console.ReadLine());
    string thousand = "";
    string hundred = "";
    string desatki = "";
    string chislo = "";
    if (!(input1 == null) && int.TryParse(input1, out int number))
    {
        if (number > 999) { thousand = (number / 1000) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        if (number > 99) { hundred = ((number % 1000) / 100) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        if (number > 9) { desatki = ((number % 100) / 10) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        if (number > 0) { chislo = (number % 10) % 2 == 0 ? "кратно двум" : "не кратно двум"; }
        Console.WriteLine($"Проверка на кратность двум: {thousand} {hundred} {desatki} {chislo}");
    }
    else 
    Console.WriteLine("Не удача");
}

// 12. Ввести две строки, произвести проврку на пустоту, если строки имеют символы то если первая строка больше 
// второй вывести сумму длин строк, в противном случае разность 2 от первой
//  (if-else, тернаный оператор, *.Length, string.IsNullorEmpty)
{
    Console.WriteLine("Задачана №12");
    Console.WriteLine("Введите строку 1 ");
    string? input1 = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите строку 2 ");
    string? input2 = Convert.ToString(Console.ReadLine());
    string message;
    if (!(input2 == null))
    {
        if (!(input1 == null))
        {
            int lengthA = input1.Length;
            int lengthB = input2.Length;
            message = lengthA > lengthB ? $"Сумма {lengthA + lengthB}" : $"Разность {lengthB - lengthA}";
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Строка один пустота");
        }
    }

    else
    {
        Console.WriteLine("Строка два пустота");
    }

}
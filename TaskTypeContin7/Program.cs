// 1. Объявить оперменные и поменять в их значения три раза (string, int, bool, double)

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
// 2. Произвести все все комбинации неявного преобразования (byte, int, long, float, double, decimal)
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

// 3. Произвести все все комбинации явного преобразования (byte, int, long, float, double, decemel)
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
// 4. Ввести два числа, произвести арифметические над числами и 
// записать результат в первое число (+, -, /, *, %)
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
// 5. Ввести число и увеличить его на 1 всеми доступными способами
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
// 6. Ввести строку, если строка число найти остаток от деления на 5, в противном случае вывести 
// сообщение, что введено не число
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
// 7. Ввести две строки, если строки числа вывести их сумму, в противном случае вывести сообщение 
// какие строки не являются числом
{
    Console.WriteLine("Задачана №7");
    Console.WriteLine("Введите число 1 ");
    string? input1 = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Введите число 2 ");
    string? input2 = Convert.ToString(Console.ReadLine());
    if (int.TryParse(input1, out int numberA) && int.TryParse(input2, out int numberB))
    {
        Console.WriteLine($"Сумма чисел: {numberA + numberB}");
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
// 11. Ввести строку до 5 символов, если строка число то вывести для кажкой цифры в числе кратно оно двум либо нет, 
// то есть 6352 => 6 крастно двум, 3 не кратно двум, 5  не кратно двум, 2  крастно двум (if-else, тернаный оператор)
// 12. Ввести две строки, произвести проврку на пустоту, если строки имеют символы то если первая строка больше 
// второй вывести сумму длин строк, в противном случае разность 2 от первой
//  (if-else, тернаный оператор, *.Length, string.IsNullorEmpty)
// 1. Найти максимальное число из 2 введенных (2 способа)

{
    Console.WriteLine("Задача 1. ");
    Console.WriteLine("Введите число 1: ");
    double numberA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите число 2: ");
    double numberB = Convert.ToDouble(Console.ReadLine());
    string messageOne = numberA > numberB ? "Число 1 больше числа 2." : "Число 2 больше числа 1.";
    Console.WriteLine($"{messageOne}");
    double numberMax = Math.Max(numberA, numberB);
    Console.WriteLine($"Число {numberMax} больше");
}

// 2. Выявить является ли введенное число четным

{
    Console.WriteLine("Задача 2. ");
    Console.WriteLine("Введите число для проверки на четность: ");
    double number = Convert.ToDouble(Console.ReadLine());
    string result = number % 2 == 0 ? "Число четное" : "Число не четное";
    Console.WriteLine(result);
}

// 3. Пользователь вводит число от 1 до 7, соответствующее дню недели. Необходимо
// вывести день для введенного числа.
// 1 -> Понедельник

{
    Console.WriteLine("Задача 3. ");
    Console.WriteLine("Введите день недели: ");
    double number = Convert.ToDouble(Console.ReadLine());
    switch (number)
    {
        case 1:
            Console.WriteLine("Понедельник");
            break;
        case 2:
            Console.WriteLine("Вторник");
            break;
        case 3:
            Console.WriteLine("Среда");
            break;
        case 4:
            Console.WriteLine("Четверг");
            break;
        case 5:
            Console.WriteLine("Пятница");
            break;
        case 6:
            Console.WriteLine("Суббота");
            break;
        case 7:
            Console.WriteLine("Воскресенье");
            break;
        default:
            Console.WriteLine("Дня недели под таким номером нет!");
            break;
    }
}

// 4.Есть строка в 3 символа. Написать проверку если число, вывести true, в
// противном случае false (Char.IsDigit(str2, position))

{
    Console.WriteLine("Задача 4. ");
    Console.WriteLine("Введите данные для проверки на число: ");
    var number = Console.ReadLine();
    bool result = Char.IsDigit(number, 3);
    Console.WriteLine(result);
}

// 5. Пользователь вводит число с клавиатуры. Нужно вывести на экран сколько в этом
// числе цифр, а также положительное оно или отрицательное. Например, "Число " +
// num + " однозначное положительное". (Length)

{
    Console.WriteLine("Задача номер 5.");
    Console.WriteLine("Введите число: ");
    double number = Convert.ToDouble(Console.ReadLine());
    int result = (Convert.ToString(number)).Length;
    string message5 = number > 0 ? $"В числе {number} количество знаков {result} и оно положительное" : $"В числе {number} количество знаков {result - 1} и оно отрицательно";
    Console.WriteLine(message5);
}
{
    Console.WriteLine("Задача номер 5.");
    Console.WriteLine("Введите число: ");
    string? text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
    if (number > 0)
    {
        Console.WriteLine($"В числе {number} количество знаков {text.Length} и оно положительное");
    }
    else
    {
        Console.WriteLine($"В числе {number} количество знаков {text.Length - 1} и оно отрицательно");
    }
    }
    else
    {
        Console.WriteLine("Введен текст");
    }
}

// 6. Найти квадратный корень числа. Если же число без плавающей точки, то просто
// вывести его. В противном случае необходимо округлить число до целых.
// Добавить проверку на ввод только чисел

{
    Console.WriteLine("Задача номер 6.");
    Console.WriteLine("Введите число: ");
    double number = Convert.ToDouble(Console.ReadLine());
    int result = Convert.ToInt32(Math.Sqrt(number));
    Console.WriteLine($"Корень вашего числа: {result}");
}

// 7. Два автомобиля едут друг к другу с постоянными скоростями V1 и V2 км/ч.
// Определите, через какое время автомобили встретятся, если расстояние между
// ними равно S км. Добавить проверку на ввод только чисел

{
    Console.WriteLine("Задача номер 7.");
    Console.WriteLine("Введите скорость первого автомобиля: ");
    double speedcar1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите скорость второго автомобиля: ");
    double speedcar2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите расстояние между автомобилями: ");
    double distance = Convert.ToDouble(Console.ReadLine());
    int result = Convert.ToInt32((distance / (speedcar1 + speedcar2)) * 60);
    Console.WriteLine($"Автомобили встретятся через {result} минут");
}

// 8. Пользователь вводит номер месяц. Необходимо вывести пору года по номеру
// месяца (2 способа)

{
    Console.WriteLine("Задача номер 8.");
    Console.WriteLine("Номер месяца: ");
    int numberMonth = Convert.ToInt32(Console.ReadLine());
    if (numberMonth >= 1 && numberMonth <= 2 || numberMonth == 12)
    {
        Console.WriteLine("Зима");
    }
    else if (numberMonth >= 3 && numberMonth <= 5)
    {
        Console.WriteLine("Весна");
    }
    else if (numberMonth >= 6 && numberMonth <= 8)
    {
        Console.WriteLine("Лето");
    }
    else if (numberMonth >= 9 && numberMonth <= 11)
    {
        Console.WriteLine("Осень");
    }
    else
    {
        Console.WriteLine("не верный месяц");
    }
    switch (numberMonth)
    {
        case 1:
        case 2:
        case 12:
            Console.WriteLine("Зима");
            break;
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Весна");
            break;
        case 6:
        case 7:
        case 8:
            Console.WriteLine("Лето");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("Осень");
            break;
        default:
            Console.WriteLine("Не верное число");
            break;
    }
}

// 9. Пользователь вводит число: 1, 2, 3 или 4. Если это значение ‘2', то вывести в
// консоль 'зима близко', ‘3' – зима, ‘4' – всё' . Решите задачу через switch-case.
{
    Console.WriteLine("Задача номер 9.");
    Console.WriteLine("Число от 1 до 4: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string result = number switch
    {
        1 => "осень",
        2 => "зима близко",
        3 => "зима",
        4 => "все",
        _ => "ошибочка"
    };
    Console.WriteLine(result);
}

// 10. Пользователь вводит одно число. Необходимо вывести обратное ему (число
// является обратным при 1/x). Если при этом введённое с клавиатуры число – ноль,
// то вывести «Обратного числа не существует».
{
    Console.WriteLine("Задача номер 10.");
    Console.WriteLine("Введите число: ");
    double number = Convert.ToDouble(Console.ReadLine());
    string message10 = !(number == 0) ? $"обратное число 1/{number}" : "обратного числа не существует";
    Console.WriteLine(message10);
}

// 11. Напишите программу, которая находит полное число метров по заданному числу
// сантиметров. Добавить проверку на ввод только чисел 345 -> 3 100 -> 1

{
    Console.WriteLine("номер задачи 11");
    Console.WriteLine("Введите длинну в сантиметрах ");
    double distance = Convert.ToInt32(Console.ReadLine());
    distance = (int)distance / 100;
    string message11 = distance >= 1 ? $"Метров {distance}" : $"Меньше одного метра";
    Console.WriteLine(message11);
}

// // 12. Напишите программу, в которой рассчитывается сумма и произведение цифр
// // положительного трёхзначного числа 123 -> Сумма цифр = 6 Произведение цифр = 6

{
    Console.WriteLine("номер задачи 12");
    Console.WriteLine("Введите трех значное число ");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number / 100;
    int num2 = (number % 100) / 10;
    int num3 = number % 10;
    int resultSumm = num1 + num2 + num3;
    int resultMulti = num1 * num2 * num3;
    Console.WriteLine($"Числа {num1} {num2} {num3}");
    Console.WriteLine($"Сумма {resultSumm} Произведение {resultMulti}");
}

// 13. Пользователь вводит четырехзначное число. Напишите код, который будет
// выявлять является ли каждое составляющее числа четным либо нечетным.
// Добавить проверку на ввод только чисел
// 1234 -> 1 – неч 2 – чет 3 – неч 4 - чет

{
    Console.WriteLine("номер задачи 13");
    Console.WriteLine("Введите четырёх значное число ");
    int number = Convert.ToInt32(Console.ReadLine());
    int num1 = number / 1000;
    int num2 = (number % 1000) / 100;
    int num3 = (number % 100) / 10;
    int num4 = number % 10;
    string messagenum1 = num1 % 2 == 0 ? "четное" : "нечетное";
    string messagenum2 = num2 % 2 == 0 ? "четное" : "нечетное";
    string messagenum3 = num3 % 2 == 0 ? "четное" : "нечетное";
    string messagenum4 = num4 % 2 == 0 ? "четное" : "нечетное";
    Console.WriteLine($"Числа {num1} - {messagenum1}  {num2} - {messagenum2}  {num3} - {messagenum3} {num4} - {messagenum4}");
}

// 14. Пользователь вводит 2 числа от 0 до 10. Сложите переменные так, чтобы в
// результате получилось выражение: “I’m хх". Проверки на ввод только чисел.
// Проверки на ввод чисел до 10. Если первое число – 0, то опустить его

{
    Console.WriteLine("номер задачи 14");
    Console.WriteLine("Введите число от 0 до 10 ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число от 0 до 10 ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    string message = number1 == 0 ? $"I'm {number2}" : $"I'm {number1}{number2}";
    Console.WriteLine(message);
}

// 15. Пользователь вводит строку. Необходимо сделать проверку, что это не число и
// вывести длину строки

{
    Console.WriteLine("Задача номер 15.");
    Console.WriteLine("Введите строку ");
    string? text = Console.ReadLine();
    if (!int.TryParse(text, out _)) // "_" игнорируем объявление переменной
    {
        if (!string.IsNullOrEmpty(text)) //(text != null) "" // string.IsNullOrEmpty(text) првоеряет на пустое значение если пустое то true
        {
            Console.WriteLine($"Длинна строки {text.Length}");
        }
        else
        {
            Console.WriteLine("пустота");
        }
    }
    else
    {
        Console.WriteLine("ввели число");
    }
}
{
    Console.WriteLine("Задача номер 15.");
    Console.WriteLine("Введите строку ");
    string? text = Console.ReadLine();
    if (!int.TryParse(text, out _)) // "_" игнорируем объявление переменной
    {
        string message = !string.IsNullOrEmpty(text) ? $"Длинна строки {text.Length}" : "пустота";
        Console.WriteLine(message);
    }
    else
    {
        Console.WriteLine("ввели число");
    }
}

// 16. Пользователь вводит строку. Вывести первый символ строки (индексы)

{
    Console.WriteLine("Задача номер 16.");
    Console.WriteLine("Введите строку ");
    string? number = Console.ReadLine();
    //   string message = number[0];
    //   Console.WriteLine($"Первый символ строки {message}");
}
// 17. Пользователь вводит строку. Необходимо сделать проверку, что это не число и
// вывести текущую строку в большом регистре

{
    Console.WriteLine("Задача номер 17.");
    Console.WriteLine("Введите строку ");
    string? number = Console.ReadLine();
    Console.WriteLine(number.ToUpper());
}

// 18. Пользователь вводит строку. Необходимо повторить ее трижды

{
    Console.WriteLine("Задача номер 18.");
    Console.WriteLine("Введите строку ");
    string? number = Console.ReadLine();
    Console.WriteLine(number + number + number);
}

// 19. Ввести строку. Проверить является ли это число или текст. Если число, то
// выяснить, четное или нет. Если это текст и равен “hschool”, вывести true. В
// противном случае false

{
    Console.WriteLine("Задача номер 19.");
    Console.WriteLine("Введите строку ");
    string? number = Console.ReadLine();
    string numberTrue = "hschool";
    int result = string.Compare(number, numberTrue);
    if (result == 0)
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}
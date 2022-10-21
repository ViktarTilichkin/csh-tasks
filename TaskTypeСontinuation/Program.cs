// // 1. Вы вводите значение с клавиатуры. Если значение равно 0, то вывести ‘Ноль’,
// // если < 0, то вывести ‘Отрицательное’, если > 0, то вывести ‘Положительное’

// {
//     Console.WriteLine("Задача номер 1");
//     Console.WriteLine("Введите число для проверки: ");
//     double number = Convert.ToDouble(Console.ReadLine());
//     string message;
//     if (number > 0)
//     {
//         message = "Положительное";
//     }
//     else if (number < 0)
//     {
//         message = "Отрицательно";
//     }
//     else
//     {
//         message = "Ноль";
//     }
//     Console.WriteLine(message);
// }

// // // 2. Вы вводите значение с клавиатуры. Если значение четное, то вывести true, в
// // // противном случае false

// {
//     Console.WriteLine("Задача номер 2");
//     Console.WriteLine("Введите число для проверки: ");
//     double number = Convert.ToDouble(Console.ReadLine());
//     string message;
//     message = number % 2 == 0 ? "true" : "false";
//     Console.WriteLine(message);
// }

// // // 3. Пользователь вводит с клавиатуры число. Найдите корень введенного числа
// // // (если же результат – число с плавающей точкой, то округлить до 2 знаков после
// // // запятой).

// {
//     Console.WriteLine("Задача номер 3");
//     Console.WriteLine("Введите число для проверки: ");
//     double number = Convert.ToDouble(Console.ReadLine());
//     double result = Math.Round(Math.Sqrt(number), 2);
//     Console.WriteLine(result);
// }

// // 4. Пользователь вводит с клавиатуры 2 числа: a и b. Проверьте, что a делится без
// // остатка на b. Если это так - выведите 'Делится' и результат деления, иначе
// // выведите 'Делится с остатком' и остаток от деления

// {
//     Console.WriteLine("Задача номер 4");
//     Console.WriteLine("Введите число А для проверки: ");
//     double numberA = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите число B для проверки: ");
//     double numberB = Convert.ToDouble(Console.ReadLine());
//     double result;
//     if (numberA % numberB == 0)
//     {
//         result = numberA / numberB;
//         Console.WriteLine($"Делиться целиком, резульат: {result}");
//     }
//     else
//     {
//         result = numberA % numberB;
//         Console.WriteLine(result);
//         Console.WriteLine($"Делиться с остатком, остаток: {result}");
//     }
// }

// // 5. Пользователь вводит с клавиатуры число. Найдите корень введенного числа
// // (если же результат – число с плавающей точкой, то округлить то целых)

// {
//     Console.WriteLine("Задача номер 5");
//     Console.WriteLine("Введите число для проверки: ");
//     double number = Convert.ToDouble(Console.ReadLine());
//     double result = Math.Round(Math.Sqrt(number), 0);
//     Console.WriteLine(result);
// }
// 6. Даны три числа a, b, c. Напишите программу, которая находит корни квадратного
// уравнения
// ax^2 + bx + c = 0
// Если уравнение имеет два корня, то следует вывести их в порядке возрастания.

// {
//     Console.WriteLine("Задача номер 6");
//     Console.WriteLine("Введите число А для проверки: ");
//     double numberA = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите число B для проверки: ");
//     double numberB = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите число С для проверки: ");
//     double numberС = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine($"Получившиеся уровнение дискриминанта: {numberA}*x^2+{numberB}*x+{numberС}=0");
//     double resultDiscriminant = Math.Pow(numberB, 2) - 4 * numberA * numberС;
//     if (resultDiscriminant > 0)
//     {
//         double rootnumberX1 = (-numberB + Math.Sqrt(resultDiscriminant) / (2 * numberA));
//         double rootnumberX2 = (-numberB - Math.Sqrt(resultDiscriminant) / (2 * numberA));
//         string message = rootnumberX1 > rootnumberX2 ? $"Корень X1: {rootnumberX1}. Корень X2: {rootnumberX2}." : $"Корень X2: { rootnumberX2}. Корень X1: { rootnumberX1}.";
//         Console.WriteLine($"D = {resultDiscriminant}. {message}");
//     }
//     else if (resultDiscriminant == 0)
//     {
//         double rootnumberX1 = (-numberB) / (2 * numberA);
//         Console.WriteLine($"D = 0, уровнение имеет один корень: {rootnumberX1}");
//     }
//     else
//     {
//         Console.WriteLine("D<0. Нет корней");
//     }
// }
// // 7. Пользователь вводит число от 1 до 9999 (сумму выдачи в банкомате). Необходимо
// // вывести на экран словами введенную сумму и в конце написать название валюты
// // с правильным окончанием. Например: 7431 – семь тысяч четыреста тридцать один
// // доллар, 2149 – две тысячи сто сорок девять долларов, 15 – пятнадцать долларов, 3 –
// // три доллара.

// {
//     Console.WriteLine("Задача номер 7");
//     Console.WriteLine("Введите число для выдачи: ");
//     double numberA = Convert.ToDouble(Console.ReadLine());
// }
// // 8. Пользователь вводит порядковый номер пальца руки. Необходимо показать его
// // название на экран.

{
    Console.WriteLine("Задача номер 8");
    Console.WriteLine("Номер пальца: ");
    int numberFinger = Convert.ToInt32(Console.ReadLine());
    if (numberFinger == 1)
    {
        Console.WriteLine("ваш большой палец");

    }
     else if (numberFinger == 2)
    {
        Console.WriteLine("ваш указательный палец");

    } 
    else if (numberFinger == 3)
    {
        Console.WriteLine("ваш средний палец");

    } 
    else if (numberFinger == 4)
    {
        Console.WriteLine("ваш безымянный палец");

    } 
    else if (numberFinger == 5)
    {
        Console.WriteLine("ваш мезинец");

    }
    else
    {
        Console.WriteLine("Нет такого пальца");
    }
}

// 9. Необходимо написать программу, которая проверяет пользователя на знание
// таблицы умножения. Пользователь сам вводит два целых однозначных числа.
// Программа задаёт вопрос: результат умножения первого числа на
// второе. Пользователь должен ввести ответ и увидеть на экране правильно он
// ответил или нет. Если нет – показать еще и правильный результат.

{
    Console.WriteLine("Задача номер 9");
}

// 10. Пользователь вводит два числа, если хотя бы одно число равно 0 то необходимо
// получить битовую инверсию числа не равного 0, если первое число больше 20,
// необходимо найти остаток от делания большего на меньшее, если второе меньше
// 0 найти модуль целой часть от деления первого числа на второе, если первое и
// второе числа чётные найти логическое битовое И для двух чисел, в противном
// случае логическое битовое ИЛИ. Для полученного результата произвести
// битовый сдвиг который укажет пользователь, если сдвиг четный, то сдвиг вправо,
// если нечетный влево. Полученный результат вывести на экран

{
    Console.WriteLine("Задача номер 10");
}
// Домашние задания с 4 дейли 
// 1. Даны переменные a=10 и b=3. Найдите остаток от деления a и b.

Console.WriteLine("Решаем задачу 1");
int a = 10;
int b = 3;
int result = a % b;
Console.WriteLine($"Остаток деления 10 на 3: {result}");

// 2. пользователь вводит с клавиатуры 2 числа: основание степени и показатель степени. 
// необходимо возвести число во введенную степень.

Console.WriteLine("Решаем задачу 2");
Console.Write("Ввидите число: ");
var box2 = Console.ReadLine();
int number = Convert.ToInt32(box2);
Console.Write("Введите степень: ");
var boxer2 = Console.ReadLine();
int degree = Convert.ToInt32(boxer2);
double result2 = Math.Pow(number, degree);
Console.WriteLine($"Число {number} в степени {degree} равно {result2}");

// 3. Напишите программу, которая считывает длины двух катетов в прямоугольном
// треугольнике и выводит его площадь. Используйте формулу: S=1/2 * a *b

Console.WriteLine("Решаем задачу 3");
Console.Write("Введите сторону A прямоугольного треугольника: ");
var box3 = Console.ReadLine();
int sideA = Convert.ToInt32(box3);
Console.Write("Введите сторону B прямоугольного треугольника: ");
var boxer3 = Console.ReadLine();
int sideB = Convert.ToInt32(boxer3);
int result3 = (sideA * sideB) / 2;
Console.WriteLine($"Площадь треугольника равна: {result3}");

// 4. У известного американского писателя Рэя Бредбери есть роман «451 градус по
// Фаренгейту». Напишите скрипт, который определяет, какой температуре по
// шкале Цельсия соответствует указанное значение по шкале Фаренгейта.
// Используйте формулу: C=5/9*(F-32)

Console.WriteLine("Решаем задачу 4");
Console.Write("Введите температуру в Фаренгейтах: ");
var box4 = Console.ReadLine();
double temp = Convert.ToDouble(box4);
double result4 = (5 * (temp - 32)) / 9;
Console.WriteLine($"Температура в градусах Цельсия: {result4}");

// 5. Даны переменные a и b. Проверьте, что a делится без остатка на b. Если это так -
// выведите 'Делится' и результат деления, иначе выведите 'Делится с остатком' и
// само значение деления 

Console.WriteLine("Решаем задачу 5");
Console.Write("Введите число A: ");
var box = Console.ReadLine();
int numberA = Convert.ToInt32(box);
Console.Write("Введите число B: ");
var boxer = Console.ReadLine();
int numberB = Convert.ToInt32(boxer);
int result5 = numberA / numberB;
int result51 = numberA % numberB;
if (result51 == 0)
{
    Console.WriteLine($"Делиться целиком. результат: {result5}");
}
else
{
    Console.WriteLine($"Делится с остатком. Результат: {result5} Остаток: {result51}");
}

// 6. Вы вводите 2 числа a и b. Вам необходимо решить пример (2(а-b)-4(b-a))/2

Console.WriteLine("Решаем задачу 6");
Console.Write("Введите первое число: ");
int numberA6 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB6 = Convert.ToInt32(Console.ReadLine());
int result6 = (2 * (numberA6 - numberB6) - 4 * (numberB6 - numberA6)) / 2;
Console.WriteLine($"Результат: {result6}");

// 7. На вход программе подается число n – количество собачьих лет. Напишите
// программу, которая вычисляет возраст собаки в человеческих годах.
// В течение первых двух лет собачий год равен 10.5 человеческим годам. После
// этого каждый год собаки равен 4 человеческим годам

Console.WriteLine("Решаем задачу 7");
Console.Write("Сколько лет вашей собаке? ");
double dog = Convert.ToDouble(Console.ReadLine());
if (dog <= 2 && dog >= 0)
{
    double result7 = dog * 10.5;
    Console.WriteLine($"В человечиских годах, вашей собаке: {result7}");
}
else
{
    double result7 = 10.5 * 2 + 4 * (dog - 2);
    Console.WriteLine($"В человечиских годах, вашей собаке: {result7}");
}

// 8. Найдите квадратный корень из 245. Предварительно изучите System.Math и в
// отдельности Math.Sqrt

Console.WriteLine("Решаем задачу 8");
double number8 = 245;
double result8 = Math.Sqrt(number8);
Console.WriteLine($"Корень числа 245, равен: {result8}");

// 9. Даны числа 4, -2, 5, 19, -130, 0, 10. Найдите минимальное и максимальное число.
// Предварительно изучите модуль Math и в отдельности Math.Min и Math.Max

Console.WriteLine("Решаем задачу 9");
int a9 = 4;
int b9 = -2;
int c9 = 5;
int d9 = 19;
int e9 = -130;
int f9 = 0;
int g9 = 10;
int resultMin = Math.Min(a9, Math.Min(b9, Math.Min(c9, Math.Min(d9, Math.Min(e9, Math.Min(f9, g9))))));
int resultMax = Math.Max(a9, Math.Max(b9, Math.Max(c9, Math.Max(d9, Math.Max(e9, Math.Max(f9, g9))))));
Console.WriteLine($"Минимальное число: {resultMin}. Максимальное число: {resultMax}");

// 10. Напишите программу, вычисляющую объём куба и площадь его полной
// поверхности, по введённому значению длины ребра. Используйте формулы: 
// V= a^2 (ошибка a^3), S = 6*a^2

Console.WriteLine("Решаем задачу 10");
Console.Write("Введите длину ребра куба: ");
double number10 = Convert.ToDouble(Console.ReadLine());
double resultVolume = Math.Pow(number, 3);
double resultSquare = 6 * Math.Pow(number, 2);
Console.WriteLine($"Объем куба: {resultVolume}. Полная площадь: {resultSquare}");

// 11. Напишите программу, в которой вычисляется сумма, разность и произведение
// двух целых чисел, введенных с клавиатуры.

Console.WriteLine("Решаем задачу 11");
Console.Write("Введите первое число: ");
int numberA11 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB11 = Convert.ToInt32(Console.ReadLine());
int summ = numberA11 + numberB11;
int minus = numberA11 - numberB11;
int multiply = numberA11 * numberB11;
Console.WriteLine($"Сумма чисел: {summ}. Разность чисел: {minus}. Произведение чисел: {multiply}.");

// 12. Напишите программу для пересчёта величины временного интервала, заданного
// в минутах, в величину, выраженную в часах и минутах:
// Пример: 150 => 2 час 30 минут \ 50 => 0 час 50 минут \ 240 => 4 час 0 минут

Console.WriteLine("Решаем задачу 12");
Console.Write("Ввидите количество минут: ");
int time = Convert.ToInt32(Console.ReadLine());
int hour = time / 60;
int minutes = time % 60;
Console.WriteLine($"Часов {hour} , минут {minutes}.");
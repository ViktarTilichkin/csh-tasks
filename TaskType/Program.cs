// Домашние задания с 4 дейли 
// 1. Даны переменные a=10 и b=3. Найдите остаток от деления a и b.

int  a = 10;
int b = 3;
int result = a % b;
Console.WriteLine($"Остаток деления 10 на 3: {result}");

// 2. пользователь вводит с клавиатуры 2 числа: основание степени и показатель степени. 
// необходимо возвести число во введенную степень.

Console.Write ("Ввидите число: ");
var box = Console.ReadLine();
double number = Convert.ToDouble(box);
Console.Write ("Введите степень: ");
var boxer = Console.ReadLine();
double degree = Convert.ToDouble(boxer);
double result = Math.Pow(number, degree);
Console.WriteLine($"Число {number} в степени {degree} равно {result}");

// 3. Напишите программу, которая считывает длины двух катетов в прямоугольном
// треугольнике и выводит его площадь. Используйте формулу: S=1/2 * a *b

Console.Write("Введите сторону A прямоугольного треугольника: ");
var box = Console.ReadLine();
int sideA = Convert.ToInt32(box);
Console.Write("Введите сторону B прямоугольного треугольника: ");
var boxer = Console.ReadLine();
int sideB = Convert.ToInt32(boxer);
int result = (sideA*sideB)/2;
Console.WriteLine($"Площадь треугольника равна: {result}");

// 4. У известного американского писателя Рэя Бредбери есть роман «451 градус по
// Фаренгейту». Напишите скрипт, который определяет, какой температуре по
// шкале Цельсия соответствует указанное значение по шкале Фаренгейта.
// Используйте формулу: C=5/9*(F-32)

Console.Write("Введите температуру в Фаренгейтах: ");
var box = Console.ReadLine();
double temp = Convert.ToDouble(box);
double result = (5*(temp-32))/9;
Console.WriteLine($"Температура в градусах Цельсия: {result}");

// 5. Даны переменные a и b. Проверьте, что a делится без остатка на b. Если это так -
// выведите 'Делится' и результат деления, иначе выведите 'Делится с остатком' и
// само значение деления 

Console.Write("Введите число A: ");
var box = Console.ReadLine();
int numberA = Convert.ToInt32(box);
Console.Write("Введите число B: ");
var boxer = Console.ReadLine();
int numberB = Convert.ToInt32(boxer);
int result = numberA / numberB;
int result2 = numberA % numberB;
if (result2 == 0)
{
    Console.WriteLine($"Делиться целиком. результат: {result}");
}
else
{
    Console.WriteLine($"Делится с остатком. Результат: {result} Остаток: {result2}");
}

// 6. Вы вводите 2 числа a и b. Вам необходимо решить пример (2(а-b)-4(b-a))/2

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = (2*(numberA-numberB)-4*(numberB-numberA))/2;
Console.WriteLine($"Результат: {result}");

// 7. На вход программе подается число n – количество собачьих лет. Напишите
// программу, которая вычисляет возраст собаки в человеческих годах.
// В течение первых двух лет собачий год равен 10.5 человеческим годам. После
// этого каждый год собаки равен 4 человеческим годам

Console.Write("Сколько лет вашей собаке? ");
double dog = Convert.ToDouble(Console.ReadLine());
if ( dog<=2 )
{
    double result = dog * 10.5;
    Console.WriteLine($"В человечиских годах, вашей собаке: {result}");
}
else
{
    double result = 10.5 * 2 + 4 * (dog-2);
    Console.WriteLine($"В человечиских годах, вашей собаке: {result}");
}

// 8. Найдите квадратный корень из 245. Предварительно изучите System.Math и в
// отдельности Math.Sqrt

double number = 245; 
double result = Math.Sqrt(number);
Console.Write($"Корень числа 245, равен: {result}");

// 9. Даны числа 4, -2, 5, 19, -130, 0, 10. Найдите минимальное и максимальное число.
// Предварительно изучите модуль Math и в отдельности Math.Min и Math.Max

int a = 4;
int b = -2;
int c = 5; 
int d = 19;
int e = -130;
int f = 0;
int g = 10;
int resultMin = Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, Math.Min(e, Math.Min(f, g))))));
int resultMax = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, Math.Max(e, Math.Max(f, g))))));
Console.WriteLine($"Минимальное число: {resultMin}. Максимальное число: {resultMax}");

// 10. Напишите программу, вычисляющую объём куба и площадь его полной
// поверхности, по введённому значению длины ребра. Используйте формулы: 
// V= a^2 (ошибка a^3), S = 6*a^2

Console.Write("Введите длину ребра куба: ");
double number = Convert.ToDouble(Console.ReadLine());
double resultV = Math.Pow(number, 3);
double resultS = 6 * Math.Pow(number, 2);
Console.WriteLine($"Объем куба: {resultV}. Полная площадь: {resultS}");

// 11. Напишите программу, в которой вычисляется сумма, разность и произведение
// двух целых чисел, введенных с клавиатуры.

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int summ = numberA + numberB;
int minus = numberA - numberB;
int multiply = numberA * numberB;
Console.WriteLine($"Сумма чисел: {summ}. Разность чисел: {minus}. Произведение чисел: {multiply}.");

// 12. Напишите программу для пересчёта величины временного интервала, заданного
// в минутах, в величину, выраженную в часах и минутах:
// Пример: 150 => 2 час 30 минут \ 50 => 0 час 50 минут \ 240 => 4 час 0 минут

Console.Write("Ввидите количество минут: ");
int time = Convert.ToInt32(Console.ReadLine());
int hour = time/60;
int minutes = time % 60;
Console.WriteLine($"Часов {hour} , минут {minutes}.");
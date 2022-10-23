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
// // 6. Даны три числа a, b, c. Напишите программу, которая находит корни квадратного
// // уравнения
// // ax^2 + bx + c = 0
// // Если уравнение имеет два корня, то следует вывести их в порядке возрастания.

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
//         string message = rootnumberX1 > rootnumberX2 ? $"Корень X2: {rootnumberX2}. Корень X1: {rootnumberX1}." : $"Корень X1: {rootnumberX1}. Корень X2: {rootnumberX2}.";
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

// Console.WriteLine("Задача номер 7");
// Console.WriteLine("Введите число для выдачи: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string result = $"{number} - ";
// int thousand = number / 1000;
// if (thousand == 1) result += "Одна тысяча ";
// if (thousand == 2) result += "Две тысячи ";
// if (thousand == 3) result += "Три тысячи ";
// if (thousand == 4) result += "Четыре тысячи ";
// if (thousand == 5) result += "Пять тысяч ";
// if (thousand == 6) result += "Шесть тысяч ";
// if (thousand == 7) result += "Семь тысяч ";
// if (thousand == 8) result += "Восемь тысяч ";
// if (thousand == 9) result += "Девять тысяч ";
// int hundred = (number % 1000) / 100;
// if (hundred == 1) result += "сто ";
// if (hundred == 2) result += "двести ";
// if (hundred == 3) result += "триста ";
// if (hundred == 4) result += "честыреста ";
// if (hundred == 5) result += "пятсот ";
// if (hundred == 6) result += "шессот ";
// if (hundred == 7) result += "семьсот ";
// if (hundred == 8) result += "восемьсот ";
// if (hundred == 9) result += "девятсот ";
// int desatki = (number % 100) / 10;
// if (desatki == 2) result += "двадцать ";
// if (desatki == 3) result += "тридцать ";
// if (desatki == 4) result += "сорок ";
// if (desatki == 5) result += "пятьдисят ";
// if (desatki == 6) result += "шестьдисят ";
// if (desatki == 7) result += "семьдисят ";
// if (desatki == 8) result += "восемьдисят ";
// if (desatki == 9) result += "девяносто ";
// int chislo = (number % 10);
// if ( number >= 20 || number <=9) {
// if (chislo == 1) result += "один "; 
// if (chislo == 2) result += "два "; 
// if (chislo == 3) result += "три "; 
// if (chislo == 4) result += "четыре "; 
// if (chislo == 5) result += "пять "; 
// if (chislo == 6) result += "шесть ";  
// if (chislo == 7) result += "семь "; 
// if (chislo == 8) result += "восемь "; 
// if (chislo == 9) result += "девять "; 
// }
// int iskl = (number % 100);
// if (iskl == 10) result += "десять "; 
// if (iskl == 11) result += "одиннадцать "; 
// if (iskl == 12) result += "двенадцать "; 
// if (iskl == 13) result += "тринадцать ";
// if (iskl == 14) result += "четырнадцать ";
// if (iskl == 15) result += "пятнадцать ";
// if (iskl == 16) result += "шестандцать ";
// if (iskl == 17) result += "семнадцать ";
// if (iskl == 18) result += "восемьнадцать ";
// if (iskl == 19) result += "девятнадцать ";
// if ( number >=5 && number <= 20){
// result += "долларов";
// }
// else {
// if (number % 10 == 1) result += "доллар";
// if (number % 10 >= 2 && number % 10 <= 4) result += "доллара";
// if (number % 10 >= 5 && number % 10 <= 9) result += "долларов";
// }
// Console.WriteLine(result);

// // 8. Пользователь вводит порядковый номер пальца руки. Необходимо показать его
// // название на экран.

// {
//     Console.WriteLine("Задача номер 8");
//     Console.WriteLine("Номер пальца: ");
//     int numberFinger = Convert.ToInt32(Console.ReadLine());
//     if (numberFinger == 1)
//     {
//         Console.WriteLine("ваш большой палец");

//     }
//     else if (numberFinger == 2)
//     {
//         Console.WriteLine("ваш указательный палец");

//     }
//     else if (numberFinger == 3)
//     {
//         Console.WriteLine("ваш средний палец");

//     }
//     else if (numberFinger == 4)
//     {
//         Console.WriteLine("ваш безымянный палец");

//     }
//     else if (numberFinger == 5)
//     {
//         Console.WriteLine("ваш мезинец");

//     }
//     else
//     {
//         Console.WriteLine("Нет такого пальца");
//     }
// }

// // 9. Необходимо написать программу, которая проверяет пользователя на знание
// // таблицы умножения. Пользователь сам вводит два целых однозначных числа.
// // Программа задаёт вопрос: результат умножения первого числа на
// // второе. Пользователь должен ввести ответ и увидеть на экране правильно он
// // ответил или нет. Если нет – показать еще и правильный результат.

// {
//     Console.WriteLine("Задача номер 9");
//     Console.WriteLine("Введите число А для проверки: ");
//     int numberA = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число B для проверки: ");
//     int numberB = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите результат умножения A на B: ");
//     int resultTester = Convert.ToInt32(Console.ReadLine());
//     int resultProgramm = numberA * numberB;
//     string message = resultProgramm == resultTester ? "Вы умеете умнажать!" : $"Ответ не правильный. правильно: {resultProgramm}";
//     Console.WriteLine(message);
// }

// // 10. Пользователь вводит два числа, если хотя бы одно число равно 0 то необходимо
// // получить битовую инверсию числа не равного 0, если первое число больше 20,
// // необходимо найти остаток от делания большего на меньшее, если второе меньше
// // 0 найти модуль целой часть от деления первого числа на второе, если первое и
// // второе числа чётные найти логическое битовое И для двух чисел, в противном
// // случае логическое битовое ИЛИ. Для полученного результата произвести
// // битовый сдвиг который укажет пользователь, если сдвиг четный, то сдвиг вправо,
// // если нечетный влево. Полученный результат вывести на экран

{
    Console.WriteLine("Задача номер 10");
    Console.WriteLine("Введите число А для проверки: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B для проверки: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    string message;
    if (numberA == 0 || numberB == 0)
    {
         message = numberA == 0 ? $"{~numberB}" : $"{~numberA}";
    }
   else if (numberA >=20 || numberB > 0){

   }
   
   message = "1";
    Console.WriteLine(message);
}
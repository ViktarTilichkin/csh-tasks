// 1. Пользователь вводит границы интервала из которого программа загадывает число.
// Написать программу про поиску данного числа. Пользователь пишит число в консоль,
// программа отвечает.

{
    Console.WriteLine("Задача 1");
    Console.WriteLine("ввидите границы для загадываемого числа (мин-макс): ");
    int numberMin = Convert.ToInt32(Console.ReadLine());
    int numberMax = Convert.ToInt32(Console.ReadLine());
    int result = new Random().Next(numberMin, numberMax);
    int numberlucky;
    int attempt = 0;
    do
    {
        Console.WriteLine("угадайте число загаданое компьютером");
        bool input = int.TryParse(Console.ReadLine(), out numberlucky);
        if (result > numberlucky) Console.WriteLine("загаданное число больше");
        else if (result < numberlucky) Console.WriteLine("загаданное число меньше");
        attempt++;
    }
    while (result != numberlucky);
    Console.WriteLine($"Вы угадали число {result}, колличество попыток {attempt}");
}

// 2. Написать программу, которая подсчитывает количество в строке букв, пробелов, цифр и
// остальных символов.

{
    Console.WriteLine("Задча 2");
    Console.WriteLine("введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        int resultLetter = 0, resultNumber = 0, resultSpace = 0, resultSimbol = 0;
        foreach (char item in text)
        {
            if (char.IsLetter(item))
            {
                resultLetter++;
            }
            else if (char.IsDigit(item))
            {
                resultNumber++;
            }
            else if (item.ToString() == " ")
            {
                resultSpace++;
            }
            else
            {
                resultSimbol++;
            }
        }
        Console.WriteLine($"В строке содержится : букв {resultLetter}, цифр {resultNumber}, пробелов {resultSpace} и остальных символов {resultSimbol}");
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }

}


// 3. Пользователь вводит символ. Записать все позиции данного данного символа в строке в
// массив и вывести через символ, который кажет пользователь.

{
    Console.WriteLine("Задача 3");
    Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    Console.WriteLine("Какой символ будем искать?");
    string? symbol = Console.ReadLine();
    if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(symbol))
    {
        string[] symbolNumbers = new string[text.Length];
        
    }
    else
    {
        Console.WriteLine("error input");
    }

}


// 4. Пользователь вводит число N, которое является индексом последнего элемента ряда
// Фиббоначи. Вывести весь этот ряд записанный в массив.


// 5. У пользователя есть строка, удалить из неё все числа и символы ‘.’, ‘-’, ‘,’ , ‘*’ и тд. Заменить
// пробелы символом ‘/’. Если пользователь ввел символ вопрос ‘?’ он может быть только один
// и после него пробелы должны заменены на ‘=‘, все большие буквы заменить на маленькую и
// перед ней поставить ‘-’, но результирующая строка не может начинаться с ‘-’
// ПриветМир, я Пишу код*который не ВсегдаХороший)Но я?Учусь и у Меня?Все получится
// привет-мир/я/-пишу/кодкоторый/не/-всегда-хороший-но/я?-учусь=и=у=-менявсе=получится


// 6. Праработать 7 раздличных методов char и описать через коментарий, что делает данный
// метод, его входные параметры и выходные данные


// 7. Праработать 10 раздличных методов string и описать через коментарий, что делает данный
// метод, его входные параметры и выходные данные

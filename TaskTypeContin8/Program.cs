// 1.Ввести строку.Если эта равна “hschool”, вывести true. В противном случае false.
// Добавить проверки для строк. Удалить лишние пробелы

{
    Console.WriteLine("Задача 1");
    string? text = Console.ReadLine();
    string message = "";
    string textTrue = "hschool";
    if (!string.IsNullOrEmpty(text))
    {
        message = text.ToLower().Trim() == textTrue ? "true" : "false";// то ловер если регитры не совпадают. трим удаляет лишние пробелы с переди и зади. 
        Console.WriteLine(text.ToLower().Trim() == "hschool");
    }
    else
    {
        Console.WriteLine("Пустая строка");
    }
    Console.WriteLine(message);
}

// 2.Ввести строку.Проверить является ли это число или строка. Если число, то
// выяснить, четное или нет. Если это строка то преобразовать строку в массив, где
// каждый символ – один элемент массива
// ‘hschool’ => [‘h’, ‘s’, ‘c’, ‘h’, ‘o’, ‘o’, ‘l’]

{
    Console.WriteLine("Задача 2");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        if (double.TryParse(text, out double number))
        {
            Console.WriteLine(number % 2 == 0 ? "четное" : "не четное");
        }
        else
        {
            string[] result = text.Split('.');
            char[] resultText = text.ToCharArray();
            Console.WriteLine(resultText.Length);
        }
    }
}

// 3.Преобразовать строку ‘Full сStaCK DevELoper’ в массив вида [‘full, ‘stack’,
// ‘developer’]

{
    Console.WriteLine("Задача 3");
    string text = "Full сStaCK DevELoper";
    text = text.ToLower();
    string[] result = text.Split(" ");
    Console.WriteLine(result[0]);
    Console.WriteLine(result[1]);
    Console.WriteLine(result[2]);
}

// 4.Ввести строку.Проверить на isNaN. Если число, то ошибка ввода. Если это строка
// то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы

{
    Console.WriteLine("Задача 4");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        if (!int.TryParse(text, out _))
        {
            Console.WriteLine($"{text.ToLower().Trim()}, Длинна строки {text.Length}");
        }
        else
        {
            Console.WriteLine("ошибка ввода");
        }
    }
    else
    {
        Console.WriteLine("Пустая строка");
    }
}

// 5. ‘HTML JavaScript PHP’ преобразовать в "HTML-JAVASCRIPT-PHP"

{
    Console.WriteLine("Задача номер 5");
    string text = "HTML JavaScript PHP";
    Console.WriteLine(text);
    string[] result = text.Split(" ");
    Console.WriteLine((string.Join("-", result)).ToUpper());
}

// 6.Ввести строку.Проверить является ли это число или строка. Если число, то
// ошибка ввода. Если это строка то первый символ поставить в верхний регистр.
// Убрать лишние пробелы

{
    Console.WriteLine("Задача номер 6");
    string? text = Console.ReadLine();
    text = text?.Trim();
    if (!string.IsNullOrEmpty(text) && !int.TryParse(text, out _))
    {
        Console.WriteLine(string.Concat(Convert.ToString(text[0]).ToUpper(), text.Remove(0, 1)));
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 7.На вход программе подаётся строка. Замените все @ на '!' с помощью    
// глобального поиска и замены (2 способа)

{
    Console.WriteLine("Задача номер 7");
    string? text = Console.ReadLine();
    if (!int.TryParse(text, out _) && !string.IsNullOrEmpty(text))
    {
        string[] result = text.Split("@");
        Console.WriteLine((string.Join("!", result)));
    }
    else
    {
        Console.WriteLine("ошибка ввода");
    }
}

// 8. Дана строка 'aaa bbb ccc'. Вырежите из нее слово 'bbb'

{
    Console.WriteLine("Задача номер 8");
    string? text = Console.ReadLine();
    if (!int.TryParse(text, out _) && !string.IsNullOrEmpty(text))
    {
        string[] result = text.Split("@");
        Console.WriteLine((string.Join("!", result)));
    }
    else
    {
        Console.WriteLine("ошибка ввода");
    }
}

// 9. На вход программе подается переменная date, в котрой лежит дата в формате
// 'xxxx-xx-xx'. Преобразуйте эту дату в формат 'xx/xx/xxxx’. (reverse)

{
    Console.WriteLine("Задача 9, реверс даты");
    Console.WriteLine("Введите дату в формате гггг-мм-дд");
    string? date = Console.ReadLine();
    if (!string.IsNullOrEmpty(date))
    {
        string[] dateResult = date.Split("-");
        Console.WriteLine(string.Join("/", dateResult[2], dateResult[1], dateResult[0]));
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 10. Дана строка из 3 слов разделенных пробелом:
// • Найдите количество символов в этой строке.
// • Вырежите из нее 2 и 3 слова.
// • Найдите индекс 2 подстроки

{
    Console.WriteLine("Задача 10");
    string text = "  Простая строка задачи ";
    Console.WriteLine($"Наша страка: {text}");
    text = text.Trim();
    int textLong = text.Length;
    string[] result = text.Split(" ");
    Console.WriteLine($"Количество символов в строке {textLong}. Второй символ троки {text[1]}");
    Console.WriteLine(result[0]);
}

// 11. Пользователь вводит дату в формате ‘х-х-х'. Замените все дефисы на '!'

{
    Console.WriteLine("Задача 11");
    Console.WriteLine("Введите дату в формате х-х-х ");
    string? date = Console.ReadLine();
    if (!string.IsNullOrEmpty(date))
    {
        string[] result = date.Split("-");
        Console.WriteLine(string.Join("!", result));
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 12. Пользователь вводит дату в формате 'xxxx-xx-xx'. Преобразуйте эту дату в формат
// 'xx.xx.xxxx'.

{
    Console.WriteLine("Задача 12");
    Console.WriteLine("Введите сообщение в формате xxxx-xx-xx ");
    string? date = Console.ReadLine();
    if (!string.IsNullOrEmpty(date))
    {
        string[] result = date.Split("-");
        Console.WriteLine(string.Join(".", result));
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 13. Дан массив ['я', 'учу', 'javascript', '!']. С помощью метода join преобразуйте массив в
// строку 'я+учу+javascript+!'.

{
    Console.WriteLine("Задача 13");
    string[] array = { "я", "учу", "javascript", "!" };
    Console.WriteLine(string.Join("+", array));
}

// 14. Дан массив. Вывести каждый одельный элемент в консоль (for)

{
    Console.WriteLine("Задача 14");
    Console.WriteLine("Введите строку");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        string[] result = text.Split(" ");
        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }

}

// 15. На вход программе подается строка текста, состоящая из слов, разделенных
// ровно одним пробелом. Напишите программу, которая подсчитывает количество
// слов в ней

{
    Console.WriteLine("Задача 15");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        text = text.Trim();
        string[] result = text.Split(" ");
        Console.WriteLine($"Количество слов {result.Length}");
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 16. Пользователь вводит строку. Необходимо посчитать количество гласных (for)

{
    Console.WriteLine("Задача 16");
    Console.WriteLine("Введите текст на английском");
    string? text = Console.ReadLine();
    char[] par = { 'A', 'E', 'I', 'O', 'U', 'Y' };
    if (!string.IsNullOrEmpty(text))
    {
        text = text.Trim().ToUpper();
        int result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == par[0] || text[i] == par[1] || text[i] == par[2] || text[i] == par[3] || text[i] == par[4] || text[i] == par[5])
            {
                result++;
            }

        }
        Console.WriteLine($"Количество гласных {result}");

    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 17. Пользователь вводит строку. Необходимо посчитать количество согласных (for)

{
    Console.WriteLine("Задача 17");
    Console.WriteLine("Введите текст на английском");
    string? text = Console.ReadLine();
    char[] par = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z' };
    if (!string.IsNullOrEmpty(text))
    {
        text = text.Trim().ToUpper();
        int result = 0;
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (text[i] == par[j])
                {
                    result++;
                }
            }

        }
        Console.WriteLine($"Количество согласных {result}");

    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 18. Пользователь вводит строку. Необходимо вывести все гласные отдельной
// строкой (for)
// fullstack => ua

{
    Console.WriteLine("Задача 18");
    Console.WriteLine("Введите текст на английском");
    string? text = Console.ReadLine();
    char[] par = { 'a', 'e', 'y', 'u', 'o', 'i' };
    if (!string.IsNullOrEmpty(text))
    {
        text = text.Trim().ToLower();
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (text[i] == par[j])
                {
                    result += text[i];
                }
            }

        }
        Console.WriteLine($" Гласные : {result}");

    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}

// 19. На вход программе подается строка. Преобразуйте первую букву каждого слова
// строки в верхний регистр (for)

{
    {
        Console.WriteLine("Задача 19");
        Console.WriteLine("Введите строку");
        string? text = Console.ReadLine();
        if (!string.IsNullOrEmpty(text))
        {
            text = text.Trim();
            string[] array = text.Split(" ");
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
            }
            Console.WriteLine(result);

        }
        else
        {
            Console.WriteLine("Ошибка ввода");
        }
    }
}

// 20.На вход программе подается строка, где каждое слово заканчивается “_”.
// Программа должна убрать “_” и первую букву каждого слова (помимо первого),
// преобразовать в верхний регистр (for)


// 21. На вход программе подается строка, состоящая из имени и фамилии человека,
// разделенных одним пробелом. Напишите программу, которая проверяет, что имя
// и фамилия начинаются с заглавной буквы.
// Chris Alan => true
// chris alan => false


// 22. На вход программе подается строка. Напишите программу, которая меняет
// регистр символов, другими словами замените все строчные символы заглавными
// и наоборот.
// Swap Case => sWAP cASE

{
    Console.WriteLine("Задача 17");
    string? text = Console.ReadLine();
    text = text?.Trim();
    if (!string.IsNullOrEmpty(text))
    {
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                result += char.ToLower(text[i]).ToString();
            }
            else if (char.IsLower(text[i]))
            {
                result += char.ToUpper(text[i]).ToString();
            }
            else
            {
                result += text[i].ToString();
            }
        }

        System.Console.WriteLine(result);
    }
    else
    {
        System.Console.WriteLine("Empty string");
    }
}

// 23. На вход программе подается строка текста. Напишите программу, которая
// определяет является ли строка хорошей. Текст хороший, если содержит
// подстроку «хорош» во всевозможных регистрах.
// я очень хороший текст => true


// 24.На вход программе подается строка. Напишите программу, которая подсчитывает
// количество буквенных символов в нижнем регистре.
// abcABCD12345 => 3



// 25. На вход программе подается строка из букв А, Г, Ц, Т. Напишите программу,
// которая подсчитывает сколько букв
// АааГГЦЦцТТтттА => А – 4 Г – 2 Ц – 3 Т – 5


// 26. На вход программе подается строка текста. Напишите программу, которая
// проверяет, что строка заканчивается подстрокой .com или .ru. Если
// заканчивается, то вывести true, в противном случае false


// 27. На вход подается url. Если он начинается с http, содержит хотя бы один “/” и
// заканчивается подстрокой .com или .ru, то вывести true, в противном случае false
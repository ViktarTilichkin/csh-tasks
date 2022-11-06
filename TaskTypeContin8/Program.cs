// 1.Ввести строку.Если эта равна “hschool”, вывести true. В противном случае false.
// Добавить проверки для строк. Удалить лишние пробелы

{
    Console.WriteLine("Задача 1");
    string? input = Console.ReadLine();
    string message = "";
    string inputTrue = "hschool";
    if (!string.IsNullOrEmpty(input))
    {
        message = input.ToLower().Trim() == inputTrue ? "true" : "false";// то ловер если регитры не совпадают. трим удаляет лишние пробелы с переди и зади. 
        Console.WriteLine(input.ToLower().Trim() == "hschool");
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
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        if (double.TryParse(input, out double number))
        {
            Console.WriteLine(number % 2 == 0 ? "четное" : "не четное");
        }
        else
        {
            string[] result = input.Split('.');
            char[] resultinput = input.ToCharArray();
            Console.WriteLine(resultinput.Length);
        }
    }
}

// 3.Преобразовать строку ‘Full сStaCK DevELoper’ в массив вида [‘full, ‘stack’,
// ‘developer’]

{
    Console.WriteLine("Задача 3");
    string input = "Full сStaCK DevELoper";
    input = input.ToLower();
    string[] result = input.Split(" ");
    Console.WriteLine(result[0]);
    Console.WriteLine(result[1]);
    Console.WriteLine(result[2]);
}

// 4.Ввести строку.Проверить на isNaN. Если число, то ошибка ввода. Если это строка
// то узнать какая у нее длина. Привести к одному регистру, убрать лишние пробелы

{
    Console.WriteLine("Задача 4");
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        if (!int.TryParse(input, out _))
        {
            Console.WriteLine($"{input.ToLower().Trim()}, Длинна строки {input.Length}");
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
    string input = "HTML JavaScript PHP";
    Console.WriteLine(input);
    string[] result = input.Split(" ");
    Console.WriteLine((string.Join("-", result)).ToUpper());
}

// 6.Ввести строку.Проверить является ли это число или строка. Если число, то
// ошибка ввода. Если это строка то первый символ поставить в верхний регистр.
// Убрать лишние пробелы

{
    Console.WriteLine("Задача номер 6");
    string? input = Console.ReadLine();
    input = input?.Trim();
    if (!string.IsNullOrEmpty(input) && !int.TryParse(input, out _))
    {
        Console.WriteLine(string.Concat(Convert.ToString(input[0]).ToUpper(), input.Remove(0, 1)));
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
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out _) && !string.IsNullOrEmpty(input))
    {
        string[] result = input.Split("@");
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
    string? input = Console.ReadLine();
    if (!int.TryParse(input, out _) && !string.IsNullOrEmpty(input))
    {
        string[] result = input.Split("@");
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
    string input = "  Простая строка задачи ";
    Console.WriteLine($"Наша страка: {input}");
    input = input.Trim();
    int inputLong = input.Length;
    string[] result = input.Split(" ");
    Console.WriteLine($"Количество символов в строке {inputLong}. Второй символ троки {input[1]}");
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
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        string[] result = input.Split(" ");
        for (int i = 0; i < input.Length; i++)
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
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim();
        string[] result = input.Split(" ");
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
    string? input = Console.ReadLine();
    char[] par = { 'A', 'E', 'I', 'O', 'U', 'Y' };
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim().ToUpper();
        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == par[0] || input[i] == par[1] || input[i] == par[2] || input[i] == par[3] || input[i] == par[4] || input[i] == par[5])
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
    string? input = Console.ReadLine();
    char[] par = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Z' };
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim().ToUpper();
        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if (input[i] == par[j])
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
    string? input = Console.ReadLine();
    char[] par = { 'a', 'e', 'y', 'u', 'o', 'i' };
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim().ToLower();
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (input[i] == par[j])
                {
                    result += input[i];
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
        string? input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            input = input.Trim();
            string[] array = input.Split(" ");
            string result = "";
            for (int i = 0; i < input.Length; i++)
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

{
    Console.WriteLine("Задача 20");
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim();
        string intrvalArray = string.Join("", input.Split(" "));
        Console.WriteLine(intrvalArray);
        string[] array = intrvalArray.Split("_");
        string result = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            string text = array[i].ToString();
            result += text.Remove(0, 1);
        }
        Console.WriteLine(result.ToUpper());
    }
    else
    {
        Console.WriteLine("Ошибка ввода");
    }
}


// 21. На вход программе подается строка, состоящая из имени и фамилии человека,
// разделенных одним пробелом. Напишите программу, которая проверяет, что имя
// и фамилия начинаются с заглавной буквы.
// Chris Alan => true
// chris alan => false

{
    Console.WriteLine("Задача 21");
    Console.Write("Введите имя и фамилию ");
    string? input = Console.ReadLine();
    string message = "";
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim();
        string[] result = input.Split(" ");
        if (result.Length == 2)
        {
            string word1 = result[0];
            string word2 = result[1];
            message = Char.IsUpper(word1[0]) == true && Char.IsUpper(word2[0]) == true ? "True" : "False";
        }
        Console.WriteLine(message);
    }
    else
    {
        Console.WriteLine("ошибка ввода");
    }
}

// 22. На вход программе подается строка. Напишите программу, которая меняет
// регистр символов, другими словами замените все строчные символы заглавными
// и наоборот.
// Swap Case => sWAP cASE

{
    Console.WriteLine("Задача 22");
    string? input = Console.ReadLine();
    input = input?.Trim();
    if (!string.IsNullOrEmpty(input))
    {
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
            {
                result += char.ToLower(input[i]).ToString();
            }
            else if (char.IsLower(input[i]))
            {
                result += char.ToUpper(input[i]).ToString();
            }
            else
            {
                result += input[i].ToString();
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

{
    Console.WriteLine("Задача 23");
    Console.Write("Введите строку, для проверки на хорош он или нет: ");
    string? input = Console.ReadLine();
    if (!string.IsNullOrEmpty(input))
    {
        input = input.Trim().ToLower();
        Console.WriteLine(input.Contains("хорош"));
    }
}

// 24.На вход программе подается строка. Напишите программу, которая подсчитывает
// количество буквенных символов в нижнем регистре.
// abcABCD12345 => 3

{
    Console.WriteLine("Задача 24");
    Console.Write("введите текст для проверки: ");
    string? input = Console.ReadLine();
    int result = 0;
    if (!string.IsNullOrEmpty(input))
    {
        for (int i = 0; i < input.Length; i++)
        {
            result += Char.IsLower(input[i]) ? 1 : 0;
        }
        Console.WriteLine($"Символов нижнего регистра: {result}");
    }
    else
    {
        Console.WriteLine("ошибка ввода");
    }
}

// 25. На вход программе подается строка из букв А, Г, Ц, Т. Напишите программу,
// которая подсчитывает сколько букв
// АааГГЦЦцТТтттА => А – 4 Г – 2 Ц – 3 Т – 5

{
    Console.WriteLine("Задача 25");
    Console.Write("Введите строку ");
    string? text = Console.ReadLine();
    int numberA = 0, numberG = 0, numberC = 0, numberT = 0;
    if (!string.IsNullOrEmpty(text))
    {
        text = text.ToUpper();
        for (int i = 0; i < text.Length; i++)
            switch (text[i])
            {
                case 'А':
                    numberA++;
                    break;
                case 'Г':
                    numberG++;
                    break;
                case 'Ц':
                    numberC++;
                    break;
                case 'Т':
                    numberT++;
                    break;

            }
        Console.WriteLine($"Букв А {numberA}, Букв Г {numberG}, Букв Ц {numberC}, букв Т {numberT}");
    }
}

// 26. На вход программе подается строка текста. Напишите программу, которая
// проверяет, что строка заканчивается подстрокой .com или .ru. Если
// заканчивается, то вывести true, в противном случае false

{
    Console.WriteLine("Задача 26");
    Console.Write("Введите  имеил или инетрнет адрес ");
    string? text = Console.ReadLine();
    if (!string.IsNullOrEmpty(text))
    {
        string message = text.EndsWith(".com") || text.EndsWith(".ru") ? "True" : "False";
        Console.WriteLine(message);
    }
    else
    {
        Console.WriteLine("ошибка ввода");
    }
}


// 27. На вход подается url. Если он начинается с http, содержит хотя бы один “/” и
// заканчивается подстрокой .com или .ru, то вывести true, в противном случае false

{
    Console.WriteLine("Задача 27");
    Console.Write("Попробуйте написать url:  ");
    string? url = Console.ReadLine();
    if (!string.IsNullOrEmpty(url))
    {
        url = url.Trim();
        if (url.StartsWith("http") && url[4] == '/' && (url.EndsWith(".com") || url.EndsWith(".ru")))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("Ошибочка");
        }
    }
    else
    {
        Console.WriteLine("ошибка ввода");
    }
}
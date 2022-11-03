// 1. Выведите столбец чисел от 1 до 50. for, while

{
    Console.WriteLine("for");
    for (int i = 1; i <= 50; i++)
    {
        Console.WriteLine(i);
    }
    int number = default;
    Console.WriteLine("while");
    while (number < 50)
    {
        Console.WriteLine(++number);
    }
}

// 2. [1, 2, 3, 4, 5]. Выведите каждый элемент массива 3 любыми циклами

{
    int[] number = new int[] { 1, 2, 3, 4, 5 };
    for (int i = 0; i < number.Length; i++)
    {
        Console.WriteLine(number[i]);
    }
    int index = 0;
    while (index < number.Length)
    {
        Console.WriteLine(number[index++]);
    }
    foreach (int items in number)
    {
        Console.WriteLine(items);
    }
}

// 3. Дан массив с элементами [2, 3, 4, 5]. С помощью 3 циклов найдите произведение
// элементов этого массива.

{
    int[] number = new int[] { 2, 3, 4, 5 };
    int result = 1;
    int i = 0;
    while (i < number.Length)
    {
        result = result * number[i];
        i++;
    }
    Console.WriteLine(result);
    result = 1;
    for (int j = 0; j < number.Length; j++)
    {
        result *= number[j];
    }
    Console.WriteLine(result);
    result = 1;
    foreach (int item in number)
    {
        result *= item;
    }
    Console.WriteLine(result);
}

// 4. Выведите столбец чисел от 11 до 33 циклом while
{
    for (int i = 11; i <= 33; i++)
    {
        Console.WriteLine(i);
    }
    int number = 11;
    while (number < 33)
    {
        Console.WriteLine(++number);
    }

}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] InputArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите число № {i + 1} = ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CountPositiveNums(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;

    }
    return result;
}

Console.Clear();

int numberOfNums = InputNum("Введите общее количество чисел: ");

Console.WriteLine($"Количество чисел больше нуля, которые ввел пользователь равно {CountPositiveNums(InputArray(numberOfNums))}");
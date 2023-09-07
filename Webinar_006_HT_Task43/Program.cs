// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void IntersectionPoint(double b1Point, double k1Point, double b2Point, double k2Point)
{
    double x = 0;
    double y = 0;
    if (k1Point == k2Point) Console.WriteLine("Прямые линии паралельны или совпают");
    else
    {
        x = (b2Point - b1Point) / (k1Point - k2Point);
        y = k1Point * x + b1Point;
        Console.WriteLine($"Точка пересечения двух прямых находятся в координатах ({x}; {y})");
    }
}

Console.Clear();

int b1 = InputNum("Введите b1 = ");
int k1 = InputNum("Введите k1 = ");
int b2 = InputNum("Введите b2 = ");
int k2 = InputNum("Введите k2 = ");

IntersectionPoint(b1, k1, b2, k2);

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Для нахождения точки пересечения двух прямых введите переменные:");
double k1 = InputInt("k1 = ");
double b1 = InputInt("b1 = ");
double k2 = InputInt("k2 = ");
double b2 = InputInt("b2 = ");

if (k1 == k2)
{
    Console.WriteLine("Точки пересечения нет, т.к. прямые параллельны");
    return;
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых равна [{x}, {y}]");

double InputInt(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}


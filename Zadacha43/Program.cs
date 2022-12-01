/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int b1 = ReadInt("Введите коэффициент b1: ");
int b2 = ReadInt("Введите коэффициент b2: ");
int k1 = ReadInt("Введите коэффициент k1: ");
int k2 = ReadInt("Введите коэффициент k2: ");
if(k1-k2!=0)
{
    int x = (b1-b2)/(k1-k2);
    int y=k1*x+b1;
    Console.WriteLine($"Прямые пересекаются в точке с координатами ({x},{y}).");
}
else Console.WriteLine("Прямые паралельны!!!");

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
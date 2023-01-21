// HOMEWORK_6

// Задача_1. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/*
int CountOfPositive(int num)
{
    int count = 0;

    for(int i = 1; i <= num; i++)
    {
        Console.Write($"Input the {i} number of the range: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if(temp > 0) count++;
    }
    return count;
}

Console.Write("Input a number for a range of numbers: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of positive digits: " + CountOfPositive(num));
*/


// Задача_2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
    
    if(Double.IsNaN(x)) Console.Write("This is one line");
    else if(k1 == k2) Console.Write("Lines are parallel");
    else Console.Write($"Intersection Points are: ({x}; {y})");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);

// Seminar 1.

// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго
/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num1 * num1;

if(num2 == quad2)
{
    Console.WriteLine("Yeap");
}
else
{
    Console.WriteLine("nope");
}
*/

// Задача 2. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

if(current > num)
{
    while(num <= current)
    {
        Console.Write(num + " ");
        num++;
    }
}
else
{
    while(current <= num)
    {
        Console.Write(current + " ");
        current = current + 1; // current += 1; current++
    }
}
*/


// 
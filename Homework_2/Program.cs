// Homework_2

// Задача 1. Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа

/*
int SecondNum(int num)
{
    num = (num / 10) % 10;
    return num; 
}

Input:
Console.Write("Input tree-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100) 
{
    Console.WriteLine("Less than three digits entered");
    goto Input;
}

if(num > 1000) 
{
    Console.WriteLine("More than three digits entered");
    goto Input;
}

Console.Write($"The second number from tree-digit number {num} is {SecondNum(num)}");
*/


// Задача 2. Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет

/*
int ThirdNum(int num)
{
    if(num >= 1000) 
    {
        while(num >= 1000)
        {
            num = num / 10;
        }
    }
    
    num = num % 10;
    return num;
}

Input:
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100) 
{
    Console.WriteLine("There is no the third digit");
    goto Input;
}

Console.Write($"The third number is {ThirdNum(num)}");
*/


// Задача 3. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели и проверяет, является ли этот день выходным

/*
bool Day(int num)
{
    if(num > 5 && num < 8) return true;
    else return false;
}

Console.Write("Input a day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Is it weekend? " + Day(num));
*/
// HomeWork_1

// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2) Console.WriteLine("This is two equal numbers");
else
{
    if(num1 > num2)
    {
        Console.WriteLine("max: " + num1);
        Console.Write("min: " + num2);
    }
    else
    {
        Console.WriteLine("max: " + num2);
        Console.WriteLine("min: " + num1);
    }
}
*/



// Задача 2. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a firs number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max < num2) max = num2;
if(max < num3) max = num3;

Console.Write("max number: " + max);
*/



// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.Write("This is the even number");
else Console.Write("This number is not even");
*/



// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 1;

Console.Write(a + " ");
if(a > num)
{
    while(num <= a)
    {
        if(a % 2 == 0) 
        Console.Write(a + " ");
        a--;
    }
}
else
{
    while(a <= num)
    {
        if(a % 2 == 0)
        Console.Write(a + " ");
        a++;
    }
}
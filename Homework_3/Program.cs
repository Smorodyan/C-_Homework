// Homework_3

// Задача_1. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

/*
int Funct(int num)
{
    int poly = 0;
    int num2 = num;
    while(poly < num)
    {
        poly = poly * 10 + num2 % 10;
        num2 = num2 / 10;
    }
    return poly;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Funct(num);

if(Funct(num) == num) Console.Write("This is a palindrome!");
else Console.Write("This is not a palindrome");
*/



// Задача_2. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

/*
double Funct(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write("The distance between two points is: " + Funct(x1, y1, z1, x2, y2, z2));
*/


// Задача_3. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


void Funct(double num)
{
    double count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{count} => {Math.Pow(count, 3)}");
        count++;
    }
}

Console.Write("Input a number: ");
double num = Convert.ToDouble(Console.ReadLine());

Funct(num);


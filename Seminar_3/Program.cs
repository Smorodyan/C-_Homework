// Seminar_3

// Задача_1. Напишите программу, которая по заданному номеру четверти 
//покажет дипапзон возможных координат точек в этой четрверти

/*
void GetDiapazone(int quadrant)
{
    if (quadrant == 1) Console.Write("x > 0 & y > 0");
    else if(quadrant == 2) Console.Write(" x < 0 & y > 0");
    else if(quadrant == 3) Console.Write("x < 0 & y < 0");
    else if (quadrant ==4) Console.Write("x > 0 & y < 0");
    else Console.Write("Wrong Input");
}

Console.Write("Input number: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

GetDiapazone(quadrant);
*/



// Задача_2. Напишите программу, которая принимает на вход координаты точки (не нулевые) 
// и выдает номер четверти плоскости, в которой  эта точка находится

/*
int Axis(int x, int y)
{
   // if (x == 0 || y == 0) return 0;
    if(x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    return 0;
 }

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());

//Console.Write(Axis(x, y));
Funct();

 void Funct()
 {
    if(Axis(x, y) == 0) Console.Write("Wrong numbers!");
    else if(Axis(x, y) == 1) Console.Write("1st quarter");
    else if(Axis(x, y) == 2) Console.Write("2nd quarter");
    else if(Axis(x, y) == 3) Console.Write("3rd quarter");
    else if(Axis(x, y) == 4) Console.Write("4th quarter");
 }
*/

// Задача_3. Напишите программу, которая принимает на вход некоторое число 
// и выдает таблицу квадратов (степень в квадрате) чисел от 1 до этого числа (1, 4, 9, 16...)

/*
void Funct(double num)
{
    double count = 1;
    while(count <= num)
    {
        double quadrant = Math.Pow(count, 2);
        Console.WriteLine($"{count} => {quadrant}");
        count++;
    }
}

Console.Write("Input a number: ");
double num = Convert.ToDouble(Console.ReadLine());

Funct(num);

*/


// Задача_4. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними

double Funct(double x1, double y1, double x2, double y2)
{
    // double d = (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    // double length = Math.Sqrt(d);
    // return length;
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}


Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Funct(x1, y1, x2, y2));
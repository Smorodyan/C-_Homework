// Homework_7

// Задача_1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

/*
double[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    int minValue = -99;
    int maxValue = 99;

    double[,] array = new double[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = 
                Math.Round((new Random().Next(minValue, maxValue) + 
                new Random().NextDouble()), 2);
    
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + "\t"); // Табуляция при выводе
            
         Console.WriteLine();
        }
    Console.WriteLine();    
}


double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/



// Задача_2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> элемента с такими индексами в массиве нет


int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    int minValue = -99;
    int maxValue = 100;

    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + "\t"); // Табуляция при выводе
            
         Console.WriteLine();
        }
    Console.WriteLine();    
}
/*
void FindPosition(int[,] array, int pos_1, int pos_2)
{
    int a = 0;
    int b = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(i == pos_1 && j == pos_2)
            {
                Console.Write($"The element value on the position ({pos_1}, {pos_2}) is {array[i,j]}");
                a = i;
                b = j;
            }
        
    if(a == pos_1 && b == pos_2) Console.Write("");
    else Console.Write("There is no any element on this position");
        
}
*/

void FindPosition(int[,] array, int pos_1, int pos_2)
{
    if(pos_1 >= array.GetLength(0) || pos_2 >= array.GetLength(1)) 
        Console.Write("There is no any element on this position");
    else
    {
        for(int i = 0; i < array.GetLength(0); i++)
            for(int j = 0; j < array.GetLength(1); j++)
                if(i == pos_1 && j == pos_2)
                    Console.Write($"The element value on the position ({pos_1}, {pos_2}) is {array[i,j]}");
    }            
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.WriteLine("Input a positions of an element of the array: ");
Console.Write("First position: ");
int pos_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second position: ");
int pos_2 = Convert.ToInt32(Console.ReadLine());

FindPosition(newArray, pos_1, pos_2);



// Задача_3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    int minValue = 1;
    int maxValue = 10;

    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue);
    
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + "\t"); // Табуляция при выводе
            
         Console.WriteLine();
        }
    Console.WriteLine();    
}

double[] ColumnsAverage(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    
    for(int i = 0; i < array.GetLength(1); i++)
        {
            double sum = 0;
            double count = 0;
            for(int j = 0; j < array.GetLength(0); j++)
            {
                sum = sum + array[j,i];
                count++;
            }
        newArray[i] = Math.Round((sum / count), 2);
        }
    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + "\t");
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

double[] oneDarray = ColumnsAverage(newArray);
ShowArray(oneDarray);
*/

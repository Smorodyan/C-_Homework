// Homework_8

// Задача_1. Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    int minValue = 0;
    int maxValue = 20;
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
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

void GrowingArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int j1 = 0; j1 < array.GetLength(1) - 1 - j; j1++)
                if(array[i,j1] < array[i, j1 + 1])
                {
                    int max = array[i,j1 + 1];
                    array[i,j1 + 1] = array[i,j1];
                    array[i,j1] = max;
                }
        }
    }
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
GrowingArray(newArray);
Show2dArray(newArray);
*/





// Задача_2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    int minValue = 0;
    int maxValue = 20;
    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    
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

void MinSumOfRow(int[,] array)
{
    int min = 0;
    int min_i = 0;
    int sum = 0;

    for(int j = 0; j < array.GetLength(0); j++)
        min = min + array[0,j];

    for(int i = 1; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i,j];
        
        if(sum < min) 
        {
            min = sum;
            min_i = i;
        }    
    }

    Console.Write($"Min sum of row's elements {min} is in the {min_i + 1} row");
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
MinSumOfRow(newArray);
*/



// Задача_3. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] CreateArrayManually()
{
    int[,] array = new int[2, 2];
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); ++j)
                {
                    Console.Write($"Input ( {i}; {j} ) array number: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
    Console.WriteLine();
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " "); 
            
         Console.WriteLine();
        }
    Console.WriteLine();    
}

int[,] ArraysMuliplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMatix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];

    newMatix[0,0] = firstMatrix[0,0] * secondMatrix[0,0] + firstMatrix[0,1] * secondMatrix[1,0];
    newMatix[0,1] = firstMatrix[0,0] * secondMatrix[0,1] + firstMatrix[0,1] * secondMatrix[1,1];
    newMatix[1,0] = firstMatrix[1,0] * secondMatrix[0,0] + firstMatrix[1,1] * secondMatrix[1,0];
    newMatix[1,1] = firstMatrix[1,0] * secondMatrix[0,1] + firstMatrix[1,1] * secondMatrix[1,1];

    Console.WriteLine();
    return newMatix;
}


int[,] firsMatrix = CreateArrayManually();
int[,] secondMatrix = CreateArrayManually();
Show2dArray(firsMatrix);
Show2dArray(secondMatrix);

int[,] newMatrix = ArraysMuliplication(firsMatrix, secondMatrix);
Show2dArray(newMatrix);
*/




// Задача_4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


/*

// Fill2dArray - ceates a two-dimensional array and fills it out 
// with numbers from single-dimensional array  
int[,,] Fill2dArray(int[] numsArray)    
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
     Console.Write("input a number of pages: ");
        int pages = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,,] array = new int[rows, columns, pages];
    int m = 0;

    for(int k = 0; k < pages; k++)
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++, m++)
                array[i,j,k] = numsArray[m];
    
    return array;
}

void Show2dArray(int[,,] array)
{
    for(int k = 0; k < array.GetLength(2); k++)
        for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {    
                    Console.Write(array[i,j,k]);
                    Console.Write($"({i},{j},{k})\t");
                }
            Console.WriteLine();
            }
        Console.WriteLine();    
}

int[] NumsArray()   // Creates a single-dimensional array 
{
int[] array = new int[90];
    for(int i = 0, j = 10; i < array.Length; i++, j++)
    {    
        array[i] = j;
    }
    return array;
}


int[] numsArray = NumsArray();
Console.WriteLine();
int[,,] newArray = Fill2dArray(numsArray);
Show2dArray(newArray);

*/



// Задача_5. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    int n = 0;
    int x0 = 0;
    int xn = columns - 1;
    int y0 = 0;
    int yn = rows - 1;

    while (n < rows * columns)
            {
                for (int x = x0; x <= xn; x++)
                {
                    array[y0, x] = ++n;
                }
               
                y0++;
                for (int y = y0; y <= yn; y++)
                {
                    array[y, xn] = ++n;
                }
                
                xn--;
                for (int x = xn; x >= x0; x--)
                {
                    array[yn, x] = ++n;
                }
               
                yn--;
                for (int y = yn; y >= y0; y--)
                {
                    array[y, x0] = ++n;
                }
                x0++;
            }

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
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);





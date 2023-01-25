// Seminar_7

// ЗАДАЧА_1.

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    int minValue = -99;
    int maxValue = 99;

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

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/


// ЗАДАЧА_2. Необходимо задать двумерный массив размера M на N, 
// каждый элемент в массиве находится по формуле: a[i,j] i+j 

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    //int minValue = -99;
    //int maxValue = 99;

    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    
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
*/


// ЗАДАЧА_3. Необходимо задать двумерный массив и четные элементы индекса 
// заменить на квадрат этого числа


int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    //int minValue = -99;
    //int maxValue = 99;

    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    
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

int[,] PowArray(int[,] array)
{
    for(int i = 2; i < array.GetLength(0); i+=2)
        for(int j = 2; j < array.GetLength(1); j+=2)    
    array[i,j] *= array[i,j];

    return array;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
PowArray(newArray);
Show2dArray(newArray);




// ЗАДАЧА_4. Необходимо задать двумерный массив и найит сумму элементов, 
// находящихся на главной диагонали

/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());
    //int minValue = -99;
    //int maxValue = 99;

    int[,] array = new int[rows, columns];
    
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;
    
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

int SumOfArrayDiagonal(int[,] array)
{
    int sum = 0;

    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum =+ array[i,i];

    return sum;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.Write("Sum of the array's diagonal is: " + SumOfArrayDiagonal(newArray));
*/


// Seminar_7

// Задача_1. Написать программу, которая меняет заданные значения в массиве

/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    // Console.Write("input a number of rows: ");
    //     int rows = Convert.ToInt32(Console.ReadLine());
    // Console.Write("input a number of columns: ");
    //     int columns = Convert.ToInt32(Console.ReadLine());
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


void ChangePositions(int[,] array, int pos_1, int pos_2, int rows, int columns)
{
    // for(int i = pos_1; i < array.Length; i++)
    //     if(i == pos_1 && j == pos_2)
    //         Console.Write($"The element value on the position ({pos_1}, {pos_2}) is {array[i,j]}");
   
    int j = pos_1;
    while(j >= columns) j = j - columns; //16-6
        // (j-1) -> 3
    
    int i = j-1-1;
    Console.WriteLine("i = " + i);
    Console.WriteLine("j = " + (j - 1));
    int temp = array[i,j - 1];
    Console.WriteLine("temp = " + temp);
    
    int k = pos_2;
    while(k > columns) k = k - columns; //17-6
   // (j-1) -> 3
    int n = k-1-1;
    Console.WriteLine("n = " + n);
    Console.WriteLine("k = " + (k - 1));
    Console.WriteLine("2-е значение: " + array[n,k - 1]);
    array[i,j - 1] = array[n,k - 1];
    array[n,k - 1] = temp;      
}

Console.Write("input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, columns);
Show2dArray(newArray);
Console.WriteLine(newArray.Length);


Console.WriteLine("Choose two positions for changees: ");
Console.Write("First position: ");
int pos_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second position: ");
int pos_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

ChangePositions(newArray, pos_1, pos_2, rows, columns);
Show2dArray(newArray);
*/


// Задача_2. Написать программу, которая меняет заданные строки в массиве

/*
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

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 > 0 && r1 < array.GetLength(0) &&
        r2 > 0 && r2 < array.GetLength(0) &&
        r1 != r2)
    
    for(int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[r1,j];
        array[r1,j] = array[r2,j];
        array[r2,j] = temp;
    }
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine(newArray.Length);


Console.WriteLine("Choose two changing rows: ");
Console.Write("First row: ");
int row_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second row: ");
int row_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

ChangeRows(newArray, row_1 - 1, row_2 - 1);
Show2dArray(newArray);
*/



// Задача_3. Необходимо задать двумерный массив и написать программу, меняющую строки на столбцы

/*
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

// void Show2dArrayRev(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//         {
//             for(int j = 0; j < array.GetLength(1); j++)
//                 Console.Write(array[j,i] + "\t"); // Табуляция при выводе
            
//          Console.WriteLine();
//         }
//     Console.WriteLine();   
// }

void RevertArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

RevertArray(newArray);
Show2dArray(newArray);
//Show2dArrayRev(newArray);
*/


// Задача_4. Необходимо из двумерного массива удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент 


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

int[] FindMinElement(int[,] array)
{
    int min = array[0,0];
    int[] positionArray = new int[2];
    
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j] < min) 
            {    
                min = array[i,j];
                positionArray[0] = i;
                positionArray[1] = j;
            }
    Console.WriteLine("min = " + min);
    return positionArray;  
}

int[,] DelMinElement(int[,] array, int[] positionArray)
{
    int[,] deletedArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int i2 = 0;
    int j2 = 0;
        
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(i != positionArray[0])
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(j != positionArray[1])
                {
                    deletedArray[i2,j2] = array[i,j];
                    j2++;
                }
            }
        i2++;
        j2 = 0;
        }
    }
    return deletedArray;
}

// int[,] DelMinElement(int[,] array)
// {
//    int min = array[0,0];
//    int min_index_i = 0;
//    int min_index_j = 0;
    
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             if(array[i,j] < min) 
//             {    
//                 min = array[i,j];
//                 min_index_i = i;
//                 min_index_j = j; 
//             }
//     Console.WriteLine("min = " + array[min_index_i,min_index_j]);
   
//     int[,] minArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
//     int i1 = 0;
//     int j1 = 0;

//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         if(i != min_index_i)
//         {    
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                 if(j != min_index_j)
//                 {
//                     minArray[i1,j1] = array[i,j];
//                     j1++;
//                 }
//             }           
//             j1 = 0;
//             i1++;
//         }
//     }
//     return minArray;
// }

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

// int min = FindMinElement(newArray);
// Console.Write(min);
int[] positionArray = FindMinElement(newArray);
int[,] delitedMin = DelMinElement(newArray, positionArray);
Show2dArray(delitedMin);






// Задача_5. Необходимо развернуть двумерный массив по часовой стрелке
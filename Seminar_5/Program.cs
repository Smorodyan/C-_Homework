// Задача_1. Напишите задачу, которая определяет сумму отрицательных элементов в ручном массиве

/*
int[] CreateArrayManually(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {    
        Console.Write($"Input {i + 1} array number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
}

void SumOfArray(int[] array)
{
    int result = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        result = result + array[i];
    }
    Console.Write(result);
}


Console.Write("Input an array lenght: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArrayManually(length);
ShowArray(newArray);
SumOfArray(newArray);
*/


// Задача_2. Напишите задачу, которая определяет сумму отрицательных элементов в авто массиве

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");

    Console.WriteLine("]");
}

// void SumOfArray(int[] array)
// {
//     int result = 0;
    
//     for(int i = 0; i < array.Length; i++)
//        if(array[i] < 0) 
//         result += array[i];
//          // result = result + array[i];
    
//     Console.Write(result);
// }

int SumOfArray(int[] array)
{
    int result = 0;
    
    for(int i = 0; i < array.Length; i++)
       if(array[i] < 0) 
        result += array[i];
         // result = result + array[i];
    
    return result;
}



Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = (CreateRandomArray(length, min, max));
ShowArray(newArray);
//int result = SumOfArray(newArray);
Console.Write("The sum of negative numbers of the array is " + SumOfArray(newArray));
*/


// Задача_3. Напишите программу, заменяющиую положительные элементы массива 
// на отрицательные и наоборот

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] ChangeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1);
    
    return(array);
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
int[] changedArray= ChangeArray(newArray);
ShowArray(changedArray);
*/



// Задача_4. Напишите программу, которая определяет присутсвует ли заданное число в массиве

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

bool FindNumber(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == num) return true;
           // else return false;
        }
    return false;
    
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

Console.Write("Input a number you want to find in the array: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Is there the number: " + num + " in the array - " + FindNumber(newArray, num));
*/


// Задача_5. Необходимо задать массив из N элементов и определить количество элементов, 
// принадлежащих отрезку от А до В (включительно) и указать количестов этих элементов


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int ArrayRange(int[] array, int num_1, int num_2)
{
    int count = 0;
    for(int i = num_1 - 1; i <= num_2 - 1; i++)
       {
        Console.Write(array[i] + " ");
        count++;
       }
    Console.WriteLine();
    Console.Write("Number of elements: ");
    return count;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

Console.WriteLine("Input num_1 & num_2 for the range to count: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("This is the arrya from the range: ");
Console.Write(ArrayRange(newArray, num_1, num_2));




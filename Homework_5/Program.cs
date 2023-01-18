// Homework_5

// Задача_1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size)
{
    int minValue = 100; 
    int maxValue = 1000;
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0) count++;
        }
    return count;
}

Console.Write("Input a length of the array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length);
ShowArray(newArray);

Console.Write($"Even numbers in the array: {FindNumbers(newArray)}");
*/




// Задача_2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int[] CreateRandomArray(int size)
{
    int minValue = 1; 
    int maxValue = 10;
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindSumOfOddNums(int[] array)
{
    int sum = array[1];

    for(int i = 3; i < array.Length; i+= 2)
        sum+= array[i];
    
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length);
ShowArray(newArray);

Console.Write("Sum of odds nummbers in the array is: "+ FindSumOfOddNums(newArray));
*/





// Задача_3. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] CreateRandomDoubleArray(int size)
{
    int minValue = 1; 
    int maxValue = 100;
   
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");
    Console.WriteLine();
}

double FindMaxMinDiff(double[] array)
{
    double max = array[0];
    double min = array[0];

    for(int i = 1; i < array.Length; i++)
        {
            if(max < array[i]) max = array[i];
        }

    for(int i = 1; i < array.Length; i++)
        {
            if(min > array[i]) min = array[i];
        }    
        
    return max - min;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomDoubleArray(length);
ShowArray(newArray);

Console.Write("The difference between max & min is: " + FindMaxMinDiff(newArray));
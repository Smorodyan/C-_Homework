
// Задача_1. Напишите программу, которая принимает на вход 3 числа и проверяет может ли
//существовать треугольник  со сторонами такой длинны (сумма двух сторон должна быть больше третьей)

/*
bool Triangle(int a, int b, int c)
{
    return (a + b > c) && (a + c > b) && (b + c > a);
}


Console.Write("Input the first number: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

if(Triangle(num_1, num_2, num_3)) Console.Write("Triangle exists");
else Console.Write("Triangle doesn't esist");
*/




// Задача_2. Напишите программу, которая выводит первое N чисел Фибоначчи, где первые два это А и В

/*
int[] Fibonacci(int[] array, int a, int b)
{
    array[0] = a;
    array[1] = b;

    for(int i = 2; i < array.Length; i++)
        array[i] = array[i - 1] + array[i - 2];

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

Fibonacci(array, a, b);
ShowArray(array);
*/



// Задача_3. Напишите программу, которая делает копию развернутого 
// массива поэлементным копированием


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

int[] CopyArray(int[] array)
{
   int[] copiedArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
        {
            copiedArray[i] = array[i];
        }
    return copiedArray;
}

int[] ConvertArray(int[] array)
{
    int temp = 0;

    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

Console.Write("Input a length of the array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length);
ShowArray(newArray);

int[] copiedArray = CopyArray(newArray);
ConvertArray(copiedArray);
ShowArray(copiedArray);

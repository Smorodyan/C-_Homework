// Homework_4

// Задача_1. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
int FunctPow(int a, int b)
{
    int result = 1;

    if(b == 0) return 1;
    else
    {
        for(int i = 1; i <= b; i++)
            result = result * a;
    }
    return result;
}

Console.Write("Input the first numer: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(FunctPow(num1, num2));
*/



// Задача_2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10

/*
int FunctSum(int num)
{
    int sum = 0;
    
    while(num != 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Sum of digits of the number {num} is {FunctSum(num)}");
*/


// Задача_3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


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
    Console.Write(array[i] + " ");
}

Console.Write("Input an array lenght: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArrayManually(length);
ShowArray(newArray);


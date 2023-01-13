
/*
int SumMethod(int num)
{
    int sum = 0;

    for(int i = 1; i <= num; ++i)
        sum += i;

    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

//int reuslt = SumMethod(num);
//Console.Write(reuslt);
Console.Write("Sum from consistent numbers of " + num + " = " + SumMethod(num));
*/


// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

/*
int Factorial(int num)
{
    int sum = 1;
    
    for(int i = 1; i <= num; ++i)
        sum *= i;
    return sum;
}


Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

//Console.Write("Facorial of " + num + " = " + Factorial(num));
Console.Write($"Factorial of {num} = {Factorial(num)}");
*/



//Напишите программу, которая принимает на вход число и выдает количество цифр в числе

/*
int CountFunct(int num)
{
    int i = 1;

    if(num == 0) return i;
    else
    {
        while(num != 0)
            {
                num = num / 10;
                i++;
            }
        return i - 1;
    }
} 


Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Number of digits in {num} is {CountFunct(num)}");
// int a = CountFunct(num);
//Console.Write(a);
*/



//Array:

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

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);


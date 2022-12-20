// Seminar_2: METHODS

// Задача 1. Напишите программу, которая обрабатывает 
// случайное трехзначное число и удаляет среднее число из 3-х чисел 
// и возвращает целое значение из оставшихся двух

/*
int CutNumber(int number)
{
    //int sot = number / 100;
    //int dec = number % 10;
    //int result = sot * 10 + dec;
    int result = (number / 100) * 10 + (number % 10);
    return result;
}

bool IfEven(int num)
{
    if(num % 2 == 0)
        return true;
    else
        return false;
}

int randomNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randomNumber);

Console.WriteLine($"New number from {randomNumber} is {newNumber}");
Console.Write("This number is even - " + IfEven(newNumber));
*/


// Задача 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа. 

/*
int MaxNumber(int num)
{
    int firstNum = num / 10;
    int secondeNum = num % 10;

    if(firstNum == secondeNum) 
    {
        return -1;
    }
    else
    {
        if(firstNum > secondeNum) num = firstNum;
        else num = secondeNum;
        return num;
    }
}

int randomNum = new Random().Next(10, 100);
int maxNum = MaxNumber(randomNum);

if (maxNum == -1) 
{
    Console.Write($"Numbers {randomNum} are equal");
}
else
Console.Write($"Max number from {randomNum} is {maxNum}");
*/


// Задача 3. Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 

/*
bool MultipleNum (int num1, int num2)
{
    if(num2 % num1 == 0) return true;
    else return false;
}

Console.Write("Input number one: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number two: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("The second number is multiple to the first - " + MultipleNum(num1, num2));
*/



// Задача 4. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

bool QuadrNum(int num1, int num2)
{
    if(num1 == num2 * num2 || num2 == num1 * num1) return true;
    else return false;
}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console. ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("One number is quadratic of another: " + QuadrNum(num1, num2));
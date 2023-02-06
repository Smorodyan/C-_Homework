// Homework_9

// Задача_1. Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурси
// N = 5 -> "5, 4, 3, 2, 1"

/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
    if(n < 1) ShowNums(n + 1);
}

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/


// Задача_2. Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int SumofElements(int n, int m)
{
    if(n < m) return SumofElements(n + 1, m) + n;
    else return 0;
}

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n > m)
{
    int temp = n;
    n = m;
    m = temp;
}
Console.Write(SumofElements(n, m + 1));
*/



// Задача_3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AkkermanFunct(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkkermanFunct(n - 1, 1);
    else
      return AkkermanFunct(n - 1, AkkermanFunct(n, m - 1));
}

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Akkerman function result = "+ AkkermanFunct(n,m));


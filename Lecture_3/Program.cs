// ЗАДАЧА_1:

// int Method()
// {
//     return DateTime.Now.Year;
// }

// //int year = Method();
// Console.Write(Method());


// ЗАДАЧА_2:


/*
void Method()
{
    int j;
    for(int i = 2; i <= 10; ++i)
    {
        for(j = 2; j <= 10; j++)
        {
            Console.WriteLine($" {i} x {j} = {i * j}");
        }
        Console.WriteLine();
    }
    
}

Method();
*/


// ЗАДАЧА_3:

/*
string Replacement(string text, char oldValue, char newValue, char oldK, char newK, char oldC, char newC)
{
    string reuslt = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; ++i)
    {
        if(text[i] == oldValue) reuslt = reuslt + newValue;
        else if(text[i] == oldK) reuslt = reuslt + newK;
        else if(text[i] == oldC) reuslt = reuslt + newC;
        else reuslt = reuslt + text[i];
    }
    return reuslt;
}

string text = "— Я думаю, — сказал князь, улыбаясь, — что," 
        + "ежели бы вас послали вместо нашего милого Винценгероде," 
        + "вы бы взяли приступом согласие прусского короля." 
        + "Вы так красноречивы. Вы дадите мне чаю?";

Console.Write(Replacement(text, ' ', '_', 'к', 'К', 'с', 'С'));
*/



// ЗАДАЧА_4


// {6, 2, 5, 7, 3, 9, 5}
/*
void Massiv(int[] array)
{
    for(int i = 0; i <= array.Length - 2; ++i)
    {
        for(int j = 1; j <= array.Length - 1; ++j)
        if(array[i] > array[j])
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
            Console.WriteLine(array[i]);
        }
    }
}



//int[] array = new int[10];
int[] array = {4, 2, 7, 9, 1, 0, 5, 6};
//Console.Write(array[0]);

Massiv(array);
*/



// ЗАДАЧА_5:

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

int[] ConvertArray(int[] array)
{
    int i = 0;
        
    while(i < array.Length)
    {
        int j = i + 1;
        while(j < array.Length)
        {
            int max = array[i];
            if(max <= array[j])
            {
                max = array[j];
                array[j] = array[i];
                array[i] = max;
                j++;
            }
            else j++;
        }
        ++i;
    }    
    return array;
        
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
int[] convertedArray = ConvertArray(newArray);
ShowArray(convertedArray);
*/


// ЗАДАЧА_6:

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

//int[] ConvertArray(int[] array)
void ConvertArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[i] < array[j])
            {
                int max = array[j];
                array[j] = array[i];
                array[i] = max;
            }
        }
    }
  //  return array;
        
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
// int[] convertedArray = ConvertArray(newArray);
// ShowArray(convertedArray);
ConvertArray(newArray);
ShowArray(newArray);
*/



// ЗАДАЧА_7



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

void ConvertedArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[i] > array[j])
            {
                int max = array[i];
                array[i] = array[j];
                array[j] = max;
            }
        }
    }
}


Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = (CreateRandomArray(length, min, max));
ShowArray(newArray);
ConvertedArray(newArray);
ShowArray(newArray);


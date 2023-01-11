// int Method()
// {
//     return DateTime.Now.Year;
// }

// //int year = Method();
// Console.Write(Method());

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



// First Type ничего не принимает и ничего не возвращает
void Method1()
{
    Console.WriteLine("Author...");
}
//Method1();


// Second Type  принимает Какие-то аргументы, но ничего не возвращаеет

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Text", 5);
//Method21(count: 5, msg: "new text");


// Third Type  ничего не принимает, но что-то возвращаеет 

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Fourth Type  принимает Какие-то аргументы и что-то возвращаеет

//string Method4(int count, string text)
//{
//    int i = 0;
//    string result = String.Empty;
//
//    while (i < count)
//    {
//
//        result = result + text;
//        i++;
//    }
//    return result;
//}

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(text: "Text", count: 15);
//Console.WriteLine(res);


for (int i = 1; i <= 10; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");

    }
    Console.WriteLine();
}

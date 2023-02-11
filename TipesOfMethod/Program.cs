// Tipe 1
void Method1()
{
    Console.WriteLine("Author...");

}



// Tipe 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Sample Text", count: 4);


//Tipe 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Tipe
string Method4(int count, string text)
{
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
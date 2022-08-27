// вид 1 Ничего не принимают, ничего не возвращают
/*
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();
*/


// вид 2 что-то принимают, ничего не возращают
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Сообщение");
*/

/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Сообщение", count: 4);
*/


// вид 3 ничего не принимают, что-то возвращают
/*
int Method3()
{
    return DateTime.Now.Year;    
}

int year = Method3();
Console.WriteLine(year);
*/


// вид 4 Что-то принимают, что-то возращают
/*
string Mehod4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Mehod4(10, "x");
Console.WriteLine(res);
*/

// цикл for
/*
string Mehod4(int count, string c)
{
        string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Mehod4(3, "x");
Console.WriteLine(res);
*/

// цикл в цикле (таблица умножения)
// начальное условие for (int i = 0; i < length; i++)
/*
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();      
}
*/


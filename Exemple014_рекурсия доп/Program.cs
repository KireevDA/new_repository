// // Собрать строку с цифрами от А до В, А<=В
// // метод итерации for
// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";
//     }
//     retirn result;
// }

// // метод рекурсии
// string NumbersRec(int a, int b)
// {
//     if (a <= b)
//         return $"{a} " + NumbersRec(a + 1, b);
//     else
//         return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

// // Сумма чисел от 1 до n
// // итерация
// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++)
//         result += i;
//     return result;
// }

// // рекурсия
// int SumRec(int n)
// {
//     if (n == 0)
//         return 0;
//     else
//         return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10)); // 5 5
// Console.WriteLine(SumRec(10)); // 5 5

// // Факториал числа
// // итеративный подход
// int FactorialFor(int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++)
//         result *= i;
//     return result;
// }

// // рекурсивный подход
// int FactorialRec(int n)
// {
//     if (n == 1)
//         return 1;
//     else
//         return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10)); // 3 6 2 8 0 0
// Console.WriteLine(FactorialRec(10)); // 3 6 2 8 0 0

// // вычислить a в степени n
// // итерация
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 0; i <= n; i++) result *= a;
//     return result;
// }

// // рекурсия
// int PowerRec(int a, int n)
// {
//     // return n == 0 ? 1 : PowerRec(a,n -1) * a;
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// // используем математические формулы
// int PowerRecMath(int a, int n)
// {
//     if(n == 0) return 1;
//     else if (n% 2 == 0) return PowerRecMath (a*a, n/2);
//     else return PowerRecMath(a, n-1) * a;
// }

// Console.WriteLine(PowerFor(2, 10)); // 1024
// Console.WriteLine(PowerRec(2, 10)); // 1024
// Console.WriteLine(PowerRecMath(2, 10)); // 1024


// // Перебор слов
// // В некотором машинном алфавите имеются четыре буквы "а", "и", "с", "в". 
// // Покажите все слова, состящие из Т букв, которые можно построить из букв этого алфавита.
// // итеративный способ
// char [] s = { 'a', 'и', 'с', 'в'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//    for (int j = 0; j < count; j++)
//    {
//      и т.д.
//    } 
// }

// // рекурсивный метод

// int n = 1;
// void FindWords (string alphabet, char[] word, int length - 0)
// {
//     if (length == word.length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i<alphabet.Length; i++)
//     {
//         word[length] = alphabet[1];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[5]);

// Как посмотреть что внутри папки? 
/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");    
    }
}
string path = "C:\Users\Киреев\dev\new_repository\new_repository\Exemple003_Sum";
CatalogInfo(path);
*/

// string path = "Exemple002_HelloConsole";
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles();

// for (int i = 0; i< fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name);
// }

// Игра в пирамидки
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers (with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers (some, on, with, count - 1);
}
Towers();
*/

// // Обход разных структур (Бинарные деревья)
// // Задача: ((4 - 2) * (1 + 3)) / 10
// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
// //                  0   1    2     3    4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2*pos;
//         int right = 2*pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();


// // проблемы в использовании рекурсии
// 1. Долгое время подсчетов (например подсчет чисел Фибоначчи)
// 2. Переполнение стэка (не хватает памяти, если в примере взять сторону например в 1000)
/*
int[,] pic = new int[10, 10];
for (int i = 0; i < 10; i++)
{
 pic[0, i] = 1;
 pic[i, 0] = 1;
 pic[i, 9] = 1;
 pic[9, i] = 1;
}

PrintImage(pic);
FillImage(1, 1);
Console.WriteLine();
PrintImage(pic);

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
*/


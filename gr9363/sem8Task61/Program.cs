// Задача No61
// Вывести первые N строк треугольника Паскаля. 
//  Сделать вывод в виде равнобедренного треугольника

//Метод Ввода
// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// // n!/k!*(n-k)!
// long Factorial(int n)
// {
//     long res = 1;
//     for (int i = 0; i <= n; i++)
//     {
//         res = res * i;
//     }
//     return res;
// }

// void PrintPascalTriangle(int nRow)
// {
//     for (int i = 0; i < nRow; i++)
//     {
//         for (int k = 0; k < nRow - i; k++)
//         {
//             Console.Write(" ");
//         }
//         for (int j = 0; j <= i; j++)
//         {
//             Console.Write(" ");
//             Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j)));
//         }
//         Console.WriteLine();

//     }
// }
// int countRow = ReadData("Введите количество строк ");
// PrintPascalTriangle(countRow);

// Метод ввода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Метод вычесления факториала
long Factorial(int n)
{
    long res = 1;
    for(int i=1; i<=n; i++) 
    {
        res=res*i;
    }
    return res;
}
//Метод печати факториала
void PrintPascalTriangle(int nRow)
{
    for(int i=0; i<nRow; i++)
    {
        for(int k=0; k<nRow-i; k++)
        {
             Console.Write(" ");   
        }
        for(int j=0; j<=i; j++)
        { 
            Console.Write(" ");    
            Console.Write(Factorial(i)/(Factorial(j)*Factorial(i-j)));
        }
        Console.WriteLine();
    }
}    

int countRow = ReadData("Введите колличество строк треугольника Паскаль: ");
PrintPascalTriangle(countRow); 
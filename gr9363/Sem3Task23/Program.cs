// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Метод читает данные от пользователя
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

string LineBuilder(int end, int pow)
{
    string res = string.Empty;
    for (int i = 1; i <=end; i++)
    {
        res = res + Math.Pow(i,pow)+" ";
    }
    return res;
}
int N = ReadDate("Введите конечное число: ");
Console.WriteLine(LineBuilder(N,1));
Console.WriteLine(LineBuilder(N,3));
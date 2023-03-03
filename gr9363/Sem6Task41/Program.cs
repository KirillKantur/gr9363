// No41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//Метод ввода данных
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// метод печати
void PrintResult(string msg, int num)
{
    Console.WriteLine(msg + num);
}
// метод нахождения положительных чисел
int CountNum(int numM)
{
    int res = 0;
    for (int i = 0; i < numM; i++)
    {
        if(ReadDate("введите число")>0)
        {
            res++;
        }
    }
    return res;
}
int testCount = ReadDate("Введите колличество раз ввода числа");
int countM = CountNum(testCount);
PrintResult("колличество положительных чисел ",countM);
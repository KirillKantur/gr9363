// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе.

//Метод ввода данных
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод вывода данных пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
//Метод сложения цифр числа
int n = ReadDate("Введите число");
int sum = 0;
while (n != 0)
{
    sum += n%10;
    n /= 10;
}

PrintData("Сумма чисел ", sum);
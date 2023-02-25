// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N. 

// Метод читает данные от пользователя
using System.Numerics;
int ReadDate(string msg)
{
    //Выводим сообщение
    Console.WriteLine(msg);
    //Считываем число и возвращаем значение
    return int.Parse(Console.ReadLine() ?? "0");
}
// метод печати
void PrintResult(string msg, BigInteger num)
{
    Console.WriteLine(msg+num);
}
// метод нахождения факториала
BigInteger FactorCalc(int num)
{
    BigInteger res = 1;
    for (int i = 2; i < num; i++)
    {
        res = res*i;
    }
    return res;
}
// обращение к методу readdata
int num = ReadDate("Введите число: ");
//обращение к методу нахождения факториала
BigInteger res = FactorCalc(num);
//обращение к методу печати
PrintResult("Вывод результата: ", res);
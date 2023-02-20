// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// Метод читает данные от пользователя
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Тест полиндрома
bool PalinTest(int num)
{
    bool res = false;
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == ((num / 10) % 10)))
    {
        res = true;
    }
  
    return res;
}

int num = ReadDate("Введите пятизначное число");
bool res = PalinTest(num);
if (res==true)
{
    Console.WriteLine("Это число полимод");
}
else
{
   Console.WriteLine("Это число не полимод"); 
}
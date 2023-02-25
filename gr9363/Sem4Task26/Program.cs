// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

// Метод читает данные от пользователя
int ReadDate(string msg)
{
    //Выводим сообщение
    Console.WriteLine(msg);
    //Считываем число и возвращаем значение
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод вывода данных пользователя
void PrintResult(int msg)
{
    Console.WriteLine(msg);
}

int num = ReadDate("Введите число: ");
//Метод через перевод числа в строки и подчет длины

int res = num.ToString().Length;

PrintResult(res);
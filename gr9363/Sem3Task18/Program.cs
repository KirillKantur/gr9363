

// Метод читает данные от пользователя
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintAnswer(int num)
{

    if (num == 1) Console.WriteLine("x>0, y>0");
    if (num == 2) Console.WriteLine("x>0, y<0");
    if (num == 3) Console.WriteLine("x<0, y<0");
    if (num == 4) Console.WriteLine("x<0, y>0");

}
int num = ReadDate("Введите номер четверти");
if (num > 0 && num < 5)
{
    PrintAnswer(num);
}
else
{
    Console.WriteLine("Диапозон задан не верно");
}
 
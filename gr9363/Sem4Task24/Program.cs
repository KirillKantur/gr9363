// Задача №24
// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.

// Метод читает данные от пользователя
int ReadDate(string msg)
{
    //Выводим сообщение
    Console.WriteLine(msg);
    //Считываем число и возвращаем значение
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод вывода данных пользователя
void PrintResult(string line)
{
    Console.WriteLine(line);
}

long SumSimpl(int numA)
{
    int sum = 1;
    for (int i = 1; i < numA; i++)
    {
        // sum = sum + i;
        sum += i;
    }

    return sum;
}

long SumGausse(int numA)
{
    return ((1+(long)numA)*(long)numA)/2;
}

int numberA = ReadDate("Введите число А: ");

DateTime d1 = DateTime.Now;
long res1 = SumSimpl(numberA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
long res2 = SumGausse(numberA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна (простой метод):" + res1);
PrintResult("Сумма чисел от 1 до A равна(метод Гауса):" +res2);
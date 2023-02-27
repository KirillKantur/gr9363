// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.
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


// Метод возведения числа а в степень числаб
long Pow(int numA, int numB)
{
    long res = 0;
    while (numB > 0)
    {
        res = res + numA;
        numB = numB - 1;
    }
    return res;
}
int numA = ReadDate("Введите число А");
int numB = ReadDate("Введите число B ");
long res = Pow(numA,numB);
PrintData("А в степени B ", + res);
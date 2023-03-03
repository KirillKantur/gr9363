// Задача No42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//Метод ввода данных
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// метод печати
void PrintResult(string msg, string num)
{
    Console.WriteLine(msg + num);
}
// Метеод перевода числа из десятиричной системы в двоичную
string DecToBin(int num)
{
    string res = string.Empty;
    while(num>0)
    {
        res = num%2 +res;
        num= num/2;
    }
    return res;
}

int newTest = ReadDate("Введите число");
string newDoub =DecToBin(newTest);
PrintResult("Наше число " ,newDoub);
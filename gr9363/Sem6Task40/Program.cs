// Задача No40
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.


// // Встроинный метод перевода из десятиричной системы в любую другую
// string DecToBinNativ(int num)
// {
//     return Convert.ToString(num,2);// где два это система в которую переводим
// }

//Метод ввода данных
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// метод печати
void PrintResult(string msg, bool num)
{
    Console.WriteLine(msg + num);
}
// Метод проверки треугольника с заданными сторонам
bool TriangleTest(int a, int b, int c)
{
    bool res = false;
    if ((a < b + c) && (b < a + c) && (c < a + b))
    {
        res = true;
    }
    return res;
}
int sideA = ReadDate("Введите длину стороны A ");
int sideB = ReadDate("Введите длину стороны B ");
int sideC = ReadDate("Введите длину стороны C ");
PrintResult("Результат проверки сторон треугольника", TriangleTest(sideA,sideB,sideC));
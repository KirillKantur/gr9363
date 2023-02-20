// Задача №17
// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем х не равен 0 и Y не равен 0, и выводит номер четверти плоскости, в которой находиться эта точка.

// <тип д> <имя метода> (<тип> <Название переменной>)
// {
//     return <тип>
// }

// Метод читает данные от пользователя
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет четверть по координатам точки
void PrintQuterTest(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("Точка в 1 четверти");
    if (x > 0 && y < 0) Console.WriteLine("Точка в 2 четверти");
    if (x < 0 && y < 0) Console.WriteLine("Точка в 3 четверти");
    if (x < 0 && y > 0) Console.WriteLine("Точка в 4 четверти");
}
int coordX = ReadDate("Введите координату X: ");
int coordY = ReadDate("Введите координату Y: ");
PrintQuterTest(coordX, coordY);
// Задача №20
// Напишите программу, которая принимает на входе координаты двух точек и находит расстояние между ними на 2D плоскости

// Метод читает данные от пользователя
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Метод вывода данных пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}
// Метод находит растояние между точками на плоскости
double CalcLen2D(int x1,int x2, int y1,int y2)
{
    return Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
}

int x1 = ReadDate("Введите координату x точки A");
int y1 = ReadDate("Введите координату y точки A");
int x2 = ReadDate("Введите координату x точки B");
int y2 = ReadDate("Введите координату y точки B");

double res = CalcLen2D(x1,x2,y1,y2);

PrintData("Растояние между точками A и B ", res);
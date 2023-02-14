// Задача №4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numC = Convert.ToInt32(Console.ReadLine());
if (numA>numB)
{
    if (numA>numC)
    {
        Console.WriteLine(numA);
    }
    else
    {
        Console.WriteLine(numC);
    }
}    
else
{
    if (numB>numC)
    {
        Console.WriteLine(numB);
    }
    else
    {
    Console.WriteLine(numC);
    }
}    
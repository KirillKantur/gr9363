// Задача №2
// Напишите программу, которая на входе принимает два числа и выдает, какое число большее, а какое меньшее

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA>numB)
{
    Console.WriteLine("Число А больше числа Б");
}
else
{
    Console.WriteLine("Число Б больше числа А");
}
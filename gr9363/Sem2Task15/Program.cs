﻿// №15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int num1 = int.Parse(Console.ReadLine()?? "0");
if (num1>=1 && num1 <6)
{
    Console.WriteLine("Это будний день");
}
else
{
     Console.WriteLine("Это Выходной день");
}
﻿//задача №0
//Напишите программу, которая на входе принимает число и
// выдает его квадрат (число умноженое само на себя)

// Считываем данные с конслоли
string? inputNum = Console.ReadLine();

// Проверяем, чтобы данные были не пустыми
if(inputNum != null)
{
    // парсим введенное число превращаем строку в число
    int number = int.Parse(inputNum);

    // находим квадрат числа
    int outnum = number*number;


    // выводим данные в консоль
    Console.WriteLine("Квадрат числа  "+outnum);

    
}
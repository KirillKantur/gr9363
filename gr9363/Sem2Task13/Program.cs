// S№13 Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет. 

string num = Console.ReadLine();
if (num.Length>=3)
{
char[] array = num.ToCharArray();
Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Третей цифры нет");
}
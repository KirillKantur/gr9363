// Задача №33
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.

//Метод ввода данных
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод генерации массива
int[] Gen1DArr(int len, int minValue, int maxValue)
{
    // Блок корректировкивходных данных
    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }

    Random rnd = new Random();
    int[] arr = new int[len];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
    return arr;
}
// Метод печати масива
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// Метод нахождения элемента
int SearchElem(int[] arr, int elm)
{
    int res = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            res = i; break;
        }
    }
    return res;
}

int[] array = Gen1DArr(10, 1, 10); Print1DArr(array);
int num = ReadDate("Введите цифру для поиска");
int indexElem = SearchElem(array, num);
if (indexElem > 0)
{
    Console.WriteLine("Искомый элемент найден" + indexElem);
}
else
{
    Console.WriteLine("Искомый элемент не найден");
}
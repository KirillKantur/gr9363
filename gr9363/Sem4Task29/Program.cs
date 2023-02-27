// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 

//Метод ввода данных
int ReadDate(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] Gen1DArr(int num, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max);
    }
    return arr;
}
void Print1DArr(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
int num = ReadDate("Введите длину массива");
int min = ReadDate("Введите минимальное значение диапозона");
int max = ReadDate("Введите максимальное значение диапозона");
Print1DArr(Gen1DArr(num,min,max));
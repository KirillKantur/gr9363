// Задача №35
// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].


//Метод вывода данных пользователя
void PrintData(string line, int num)
{
    Console.WriteLine(line + num);
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
// Метод нахождения элементов масив в заданном отрезке
int NumElemInRange(int[] arr, int minValue, int maxValue)
{
    if (minValue > maxValue)
    {
        int temp = minValue;
        minValue = maxValue;
        maxValue = temp;
    }
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] > minValue) && (arr[i] < maxValue))
        {
            res++;
        }
    }
    return res;
}
int[] testArr = Gen1DArr(123, -100, 100);
Print1DArr(testArr);
int col = NumElemInRange(testArr, 10, 99);
PrintData("Колличестыо элементов в диапозоне ", col);
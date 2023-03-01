// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.

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

int OddSum(int[]arr)
{
    int res=0;
    for (int i = 1; i < arr.Length; i=i+2)
    {
        res=res+arr[i];
    }
    return res;
}
int[] testArr = Gen1DArr(20,1,10);
Print1DArr(testArr);
int sum = OddSum(testArr);
PrintData("Сумма не четных элементов масива ", sum);
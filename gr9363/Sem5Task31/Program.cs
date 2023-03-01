// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.

// Метод генерации масива
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
// Метод вывода данных пользователя
void PrintData(string msg, double val)
{
    Console.WriteLine(msg + val);
}
// Метод сложения отрицательных и положительных элементов 2д масива
(int posit, int negot) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum += arr[i];
        }
    }

    return (positSum, negotSum);
}

int[] testArr = Gen1DArr(12, -9, 9);
Print1DArr(testArr);
(int posit, int negot) result = NegPosSum(testArr);
PrintData("Сумма положительых чисел в массиве: ", result.posit);
PrintData("Сумма отрицательных чисел в массиве: ", result.negot);
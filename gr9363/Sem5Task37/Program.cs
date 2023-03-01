// Задача №37
// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.


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

//метод конвертации масивов
int[] ConvertArr(int[] arr)
{
    int[] bufArr = new int[(arr.Length/2)+1];
    for (int i = 0; i < ((arr.Length/2)+1); i++)
    {
        bufArr[i]= arr[i]*arr[arr.Length-1-i];
    }
    return bufArr;
}

int[] testArr = Gen1DArr(20,1,10);
Print1DArr(testArr);
int[] res = ConvertArr(testArr);
Print1DArr(res);
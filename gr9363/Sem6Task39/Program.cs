// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

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
// //Метод перевертывания массива (первый элемент на последнее место а последний на первое)
// void SwapArray(int[] arr)
// {
//     int bufElem = 0;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         bufElem = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = bufElem;
//     }
// }
//Метод перевертывания массива (первый элемент на последнее место а последний на первое) с помощью нового массива
int[] SwapNewArray(int[]arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < outArr.Length; i++)
    {
       outArr[i] = arr[arr.Length-1-i]; 
    }
    return outArr;
}

int[] testArray = Gen1DArr(10, 10, 100);
Print1DArr(testArray);
Console.WriteLine();
// SwapArray(testArray);
int[] newArray = SwapNewArray(testArray);
// Print1DArr(testArray);
Print1DArr(newArray);
// Задача №48
// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
//Метод генерации 2Д массива Модифицированный
int[,] Gen2DArrayMod(int countRows, int countColumn)
{
    int[,] res = new int[countRows, countColumn];
    {
        for (int i = 0; i < countRows; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                res[i, j] = i + j;
            }
        }
    }
    return res;
}
//Метод печати 2Д массива
void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] testArr = Gen2DArrayMod(8, 9);
Print2DArr(testArr);
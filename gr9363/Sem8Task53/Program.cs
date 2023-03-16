// Задача No53
// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

//Метод Ввода
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод генерации 2Д массива
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

//Метод печати 2Д массива
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}


void change2DArray(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1,i] = temp;
    }
}

int m = ReadData("Введите количество строк ");
int n = ReadData("Ввведите количество столбцов ");
int[,] testArray = Gen2DArr(m,n,1,10);
Print2DArr(testArray);
change2DArray(testArray);
Print2DArr(testArray);
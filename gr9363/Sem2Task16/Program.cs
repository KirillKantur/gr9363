//Задача №16
//Напишите программу, которая принимает на вход
//два числа и проверяет, является ли одно число
//квадратом другого. 

void squareTest(int firstNum, int secondNum)
{
    if(firstNum == Math.Pow(secondNum,2))
    {
        Console.WriteLine($"Число{firstNum} является квадратом {secondNum}");
    }
    else
    {
        Console.WriteLine($"Число{firstNum} не является квадратом {secondNum}");
    }
}

Console.WriteLine("Введите первое число; ");
int firsNumer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число; ");
int SecondNumer= Convert.ToInt32(Console.ReadLine());

squareTest(firsNumer,SecondNumer);

squareTest(SecondNumer,firsNumer);

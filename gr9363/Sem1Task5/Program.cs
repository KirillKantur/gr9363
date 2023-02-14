// Напишите программу которая на входе примит число (n), а на выходе показывает все целые числа в промежутке от -n до n

// Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputLine != null)
{
    // Парсим введеное число
    int  inputNumber = int.Parse(inputLine);

    int startNumber = inputNumber*(-1);

    //Выходное значение
    string outLine = string.Empty;

    while (startNumber<inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        //startNumber=startNumber+1
        startNumber++;
        
    }
    outLine = outLine + inputNumber;

    // Выводим данные в консоле
    Console.WriteLine(outLine);
}
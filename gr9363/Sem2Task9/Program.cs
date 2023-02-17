// Задание №9
// Системный генератор случайного числа
System.Random numSintezanor = new System.Random();

// Вариант решения №1
// обращаемся к синтезатору случайных чисел и просим его предоставить случайное число
//int rndNumber = numSintezanor.Next(10, 100);
// отобразим синтезируемое число
////Console.WriteLine(rndNumber);
// Вводим переменную = первой цыфры числа
//int FirstNum = rndNumber / 10;
// Вводим переменную = второй цифре числа
//int SecondNum = rndNumber % 10;
// Сравниваем два числа
//if (FirstNum > SecondNum)
//{
    // если первая цифра больше второй то выводим значение в терминал
////    Console.WriteLine("Первое число" + FirstNum);
//}
//else
//{
    // // если вторая цифра больше первой то выводим значение в терминал
 //   Console.WriteLine("Второе число" + SecondNum);
//}

//Вариант 2
// берем массив   добавляем рандом         , переводим в строку и дальше добавляем в масив
char[] digits = numSintezanor.Next(10, 100).ToString().ToCharArray();
Console.WriteLine(digits);
int FirstNum = ((int)digits[0]) - 48;
int SecondNum = ((int)digits[1]) - 48;

// <переменная> = (условие)?<значение1>:<значение2>;
// это равносильно 
// if(условие)
//   {
//     <переменная> = <переменная1>
//   }
//  else
//   {
//    <переменная> = <переменная2>
//   }
int resultNumber = FirstNum > SecondNum ? resultNumber = FirstNum : resultNumber = SecondNum;
Console.WriteLine(resultNumber);
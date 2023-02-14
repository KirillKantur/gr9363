// Задача №3
// Напишите программу,
// которая будет выдавать название дня недели по заданному номеру

Console.Write("Введите номер дня недели");
string? lineday = Console.ReadLine();
if (lineday != null)
{
    int day = int.Parse(lineday);
    string[] dayweek = new string[7];
    dayweek[0] = "Понедельник";
    dayweek[1] = "Вторник";
    dayweek[2] = "Среда";
    dayweek[3] = "Четверг";
    dayweek[4] = "Пятница";
    dayweek[5] = "Суббота";
    dayweek[6] = "Воскресенье";
    Console.WriteLine(dayweek[day - 1]);
}

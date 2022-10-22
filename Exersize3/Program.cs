// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите порядковый номер дня недели");
string dayNumber = Console.ReadLine();
int result = int.Parse(dayNumber);
if(result >= 1 && result <= 5)
    Console.WriteLine("Рабочий день");
if(result > 5 && result <= 7)
    Console.WriteLine("Выходной день");
if(result > 7 || result < 1)
Console.WriteLine("Научитесь ПРАВИЛЬНО считать дни недели!!!");
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
string numberA = Console.ReadLine();
int number = Math.Abs(int.Parse(numberA));
int result = number / 100;
if(result > 0)
    Console.WriteLine($"Третьей цифрой числа {number} является {result % 10}");
else
    Console.WriteLine($"Третья цифра в числе отсутсвует");

// Задача 2: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100) Console.WriteLine("Третьей цифры нет");
if (number > 99)
{
    if (number > 99 & number < 1000) number = number % 10;
    if (number > 999 & number < 10000) number = number % 100 / 10;
    if (number > 9999 & number < 100000) number = number % 1000 / 100;
    if (number > 99999 & number < 1000000) number = number % 10000 / 1000;
    if (number > 999999 & number < 10000000) number = number % 100000 / 10000;
    if (number > 9999999 & number < 100000000) number = number % 1000000 / 100000;
    if (number > 99999999 & number < 1000000000) number = number % 10000000 / 1000000;
    Console.WriteLine($"Третья цифра в этом числе > {number}");
}









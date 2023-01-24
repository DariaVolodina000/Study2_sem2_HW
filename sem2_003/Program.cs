// Задача 3: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели, что бы узнать выходной это или нет");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 & day < 6) Console.WriteLine("no");
if (day > 5 & day < 8) Console.WriteLine("yes");
if (day < 1) Console.WriteLine("Введите цифру от 1 до 7");
if (day > 7) Console.WriteLine("Введите цифру от 1 до 7");
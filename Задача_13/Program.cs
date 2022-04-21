/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число");
int num1=Convert.ToInt32(Console.ReadLine());
string numS=num1.ToString();
if (num1>99)
{
    Console.WriteLine(numS[2]);
}
else
Console.WriteLine ("Третьего числа нет");
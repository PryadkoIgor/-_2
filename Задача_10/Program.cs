/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int num1 = new Random().Next(100,1000);
Console.WriteLine(num1);
num1=(num1%100)/10;
Console.WriteLine(num1);
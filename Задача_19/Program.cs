/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

string num = Convert.ToString(new Random().Next(10000, 100000));
bool pol = true;
for (int i = 0; i < num.Length / 2; i++)
{
    if (num[i] != num[num.Length - i - 1])
    {
        pol = false;
        break;
    }
}
if (pol)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}
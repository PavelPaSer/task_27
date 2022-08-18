// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int index = 0;

while (numberN > 0)
{
int num = numberN % 10;
numberN = numberN / 10;
index = index + num;
}
Console.WriteLine("сумма в чисел равна: " + index);
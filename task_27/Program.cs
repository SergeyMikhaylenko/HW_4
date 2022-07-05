// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (numberA > 0)
{
int numberB = numberA % 10;
numberA = numberA / 10;
result = result + numberB;
}
Console.WriteLine(result);
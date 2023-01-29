/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и
 на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int InputInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputInt("Введите трехзначное число");

if (number > 99 && number < 1000)
{
    Console.Write($"{number % 100 / 10}");
}
else
{
    Console.WriteLine($"Число {number} не трехзначное");
}
/*
Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputInt("Введите цифру");

if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.Write("Выходной");
    }
    else
    {
        Console.Write("Рабочий день");
    }
}
else
{
    Console.Write("Такого дня недели нет.");
}

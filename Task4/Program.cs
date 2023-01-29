/*
Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру 
этого числа. 
Не использовать строки для расчета.
*/

int num = new Random().Next(100, 1000);

int DeleteSecond(int number)
{
    int a = number / 100;
    int b = number % 10;
    int result = a * 10 + b;
    return result;
}

Console.WriteLine($"{num} -> {DeleteSecond(num)}");

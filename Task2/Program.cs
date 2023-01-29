/*Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int InputInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputInt("Введите число");

if (number > 99)
{
    if (number < 1000)
    {
        Console.WriteLine($"{number % 10}");
    }
    else
    {
        while (number > 1000)
        {
            number /= 10;
        }
        Console.WriteLine($"{number % 10}");
    }

}
else
{
    Console.WriteLine("Третьей цифры нет.");
}



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


if (number < 100 && number > 0)
{
    Console.WriteLine("В заданном числе нет третьей цифры");
}
else if (number > 100 && number < 1000)
{
    Console.WriteLine("Третья цифра числа: " + number % 10);
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    Console.WriteLine("Третья цифра заданного числа: " + number % 10);
}

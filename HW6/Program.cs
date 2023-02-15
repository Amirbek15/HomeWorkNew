// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
string input = Console.ReadLine();
if (input.Length >= 3)
{
    char char3 = input[2];
    Console.WriteLine($"Третья цифра числа: {char3}");
}
else
{
    Console.WriteLine("Ошибка! Третьей цифры нет.");
}



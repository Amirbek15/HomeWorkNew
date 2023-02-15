// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> Yes
// 7 -> Yes
// 1 -> No


Console.WriteLine("Введите номер недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 6 || day == 7)
{
    Console.WriteLine($"Выходной!");
}
else if(day == 1 || day == 2 || day == 3 || day == 4 || day == 5)

{
    Console.WriteLine($"Рабочий день!");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}










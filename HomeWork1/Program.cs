// Задача 4. Напишите программу, которая принимает на вход три числа и выдает максимальное из этих числе.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxnumber = number1;
if(maxnumber <= number2)
{
    maxnumber = number2;
}
if(maxnumber <= number3)
{
    maxnumber = number3;
}   

    Console.Write($"Максимальное число{number1}");


Console.Write("max = ");
Console.WriteLine(maxnumber);





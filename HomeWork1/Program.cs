// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньншее.

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





// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 0;

while(temp < N)
{
    temp = temp + 1;
    if(temp % 2 == 0)
    Console.Write($"{temp} ");
}







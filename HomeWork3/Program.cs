// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int temp = number % 2;

bool result = temp == 0;

if(result)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}










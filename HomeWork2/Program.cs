// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньншее.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int maxnumber = number1;
if(maxnumber < number2)
{
    Console.WriteLine($"Максимальное число = {number2}");

    Console.WriteLine($"Минимальное число = {number1}");
}

else if(number1 == number2)
    Console.WriteLine($"Числа равны");

   
else
  {
    Console.WriteLine($"Максимальное число{number1}");
    Console.WriteLine($"Минимальное число{number2}");
  }


















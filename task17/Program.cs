// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


//  int n = 5; // замените это на любое другое значение, если нужно вывести другое количество чисел Фибоначчи
//         int a = 0, b = 1, c;
//         Console.Write("{0} {1}", a, b);

//         for (int i = 2; i < n; i++)
//         {
//             c = a + b;
//             Console.Write(" {0}", c);
//             a = b;
//             b = c;
//         }


// Console.WriteLine("Enter number: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[count];
// arr[0] = 0;
// arr[1] = 1;
// int num = 2;

// while (count > num)
// {
//     arr[num] = arr[num - 1] + arr[num - 2];
//     num++;
// }

// for(int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }


void PrintFibToN(int number)
{
System.Console.Write("0 1 ");
int neighbour1 = 0;
int neighbour2 = 1;
int res = 0;

for(int i = 0; i < number - 2; i++)
{
res = neighbour1 + neighbour2;
System.Console.Write($"{res} ");
neighbour1 = neighbour2;
neighbour2 = res;
}
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
PrintFibToN(N);

// if(N > 2)
// {
// PrintFibToN(N);
// }
// else if (N <= 1)
// {
// System.Console.Write("Неправильный ввод");
// }
// else
// {
// System.Console.Write("0 1 ");
// }









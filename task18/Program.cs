// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Enter number: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[count];
int [] arr2 = new int[count];
int count2 = 0;

for(int i = 0; i < count; i++)
{
    arr[i] = new Random().Next(10,200);
}

while (arr.Length > count2)
{
    arr2[count2] = arr[count2];
    Console.WriteLine($"{arr[count2]} - {arr2[count2]}\n");
    count2++;
}


int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int[length];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 10);
}
return arr;
}

// System.Console.WriteLine("Введите длину массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArrayWithRandomNumbers(length);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");
// int[] NewArray = new int[length];
// System.Console.WriteLine($"[{string.Join(", ", NewArray)}]");
// for(int i = 0; i < length; i++)
// {
// NewArray[i] = array[i];
// }

// System.Console.WriteLine($"[{string.Join(", ", NewArray)}]");

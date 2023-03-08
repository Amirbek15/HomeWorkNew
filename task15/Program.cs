// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник сo сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// Метод 1

// Console.WriteLine("Введите длины сторон треугольника: ");

//         Console.Write("a = ");
//         double a = double.Parse(Console.ReadLine());

//         Console.Write("b = ");
//         double b = double.Parse(Console.ReadLine());

//         Console.Write("c = ");
//         double c = double.Parse(Console.ReadLine());

//         bool isTriangle = (a + b > c) && (a + c > b) && (b + c > a);

//         if (isTriangle) {
//             Console.WriteLine("Треугольник существует.");
//         } else {
//             Console.WriteLine("Треугольник не существует.");
//         }

//         Console.ReadKey();


// Метод 2

// Console.WriteLine("Введите первую сторону: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую сторону: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью сторону: ");
// int C = Convert.ToInt32(Console.ReadLine());

// if(A + B > C && B + C > A && A + C > B)
// {
// Console.WriteLine("Существует");
// }
// else
// {
// Console.WriteLine("Не существует");
// }


// Метод 3
Console.WriteLine("Введите числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if(a + b > c && a + c > b && c + b > a)
{
    Console.WriteLine("True");
}
else
{
    Console.Write("False");
}




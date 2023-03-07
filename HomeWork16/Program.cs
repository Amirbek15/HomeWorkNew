// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int Promt (string message)
{
 Console.WriteLine(message);
 string str = System.Console.ReadLine() ?? String.Empty;
 double numberDouble = (int) Convert.ToDouble(str);
 int result = (int) Math.Abs(Convert.ToInt32(numberDouble));
 if (result == 0)
 {
 Console.WriteLine("Вы указали недостаточный размер массива!");
 return -1;
 }
 return result;
}

double [] PaddingWithRealNumbers (int sizeArray)
{
 double [] fillArray = new double [sizeArray];
 Random rnd = new Random();
 for (int i = 0; i < sizeArray; i++)
 {
 fillArray[i] = rnd.Next(-99,100) + Math.Round(rnd.NextDouble(), 2);
 }
 return fillArray;
}
 
double DifferenceMaxMinValue (double [] ArrayIn)
{
 double maxElement = ArrayIn[0];
 double minElement = ArrayIn[0];
 if (ArrayIn.Length == 1)
 {
  Console.WriteLine("Недостаточно элементов массива!");
  return -1;
 }

 for (int i = 0; i < ArrayIn.Length; i++)
 {
  if (maxElement<ArrayIn[i])
  {
   maxElement = ArrayIn[i];
  }
  if (minElement>ArrayIn[i])
  {
   minElement = ArrayIn[i];
  }
 }
 Console.WriteLine($"Ваше максимальное значение: {maxElement}");
 Console.WriteLine($"Ваше минимальное значение: {minElement}");
 return maxElement-minElement;
}

int sizeDoubleArray = Promt ("Введите размер вашего массива");
double [] newArray = PaddingWithRealNumbers(sizeDoubleArray);
Console.WriteLine(string.Join("; ", newArray));
Console.WriteLine($"Разница между значениями: {DifferenceMaxMinValue(newArray)}");







// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        string str = number.ToString();
        bool isPalindrome = true;
        
        for (int i = 0; i < str.Length / 2; i++) {
            if (str[i] != str[str.Length - i - 1]) {
                isPalindrome = false;
                break;
            }
        }
        
        if (isPalindrome) {
            Console.WriteLine("Число является палиндромом.");
        } else {
            Console.WriteLine("Число не является палиндромом.");
        }
    













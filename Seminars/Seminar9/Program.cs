//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

// void ShowNumbers(int n)
// {
//     if(n > 0)
//     {
//         ShowNumbers(n - 1);
//         Console.Write(n + " ");
//     }
// }

// ShowNumbers(5);


//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9

// int FindSum(int num)
// {
//     if(num > 0)
//     {
//         return FindSum(num / 10) + num % 10;
//     }
//     else return num;
// }

// Console.WriteLine(FindSum(1329));


//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

// void ShowNumbers(int num1, int num2)
// {
//     if(num1 < num2)
//     {
//         Console.Write(num1 + " ");
//         ShowNumbers(num1 + 1, num2);
//     }
//     else if(num1 > num2) 
//     {
//         Console.Write(num2 + " ");
//         ShowNumbers(num1, num2 + 1);
//     }
//     else Console.Write(num1);
// }

// ShowNumbers(7, 3);

//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// int Stepen(int num1, int num2)
// {
//     if(num2 > 0)
//     {
//         return Stepen(num1, num2 - 1) * num1;
//     }
//     else return 1;
// }

// Console.WriteLine(Stepen(3,3));
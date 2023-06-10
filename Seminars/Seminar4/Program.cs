// Tasks1. напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 36478439 -> 8
// 562 -> 

// int DigitCount(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         count++;
//         num/=10;
//     }
//     return count;
// }

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Number of digits in {num} -> {DigitCount(num)}");


// Task2. Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input msximal value of element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray); 


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int Factorial(int num)
// {
//     int result = 1;
//     for(int i = 1; i <= num; i++) 
//     {
//         result = result*i;
//     }
//     return result;
// }

// Console.WriteLine("Input num ");
// int num = Convert.ToInt32(Console.ReadLine());    
// Console.WriteLine(Factorial(num));


//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int sum(int num)
// {
//     int n = 0;
//     for(int i = 1; i <= num; i++) 
//     {
//         n = n + i;
//     }
//     return n;
// }

// Console.WriteLine("Input num ");
// int num = Convert.ToInt32(Console.ReadLine());    
// Console.WriteLine(sum(num));

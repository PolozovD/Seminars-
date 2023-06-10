//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

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

// void posNegSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= 0)  sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     Console.WriteLine($"Sum of positive elements -> {sumPos}, sum of negative elements -> {sumNeg}");
// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input msximal value of element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray); 
// posNegSum(myArray);


//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

// int[] invertArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input msximal value of element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray); 
// myArray = invertArray(myArray);

// PrintArray(myArray);


//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"Input element massive {i} ");
//         newArray[i] = Convert.ToInt32(Console.ReadLine());
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

// void checkNumber(int number, int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == number) Console.WriteLine($"This number corresponds to the number of the array {i}");
//         else Console.WriteLine($"This number does not match the number of the array {i}");
//     }
// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);

// PrintArray(myArray); 

// Console.WriteLine("Input array number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// checkNumber(number, myArray);


//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*


// int[] CreateRandomArray(int size)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(0, 123);
//     }
//     return newArray;
// }

// void searchNumbers (int minValue, int maxValue, int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= minValue && array[i] <= maxValue) count++;
//     }
//     Console.WriteLine(count);
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
// Console.WriteLine("Input maximal value of element ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);

// PrintArray(myArray); 
// searchNumbers(minValue, maxValue, myArray);
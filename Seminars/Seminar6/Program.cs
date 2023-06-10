//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool checkTriangle(int a, int b, int c)
// {
//     if(a + b > c && a + c > b && b + c > a) return true;
//     return false;
// }

// Console.WriteLine("Input A length: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input B length: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input C length: ");
// int c = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(checkTriangle(a, b, c));


//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,1,2, 3, 5, 8, 13, ... ]

// int[] fibonachi(int size, int firstNum, int secondNum)
// {
//     int[] array = new int[size];
//     array[0] = firstNum;
//     array[1] = secondNum;
//     for(int i = 2; i < size; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input irst number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// PrintArray(fibonachi(size, firstNum, secondNum));


//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] ArrayRotate(int[] ArrayRotate, int size)
// {
//     int box = 0;
//     for(int i = 0; i < size - 1 - i; i++)
//     {
//         box = ArrayRotate[i];
//         ArrayRotate[i] = ArrayRotate[size - 1 - i];
//         ArrayRotate[size - 1 - i] = box;
//     }
//     return ArrayRotate;
// }

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
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

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, minValue, maxValue);

// PrintArray(array);
// array = ArrayRotate(array, size);
// PrintArray(array);


int[] ReversArray(int[] array)
{
   int tmp;
   for (int i = 0; i < array.Length / 2; i++)
   {
      tmp = array[i];
      array[i] = array[array.Length - 1 - i];
      array[array.Length - 1 - i] = tmp;
   }
   return array;
}

int[] RandomArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = new Random().Next(0, 10);
   }
   return array;

}

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i] + " ");
   }
   Console.WriteLine();
}

Console.WriteLine("Input Size Array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

array = RandomArray(array);
PrintArray(array);
ReversArray(array);
PrintArray(array);
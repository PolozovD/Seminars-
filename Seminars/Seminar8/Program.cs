//Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//В итоге получается вот такой массив:

//1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7

// int[,] RowsToColumns (int[,] array)
// {
//     if(array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("Invalid input");
//         return array;
//     }
//     else
//     {
//         for(int i = 0; i < array.GetLength(0) - 1; i++)
//         {
//             for(int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//     }
//     return array;
// }

// int[,] Create2DrandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for ( int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value of array element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of arrayelement ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DrandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// myArray = RowsToColumns(myArray);

// Print2DArray(myArray);



//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// int[,] RowsToColumns (int[,] array)
// {
//     int minRows = 0;
//     int minColumns = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = i + 1; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < array[minRows, minColumns])
//             {
//                 minRows = i;
//                 minColumns = j;
//             }
//         }
//     }

//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, minColumns] = 0;
//     }

//     for(int j = 0; j < array.GetLength(1); j++)
//     {
//         array[minRows, j] = 0;           
//     }
//     return array;
// }
   

// int[,] Create2DrandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for ( int j = 0; j < columns; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for ( int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min value of array element ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of arrayelement ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DrandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// myArray = RowsToColumns(myArray);

// Print2DArray(myArray);



//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. (Любую строку с любой)

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

int[,] RowsToColumns (int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[0, j];
            array[0, j] = array[array.GetLength(0) -1, j];
            array[array.GetLength(0) -1, j] = temp;
        }
    }
    return array;
}

int[,] Create2DrandomArray (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void Print2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array element ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of arrayelement ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DrandomArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
myArray = RowsToColumns(myArray);

Print2DArray(myArray);
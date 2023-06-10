// //Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart (int x, int y)
// {
//     if(x > 0 && y > 0) return 1;
//     if(x < 0 && y > 0) return 2;
//     if(x < 0 && y < 0) return 3;
//     if(x > 0 && y < 0) return 4;

//     return 0;
// }

// Console.WriteLine("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int result = FindQuart(x,y);

// Console.WriteLine($"Point with {x} && {y} coordinates located aat {result} quart");

// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

double FindDistance(double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
}

Console.WriteLine("Input coordinate x to A: ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate y to A: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate x to B: ");
double xb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input coordinate y to B: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between point A with coordinates ({xa},{ya} and point B with coordinates ({xb}, {yb}) -> {FindDistance(xa, ya, xb, yb)}");

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void quart(int number)
// {
//     if (number == 1) Console.WriteLine("x > 0 y > 0");
//     if (number == 2) Console.WriteLine("x < 0 y > 0");
//     if (number == 3) Console.WriteLine("x < 0 y < 0");
//     if (number == 4) Console.WriteLine("x > 0 y < 0");
// }

// Console.WriteLine("Input number of quart: ");
// int number = Convert.ToInt32(Console.ReadLine());
// quart(number);

//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N.

// Console.WriteLine("Input number: ");
// int countNumber = Convert.ToInt32(Console.ReadLine());

// void Quad(int number)
// {
//     int i = 1;
//     while (i <= number)
//     {
//         Console.WriteLine($"{i} -> {i*i}");
//         i++;
//     }
// }

// Quad(countNumber);
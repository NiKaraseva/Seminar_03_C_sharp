/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.*/

Console.WriteLine ("Введите координату точки X1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите координату точки Y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите координату точки X2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите координату точки Y2: ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2)); // Math.Sqrt – извлечение корня, Math.Pow – возведение в квадрат
Console.WriteLine($"Расстояние между точками = {result:f2}"); 

// Console.WriteLine($"Расстояние между точками = {Math.Round{result,2}}");

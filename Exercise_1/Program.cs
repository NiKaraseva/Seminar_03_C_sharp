/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
в которой находится эта точка.*/

Console.WriteLine ("Введите координату точки X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите координату точки Y: ");
int y = int.Parse(Console.ReadLine());

if ((x != 0) && (y != 0 ))
{
    if ((x > 0) && (y > 0))
    {
        Console.WriteLine ("Точка расположена в I четверти");
    }
    else if ((x < 0) && (y > 0))
    {
        Console.WriteLine ("Точка расположена во II четверти");
    }
    else if ((x < 0) && (y < 0))
    {
        Console.WriteLine ("Точка расположена в III четверти");
    }
    else if ((x > 0) && (y < 0))
    {
        Console.WriteLine ("Точка расположена в IV четверти");
    }
}
else 
    {
        Console.WriteLine ("Точка находится в начале координат");
    }
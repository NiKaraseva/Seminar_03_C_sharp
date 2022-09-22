/*Программа, которая по заданному номеру четверти показывает диапазон значений
X и Y*/

Console.WriteLine("Введи номер четверти");
int number = int.Parse(Console.ReadLine());

switch(number)
{
    case 1:
    {
        Console.WriteLine("Диапазон возможных значений четверти x > 0 и y > 0" );
        break;
    }
    
    case 2:
    {
        Console.WriteLine("Диапазон возможных значений четверти x < 0 и y > 0" );
        break;
    }
    case 3:
    {
        Console.WriteLine("Диапазон возможных значений четверти x < 0 и y < 0" );
        break;
    }
    case 4:
    {
        Console.WriteLine("Диапазон возможных значений четверти x > 0 и y < 0" );
        break;
    }
    default:
    {
        Console.WriteLine("Такой четверти нет, смотри внимательнее!" );
        break;
    }
}

/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  */

double [] line1 = EnteringPointCoordinates (2, 1);
double [] line2 = EnteringPointCoordinates (2, 2);
double[] intersection = FindIntersectionPointsOfTheLines (line1, line2);
Console.Write($"Точка пересечения двух прямых имеет координаыт: ({intersection[0]} : {intersection[1]})");

void Messager(string message)
{
    Console.WriteLine(message);
}

double[] EnteringPointCoordinates (int len, int name_direct)
{
    double[] array = new double [len];
    for(int i=0; i<len; i++)
    {
        Messager($"Задайте координаты {i+1} точки для {name_direct}-ой прямой: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double[] FindIntersectionPointsOfTheLines (double[] straight1, double[] straight2)
{
    double[] array = new double[2];
    double k1 = straight1[0];
    double b1 = straight1[1];

    double k2 = straight2[0];
    double b2 = straight2[1];

    array[0] = (-b1 + b2) / (k1 + (-k2));
    array[1] = (k1 * array[0] + b1);

    return array;
}
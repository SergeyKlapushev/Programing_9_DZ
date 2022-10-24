/* Задача 3: * Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2 */


//  ЭТО ЗАДАНИЕ НЕ ДОДЕЛАЛ!!!!!!!!!!!
int[,] matrix = CreatMatrix(2, 3);
ShowMatrix(matrix);
FindOfMaxInLines(matrix);

int[,] CreatMatrix(int lines, int сolumns)
{
    int[,] matrix = new int[lines, сolumns];
    Random rnd = new Random();
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] mtx)
{
    for(int i =0; i< mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            Console.Write($"{mtx[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

void FindOfMaxInLines(int[,] mtx)
{

    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(i); j++)
        {
            
        }  
    }

}
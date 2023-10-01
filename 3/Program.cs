// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int m = 4;
int n = 4;
int a = 4;


int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
WriteArray(firstMartrix);
System.Console.WriteLine(' ');
int[,] secomdMartrix = new int[n, a];
CreateArray(secomdMartrix);
WriteArray(secomdMartrix);
System.Console.WriteLine(' ');
int[,] resultMatrix = new int[m, a];
System.Console.WriteLine(' ');
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

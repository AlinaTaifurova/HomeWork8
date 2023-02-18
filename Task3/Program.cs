/*Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.*/




Console.WriteLine("Введите размер матрицы:");
int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
int[,] firstMatrix = new int[n, m];
int[,] secondMatrix = new int[n, m];
int[,] resultMatrix = new int[n, m];

FillMatrixRandom(firstMatrix);
PrintMatrix(firstMatrix);

Console.WriteLine();

FillMatrixRandom(secondMatrix);
PrintMatrix(secondMatrix);

Console.WriteLine();

if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintMatrix(resultMatrix);
int Parse(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

/*Напишите программу, которая заполнит спирально квадратный массив.*/

Console.WriteLine("Задайте размер квадратного массива: ");
int length = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[length, length];
FillMatrixSpiral(matrix, length);
PrintMatrix(matrix);

void FillMatrixSpiral(int[,] matrix, int b)
{
    int i = 0, j = 0;
    int val = 1;
    for (int a = 0; a < b * b; a++)
    {
        int c = 0;
        do { matrix[i, j++] = val++; } while (++c < b - 1);
        for (c = 0; c < b - 1; c++) matrix[i++, j] = val++;
        for (c = 0; c < b - 1; c++) matrix[i, j--] = val++;
        for (c = 0; c < b - 1; c++) matrix[i--, j] = val++;
        ++i; ++j;
        b = b < 2 ? 0 : b - 2; 
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write("\t");
            }
            else Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
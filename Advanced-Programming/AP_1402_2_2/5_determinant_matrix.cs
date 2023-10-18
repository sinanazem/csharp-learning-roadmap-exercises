using System;

class MatrixDeterminantCalculator
{
    static void Main()
    {
        
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        
        int determinant = CalculateDeterminant(matrix);
        Console.WriteLine($"Determinant of the matrix: {determinant}");
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        int det = 0;

        for (int i = 0; i < 3; i++)
        {
            det += matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]);
        }

        return det;
    }
}

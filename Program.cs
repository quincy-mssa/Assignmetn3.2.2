namespace Assignmetn3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the size of the matrix (less than 5): ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];

            Console.WriteLine("Input elements in the first matrix:");
            MatrixInput(matrix1, size);

            Console.WriteLine("Input elements in the second matrix:");
            MatrixInput(matrix2, size);

            int[,] resultMatrix = AddMatrices(matrix1, matrix2, size);

            Console.WriteLine("The first matrix is:");
            PrintMatrix(matrix1, size);

            Console.WriteLine("The second matrix is:");
            PrintMatrix(matrix2, size);

            Console.WriteLine("The addition of two matrix is:");
            PrintMatrix(resultMatrix, size);
        }
        static void MatrixInput(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2, int size)
        {
            int[,] matrixResult = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixResult[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return matrixResult;
        }

        static void PrintMatrix(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
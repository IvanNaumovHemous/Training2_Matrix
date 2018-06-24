using System;

namespace MatrixTraining2
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            int[,] matrix = GetMatrix(size);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] GetMatrix(int size)
        {
            var matrix = new int[size, size];

            for (int i = 0, temp = 1; i < matrix.GetLength(0); i++, temp = i + 1)
            {
                for (int j = 0; j < matrix.GetLength(1); j++, temp+= 4)
                {
                    matrix[i, j] = temp;
                }
            }

            return matrix;
        }
    }
}

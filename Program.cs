using System.Drawing;

namespace Assignment5._4._2
{
    internal class Program
    {
        public static void AddRightDiagonals(int[,] matrix)
        {

            int n = matrix.GetLength(0); // Number of rows

            int rightDiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                rightDiagonalSum += matrix[i, i]; // Elements where row index equals column index
            }

            Console.WriteLine($"\nAddition of the right Diagonal elements is : {rightDiagonalSum}\n");
        }

        public static int[,] GetSquareMatrix()
        {
            Console.Write("Input the size of the square matrix : ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer for the size: ");
            }

            int[,] matrix = new int[size, size];

            Console.WriteLine("Input elements in the matrix : ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"element - [{i},{j}] : ");
                    int value;
                    while (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.Write("Invalid input. Please enter an integer: ");
                    }
                    matrix[i, j] = value;
                }
            }
            PrintMatrix(matrix, size);
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix, int size)
        {
            Console.WriteLine("\nThe matrix is : ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            AddRightDiagonals(GetSquareMatrix());
        }
    }
}

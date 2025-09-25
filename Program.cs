using System.Drawing;

namespace Assignment5._4._2
{
    internal class Program
    {
        public static void AddLeftDiagonals(int[,] matrix)
        {

            int n = matrix.GetLength(0);
            
            int leftDiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftDiagonalSum += matrix[i, i];
            }

            Console.WriteLine($"\nAddition of the right Diagonal elements is : {leftDiagonalSum}\n");
        }

        public static void AddRightDiagonals(int[,] matrix)
        {

            int n = matrix.GetLength(0);
            
            int rightDiagonalSum = 0;
            for (int i = 0; i < n; i++)
            {
                for(int j = n - 1; j >= 0; j--)
                {
                    if(i + j == n - 1)
                    {
                        rightDiagonalSum += matrix[i, j];
                        break;
                    }
                }
            }

            Console.WriteLine($"\nAddition of the left Diagonal elements is : {rightDiagonalSum}\n");
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
            int[,] matrix = GetSquareMatrix();
            AddRightDiagonals(matrix);
            AddLeftDiagonals(matrix);
        }
    }
}

# Assignment5.4.2

- Write a C# Sharp program to find the sum of the right diagonals of a matrix.
- Test Data :
- Expected Input :
	- Input the size of the square matrix : 2
	- Input elements in the matrix :
		- element - [0],[0] : 1
		- element - [0],[1] : 2
		- element - [1],[0] : 3
		- element - [1],[1] : 4
- Expected Output :
	- The matrix is :
	- 1 2
	- 3 4
	- Addition of the right Diagonal elements is : 5

Hints:
- Create a 2D array to represent the matrix.
- Prompt the user to input the size of the matrix and its elements.
- Display the matrix in a formatted way.
- Get row size from the matrix.
- Initialize a variable to hold the sum of the right diagonal elements.
- Add clements where row index equals column index to get the sum of the right diagonal elements.
- Use nested loops to iterate through the matrix elements from the last column of the first row to the first column of the last row.
- The left diagonal elements of a square matrix are those where the row index and column index sum to the size of the matrix minus one (i + j = n - 1).
- Accumulate the sum of these elements in a variable.

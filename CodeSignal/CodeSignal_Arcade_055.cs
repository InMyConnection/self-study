/*Given a rectangular matrix containing only digits, calculate the number of different 2 × 2 squares in it.

Example

For

matrix = [[1, 2, 1],
          [2, 2, 2],
          [2, 2, 2],
          [1, 2, 3],
          [2, 2, 1]]
the output should be
differentSquares(matrix) = 6.

Here are all 6 different 2 × 2 squares:

1 2
2 2
2 1
2 2
2 2
2 2
2 2
1 2
2 2
2 3
2 3
2 1 */

int differentSquares(int[][] matrix) {
List<int> squares = new List<int>();
for (int i = 0; i < matrix.Length - 1; i++)
for (int j = 0; j < matrix[0].Length - 1; j++)
squares.Add(1000 * matrix[i][j] + matrix[i][j + 1] + 100 * matrix[i + 1][j] + 10 * matrix[i + 1][j + 1]);
return squares.Distinct().Count();
}

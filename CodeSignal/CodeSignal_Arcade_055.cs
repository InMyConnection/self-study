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
int length = matrix.Length;
int width = matrix[0].Length;
List<char[]> squares = new List<char[]>();
for (int i = 0; i < length - 1; i++)
for (int j = 0; j < width - 1; j++){
    char[] square = new char[4];
    square[0] = (char)matrix[i][j];
    square[1] = (char)matrix[i][j + 1];
    square[2] = (char)matrix[i + 1][j];
    square[3] = (char)matrix[i + 1][j + 1];
    squares.Add(square);
}
return squares.Select(m => String.Concat(m)).Distinct().Count();
}

/*In the popular Minesweeper game you have a board with some mines and those cells that don't contain a mine have a number in it that indicates the total number of mines in the neighboring cells. Starting off with some arrangement of mines we want to create a Minesweeper game setup.

Example

For

matrix = [[true, false, false],
          [false, true, false],
          [false, false, false]]
the output should be

minesweeper(matrix) = [[1, 2, 1],
                       [2, 1, 1],
                       [1, 1, 1]]*/


int[][] minesweeper(bool[][] matrix) {
int length = matrix.Length;
int width = matrix[0].Length;
int count = 0;
int[][] output = new int[length][];
for (int i = 0; i < length; i++){
    output[i] = new int[width];
    for (int j = 0; j < width; j++){
        for (int k = - 1; k < 2; k++)
        for (int l = - 1; l < 2; l++){
            if (i + k >= 0 && i + k < length && j + l >= 0 && j + l < width)
            if (matrix[i + k][j + l])
            count++;
        }
        if (matrix[i][j])
        count--;
        output[i][j] = count;
        count = 0;
    }
}
return output;
}

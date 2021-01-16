/*Given two cells on the standard chess board, determine whether they have the same color or not.

Example

For cell1 = "A1" and cell2 = "C3", the output should be
chessBoardCellColor(cell1, cell2) = true.

For cell1 = "A1" and cell2 = "H3", the output should be
chessBoardCellColor(cell1, cell2) = false.*/

bool chessBoardCellColor(string cell1, string cell2) {
Dictionary<string, bool> board = new Dictionary<string, bool>();
bool color = false;
for (char c = 'A'; c <= 'H'; c++){
    for (int i = 1; i <= 8; i++){
    board.Add(c.ToString() + i.ToString(), color);
    color = !color;
}
color = !color;
}
return board[cell1] == board[cell2];
}

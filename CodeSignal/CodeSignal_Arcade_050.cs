/*Given a position of a knight on the standard chessboard, find the number of different moves the knight can perform.

The knight can move to a square that is two squares horizontally and one square vertically, or two squares vertically and one square horizontally away from it. The complete move therefore looks like the letter L. Check out the image below to see all valid moves for a knight piece that is placed on one of the central squares.

Example

For cell = "a1", the output should be chessKnight(cell) = 2.

For cell = "c2", the output should be chessKnight(cell) = 6.*/

int chessKnight(string cell) {
char ch = cell[0];
int num = Int32.Parse(cell[1].ToString());
int result = 0;
if (ch - 1 >= 'a' && num - 2 >= 1) result++;
if (ch + 1 <= 'h' && num - 2 >= 1) result++;
if (ch - 2 >= 'a' && num - 1 >= 1) result++;
if (ch + 2 <= 'h' && num - 1 >= 1) result++;
if (ch - 2 >= 'a' && num + 1 <= 8) result++;
if (ch + 2 <= 'h' && num + 1 <= 8) result++;
if (ch - 1 >= 'a' && num + 2 <= 8) result++;
if (ch + 1 <= 'h' && num + 2 <= 8) result++;
return result;
}

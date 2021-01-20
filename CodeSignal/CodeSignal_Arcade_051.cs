/*Given some integer, find the maximal number you can obtain by deleting exactly one digit of the given number.

Example

For n = 152, the output should be
deleteDigit(n) = 52;
For n = 1001, the output should be
deleteDigit(n) = 101.*/

int deleteDigit(int n) {
return Int32.Parse(n.ToString().Select((c, i) => n.ToString().Remove(i, 1)).Max());
}

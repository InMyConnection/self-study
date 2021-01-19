/*Given some integer, find the maximal number you can obtain by deleting exactly one digit of the given number.

Example

For n = 152, the output should be
deleteDigit(n) = 52;
For n = 1001, the output should be
deleteDigit(n) = 101.*/

int deleteDigit(int n) {
string number = n.ToString();
int length = number.Length;
int[] numbers = new int[length];
for (int i = 0; i < length; i++)
    numbers[i] = Int32.Parse(number.Remove(i, 1));
return numbers.Max();
}

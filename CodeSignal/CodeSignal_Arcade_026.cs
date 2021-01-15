/*Check if all digits of the given integer are even.

Example

For n = 248622, the output should be
evenDigitsOnly(n) = true;
For n = 642386, the output should be
evenDigitsOnly(n) = false.*/

bool evenDigitsOnly(int n) {
string integer = n.ToString();
foreach (char c in integer)
if (Int32.Parse(c.ToString()) % 2 != 0)
return false;
return true;
}

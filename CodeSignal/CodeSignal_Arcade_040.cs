/*Given a string, output its longest prefix which contains only digits.

Example

For inputString = "123aa1", the output should be
longestDigitsPrefix(inputString) = "123".*/

string longestDigitsPrefix(string inputString) {
char[] input = inputString.ToCharArray();
IEnumerable<char> query = input.TakeWhile(c => Int32.TryParse(c.ToString(), out int number));
string output = String.Join(String.Empty, query);
return output;
}

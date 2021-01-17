/*Given a string, find the number of different characters in it.

Example

For s = "cabca", the output should be
differentSymbolsNaive(s) = 3.

There are 3 different characters a, b and c.*/

int differentSymbolsNaive(string s) {
List<char> differentChars = new List<char>();
foreach (char c in s)
    if (!differentChars.Contains(c))
    differentChars.Add(c);
return differentChars.Count;
}

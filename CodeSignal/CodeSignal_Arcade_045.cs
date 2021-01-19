/*Given a string, find the shortest possible string which can be achieved by adding characters to the end of initial string to make it a palindrome.

Example

For st = "abcdc", the output should be
buildPalindrome(st) = "abcdcba".*/

string buildPalindrome(string st) {
if (st.Equals(String.Concat(st.Reverse())))
return st;
string palindrome = String.Empty;
List<string> output = new List<string>();
for (int i = 0; i < st.Length; i++)
{
    string variant = String.Concat(st, String.Concat(st.Reverse()).Remove(0, i));
    output.Add(variant);
}
output.Reverse();
foreach (string variant in output)
    if (variant.Equals(String.Concat(variant.Reverse())))
    {
        palindrome = variant;
        break;
    }   
return palindrome;
}

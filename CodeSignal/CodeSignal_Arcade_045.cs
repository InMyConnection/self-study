/*Given a string, find the shortest possible string which can be achieved by adding characters to the end of initial string to make it a palindrome.

Example

For st = "abcdc", the output should be
buildPalindrome(st) = "abcdcba".*/

string buildPalindrome(string st) {
int length = st.Length;
int count = 0;
while (!st.Equals(String.Concat(st.Reverse())))
st = st.Insert(length, st[count++].ToString());
return st;
}

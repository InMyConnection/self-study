/*Given two strings, find the number of common characters between them.

Example

For s1 = "aabcc" and s2 = "adcaa", the output should be
commonCharacterCount(s1, s2) = 3.

Strings have 3 common characters - 2 "a"s and 1 "c".*/

int commonCharacterCount(string s1, string s2) {
int result = 0;
int res1;
int res2;
List<char> commonChars = new List<char>();
foreach (char c1 in s1)
foreach (char c2 in s2)
if (c1 == c2)
if (!commonChars.Contains(c1))
commonChars.Add(c1);
foreach (char c in commonChars){
res1 = 0;
res2 = 0;
foreach (char c1 in s1)
if (c == c1)
res1++;
foreach (char c2 in s2)
if (c == c2)
res2++;
if (res1 < res2)
result += res1;
else result += res2;
}
return result;
}

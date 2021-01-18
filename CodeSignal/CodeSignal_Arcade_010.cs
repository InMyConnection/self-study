/*Given two strings, find the number of common characters between them.

Example

For s1 = "aabcc" and s2 = "adcaa", the output should be
commonCharacterCount(s1, s2) = 3.

Strings have 3 common characters - 2 "a"s and 1 "c".*/

int commonCharacterCount(string s1, string s2) {
return s1.Distinct().Sum(c => Math.Min(s1.Count(s => s == c), s2.Count(s => s == c)));
}

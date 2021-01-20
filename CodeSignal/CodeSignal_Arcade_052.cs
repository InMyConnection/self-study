/*Define a word as a sequence of consecutive English letters. Find the longest word from the given string.

Example

For text = "Ready, steady, go!", the output should be
longestWord(text) = "steady".*/

string longestWord(string text) {
Regex regex = new Regex(@"[A-Za-z]*");
MatchCollection matches = regex.Matches(text);
return matches.Single(m => m.Length == matches.Max(s => s.Length)).ToString();
}

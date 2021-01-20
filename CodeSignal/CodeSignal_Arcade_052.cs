/*Define a word as a sequence of consecutive English letters. Find the longest word from the given string.

Example

For text = "Ready, steady, go!", the output should be
longestWord(text) = "steady".*/

string longestWord(string text) {
return Regex.Split(text, @"[^A-Za-z]+").OrderByDescending(s => s.Length).First();
}

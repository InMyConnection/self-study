/*Given an array of strings, return another array containing all of its longest strings.

Example

For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
allLongestStrings(inputArray) = ["aba", "vcd", "aba"].*/

string[] allLongestStrings(string[] inputArray) {
return inputArray.Where(s => s.Length == inputArray.Max(str => str.Length)).ToArray();
}

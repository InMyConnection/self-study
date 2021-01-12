/*Given an array of strings, return another array containing all of its longest strings.

Example

For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
allLongestStrings(inputArray) = ["aba", "vcd", "aba"].*/

string[] allLongestStrings(string[] inputArray) {
List<int> length = new List<int>();
foreach (string s in inputArray)
length.Add(s.Length);
List<string> result = new List<string>();
foreach (string s in inputArray){
    if (s.Length == length.Max())
    result.Add(s);
}
string[] outputArray = result.ToArray();
return outputArray;
}

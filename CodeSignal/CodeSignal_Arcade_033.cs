/*Given an array of equal-length strings, you'd like to know if it's possible to rearrange the order of the elements in such a way that each consecutive pair of strings differ by exactly one character. Return true if it's possible, and false if not.

Note: You're only rearranging the order of the strings, not the order of the letters within the strings!

Example

For inputArray = ["aba", "bbb", "bab"], the output should be
stringsRearrangement(inputArray) = false.

There are 6 possible arrangements for these strings:

["aba", "bbb", "bab"]
["aba", "bab", "bbb"]
["bbb", "aba", "bab"]
["bbb", "bab", "aba"]
["bab", "bbb", "aba"]
["bab", "aba", "bbb"]
None of these satisfy the condition of consecutive strings differing by 1 character, so the answer is false.

For inputArray = ["ab", "bb", "aa"], the output should be
stringsRearrangement(inputArray) = true.

It's possible to arrange these strings in a way that each consecutive pair of strings differ by 1 character (eg: "aa", "ab", "bb" or "bb", "ab", "aa"), so return true.*/

bool stringsRearrangement(string[] inputArray) {
int countOfPairStrings = 0;
int comparison = 0;
int countOfSameStrings = 0;
foreach (string s1 in inputArray)
foreach (string s2 in inputArray){
    if (String.Equals(s1, s2))
    countOfSameStrings++;
    for (int j = 0; j < s1.Length; j++){
    if (s1[j] != s2[j])
    comparison++;
}
if (comparison == 1)
countOfPairStrings++;
comparison = 0;
}
countOfSameStrings -= inputArray.Length;
return countOfPairStrings - countOfSameStrings > inputArray.Length;
}

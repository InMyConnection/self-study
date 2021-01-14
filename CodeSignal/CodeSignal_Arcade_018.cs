/* Given a string, find out if its characters can be rearranged to form a palindrome.

Example

For inputString = "aabb", the output should be
palindromeRearranging(inputString) = true.

We can rearrange "aabb" to make "abba", which is a palindrome.*/

bool palindromeRearranging(string inputString) {
Dictionary<char, int> charsQuantity = new Dictionary<char, int>();
foreach (char c in inputString){
    if (!charsQuantity.ContainsKey(c))
        charsQuantity.Add(c, 1);
    else charsQuantity[c] += 1; 
}
int countOfUnpairedChars = 0;
foreach (KeyValuePair<char, int> KeyValue in charsQuantity){
    if (KeyValue.Value % 2 != 0)
    countOfUnpairedChars += 1;
}
return countOfUnpairedChars < 2;
}

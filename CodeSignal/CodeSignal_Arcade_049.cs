/*Given a string, return its encoding defined as follows:

First, the string is divided into the least possible number of disjoint substrings consisting of identical characters
for example, "aabbbc" is divided into ["aa", "bbb", "c"]
Next, each substring with length greater than one is replaced with a concatenation of its length and the repeating character
for example, substring "bbb" is replaced by "3b"
Finally, all the new strings are concatenated together in the same order and a new string is returned.
Example

For s = "aabbbc", the output should be
lineEncoding(s) = "2a3bc".*/

string lineEncoding(string s) {
string output = String.Empty;
int count = 1;
int length = s.Length;
for (int i = 0; i < length - 1; i++){
    if (s[i] == s[i + 1]){
        count++;
    if (i + 1 == length - 1)
    output += count + s[i].ToString();
    }
    else if (count != 1){
        output += count + s[i].ToString();
        count = 1;
    }
    else{
        output += s[i].ToString();
        count = 1;
}
}
if (s[length - 1] != s[length - 2])
output += s[length - 1];
return output;
}

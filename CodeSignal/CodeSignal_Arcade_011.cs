/*Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the sum of the first half of the digits is equal to the sum of the second half.

Given a ticket number n, determine if it's lucky or not.

Example

For n = 1230, the output should be
isLucky(n) = true;
For n = 239017, the output should be
isLucky(n) = false.*/

bool isLucky(int n) {
string s = n.ToString();
int res1 = 0;
int res2 = 0;
for (int i = 0; i < s.Length / 2; i++){
    res1 += (int)s[i];
    res2 += (int)s[s.Length - 1 - i];
}
return res1 == res2;
}

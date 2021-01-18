/*A string is said to be beautiful if each letter in the string appears at most as many times as the previous letter in the alphabet within the string; ie: b occurs no more times than a; c occurs no more times than b; etc. Note that letter a has no previous letter.

Given a string, check whether it is beautiful.

Example

For inputString = "bbbaacdafe", the output should be isBeautifulString(inputString) = true.

This string contains 3 as, 3 bs, 1 c, 1 d, 1 e, and 1 f (and 0 of every other letter), so since there aren't any letters that appear more frequently than the previous letter, this string qualifies as beautiful.

For inputString = "aabbb", the output should be isBeautifulString(inputString) = false.

Since there are more bs than as, this string is not beautiful.

For inputString = "bbc", the output should be isBeautifulString(inputString) = false.

Although there are more bs than cs, this string is not beautiful because there are no as, so therefore there are more bs than as.*/

bool isBeautifulString(string inputString) {
IEnumerable<char> sortedString = inputString.OrderBy(c => c);
List<char> differentChars = sortedString.Distinct().ToList();
List<int> countOfDifferentChars = new List<int>();
foreach(char letter in differentChars)
    countOfDifferentChars.Add(sortedString.Count(c => c == letter));
bool moreThanPrevios = countOfDifferentChars.SequenceEqual(countOfDifferentChars.OrderByDescending(i => i));
bool alphabetOrder = true;
for(int i = 0; i < differentChars.Count() - 1 && (char)(differentChars[i] + 1) != differentChars[i + 1]; i++)
    alphabetOrder = false;
return differentChars[0] == 'a' && alphabetOrder && moreThanPrevios;
}

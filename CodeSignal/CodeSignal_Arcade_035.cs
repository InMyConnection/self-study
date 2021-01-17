/*Find the leftmost digit that occurs in a given string.

Example

For inputString = "var_1__Int", the output should be
firstDigit(inputString) = '1';
For inputString = "q2q-q", the output should be
firstDigit(inputString) = '2';
For inputString = "0ss", the output should be
firstDigit(inputString) = '0'.*/

char firstDigit(string inputString) {
char output = ' ';
foreach (char c in inputString){
    if (Int32.TryParse(c.ToString(), out int result)){
        output = c;
        break; 
    }
}
return output;
}

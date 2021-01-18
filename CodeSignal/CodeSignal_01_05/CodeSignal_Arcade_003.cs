/*Given the string, check if it is a palindrome.*/

bool checkPalindrome(string inputString) {
return inputString.SequenceEqual(inputString.Reverse());
}

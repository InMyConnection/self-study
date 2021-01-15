/*Given a string, your task is to replace each of its characters by the next one in the English alphabet; i.e. replace a with b, replace b with c, etc (z would be replaced by a).

Example

For inputString = "crazy", the output should be alphabeticShift(inputString) = "dsbaz".*/

string alphabeticShift(string inputString) {
List<char> word = new List<char>();
foreach (char c in inputString){
    if (c == 'z')
    word.Add('a');
    else
    word.Add((char)((int)c + 1));
}
inputString = String.Join(String.Empty, word);
return inputString;
}

/*Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem.

Example

For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3, the output should be
arrayReplace(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].*/

int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem) {
int[] output = new int[inputArray.Length];
for (int i = 0; i < inputArray.Length; i++){
    if (inputArray[i] == elemToReplace)
    output[i] = substitutionElem;
    else output[i] = inputArray[i];
}
return output;
}

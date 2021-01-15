/*Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.

Example

For inputArray = [2, 4, 1, 0], the output should be
arrayMaximalAdjacentDifference(inputArray) = 3.*/

int arrayMaximalAdjacentDifference(int[] inputArray) {
List<int> difference = new List<int>();
for (int i = 0; i < inputArray.Length - 1; i++){
difference.Add(inputArray[i + 1] - inputArray[i]);
difference.Add(inputArray[i] - inputArray[i + 1]);   
}
return difference.Max();
}

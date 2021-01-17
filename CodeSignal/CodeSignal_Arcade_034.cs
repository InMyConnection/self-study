/*Given array of integers, remove each kth element from it.

Example

For inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] and k = 3, the output should be
extractEachKth(inputArray, k) = [1, 2, 4, 5, 7, 8, 10].*/


int[] extractEachKth(int[] inputArray, int k) {
List<int> outputArray = new List<int>();
for (int i = 0; i < inputArray.Length; i++){
    if ((i + 1) % k != 0)
    outputArray.Add(inputArray[i]);
}
return outputArray.ToArray();
}

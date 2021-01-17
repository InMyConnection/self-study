/*Given array of integers, find the maximal possible sum of some of its k consecutive elements.

Example

For inputArray = [2, 3, 5, 1, 6] and k = 2, the output should be
arrayMaxConsecutiveSum(inputArray, k) = 8.
All possible sums of 2 consecutive elements are:

2 + 3 = 5;
3 + 5 = 8;
5 + 1 = 6;
1 + 6 = 7.
Thus, the answer is 8.*/


int arrayMaxConsecutiveSum(int[] inputArray, int k) {;
List<int> input = new List<int>(inputArray);
List<int> sumList = new List<int>();
int[] kArray = new int[k];
input.CopyTo(0, kArray, 0, k);
int sum = kArray.Sum();
sumList.Add(sum);
for( int i = 0; i < inputArray.Length - k; i++){
    sum += inputArray[i + k] - inputArray[i];
    sumList.Add(sum);
}
return sumList.Max();
}

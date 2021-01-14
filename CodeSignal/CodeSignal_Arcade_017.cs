/*You are given an array of integers. On each move you are allowed to increase exactly one of its element by one. Find the minimal number of moves required to obtain a strictly increasing sequence from the input.

Example

For inputArray = [1, 1, 1], the output should be
arrayChange(inputArray) = 3.*/

int arrayChange(int[] inputArray) {
int result = 0;
bool isElementForIncrease = false;
do {
    isElementForIncrease = false;
    for (int i = 0; i < inputArray.Length - 1; i++){
    if(inputArray[i] >= inputArray[i + 1])
    {inputArray[i + 1] += 1;
    result += 1;
    isElementForIncrease = true;
    }
    }
}
while(isElementForIncrease);
return result;
}

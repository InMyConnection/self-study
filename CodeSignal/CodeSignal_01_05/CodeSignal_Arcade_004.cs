/*Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.*/

int length = inputArray.Length;
for(int i = 0; i < length - 1; i++)
{
    inputArray[i] = inputArray[i] * inputArray[i+1];
}
inputArray[length - 1] = inputArray[0];
return inputArray.Max();
}

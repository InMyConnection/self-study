/*Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.

Given two arrays a and b, check whether they are similar.

Example

For a = [1, 2, 3] and b = [1, 2, 3], the output should be
areSimilar(a, b) = true.

The arrays are equal, no need to swap any elements.

For a = [1, 2, 3] and b = [2, 1, 3], the output should be
areSimilar(a, b) = true.

We can obtain b from a by swapping 2 and 1 in b.

For a = [1, 2, 2] and b = [2, 1, 1], the output should be
areSimilar(a, b) = false.

Any swap of any two elements either in a or in b won't make a and b equal.*/

bool areSimilar(int[] a, int[] b) {
if (Enumerable.SequenceEqual(a, b))
return true;
List<int> A = new List<int>();
A.AddRange(a);
A.Sort();
List<int> B = new List<int>();
B.AddRange(b);
B.Sort();
if (!A.SequenceEqual(B))
return false;
int temp = 0;
for (int i = 0; i < a.Length; i++){
    if (a[i] != b[i])
    temp++;
}
return temp < 3;
}

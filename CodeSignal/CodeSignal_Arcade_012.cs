/*Some people are standing in a row in a park. There are trees between them which cannot be moved. Your task is to rearrange the people by their heights in a non-descending order without moving the trees. People can be very tall!

Example

For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
sortByHeight(a) = [-1, 150, 160, 170, -1, -1, 180, 190].*/

int[] sortByHeight(int[] a) {
List<int> result = new List<int>(a.Length);
for (int i = 0; i < a.Length; i++){
if (a[i] > 0)
result.Add(a[i]);
}
result.Sort();
for (int i = 0; i < a.Length; i++){
if (a[i] < 0)
result.Insert(i, a[i]);
}
return result.ToArray();
}

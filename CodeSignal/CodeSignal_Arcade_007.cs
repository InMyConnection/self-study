/*Given a sequence of integers as an array, determine whether it is possible to obtain a strictly increasing sequence by removing no more than one element from the array.
Note: sequence a0, a1, ..., an is considered to be a strictly increasing if a0 < a1 < ... < an. Sequence containing only one element is also considered to be strictly increasing.
Example
For sequence = [1, 3, 2, 1], the output should be
almostIncreasingSequence(sequence) = false.
There is no one element in this array that can be removed in order to get a strictly increasing sequence.
For sequence = [1, 3, 2], the output should be
almostIncreasingSequence(sequence) = true.
You can remove 3 from the array to get the strictly increasing sequence [1, 2]. Alternately, you can remove 2 to get the strictly increasing sequence [1, 3].*/

bool almostIncreasingSequence(int[] sequence) {
if (sequence.Length == 1)
return true;
List<int> seq = sequence.ToList();
List<int> seq2 = sequence.ToList();
for (int i = 0; i < seq.Count() - 1; i++){
    if (seq[i] >= seq[i + 1]){
        seq.RemoveAt(i);
        seq2.RemoveAt(i + 1);
        break;
    }
}
bool b1 = true;
bool b2 = true;
for (int i = 0; i < seq.Count() - 1; i++){
    if (seq2[i] >= seq2[i + 1])
    b1 = false;
    if (seq[i] >= seq[i + 1])
    b2 = false;
}
return b1|b2;
}

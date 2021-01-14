/*Given a rectangular matrix of characters, add a border of asterisks(*) to it.

Example

For

picture = ["abc",
           "ded"]
the output should be

addBorder(picture) = ["*****",
                      "*abc*",
                      "*ded*",
                      "*****"]*/
                      
string[] addBorder(string[] picture) {
List<string> result = new List<string>();
int length = picture.Length;
int width = picture[0].Length;
string beginAndEnd = new String ('*', width + 2);
result.Add(beginAndEnd);
for (int i = 0; i < length; i++){
    result.Add('*' + picture[i] + '*');
}
result.Add(beginAndEnd);
string[] res = result.ToArray();
return res;
}

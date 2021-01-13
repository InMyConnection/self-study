/*Write a function that reverses characters in (possibly nested) parentheses in the input string.

Input strings will always be well-formed with matching ()s.

Example

For inputString = "(bar)", the output should be
reverseInParentheses(inputString) = "rab";
For inputString = "foo(bar)baz", the output should be
reverseInParentheses(inputString) = "foorabbaz";
For inputString = "foo(bar)baz(blim)", the output should be
reverseInParentheses(inputString) = "foorabbazmilb";
For inputString = "foo(bar(baz))blim", the output should be
reverseInParentheses(inputString) = "foobazrabblim".
Because "foo(bar(baz))blim" becomes "foo(barzab)blim" and then "foobazrabblim".*/

string reverseInParentheses(string inputString) {
            Regex regex = new Regex(@"\(\w*\)");
            MatchCollection matches = regex.Matches(inputString);
            for (int i = 0; i < matches.Count; i++)
            {
                string match = matches[i].ToString();
                char[] charToTrim = { '(', ')' };
                string target = match.Trim(charToTrim);
                target = String.Join(String.Empty, target.Reverse());
                inputString = inputString.Replace(match, target);
                inputString = reverseInParentheses(inputString);
            }
            return inputString;
}

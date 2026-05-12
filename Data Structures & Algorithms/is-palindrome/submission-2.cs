public class Solution {
    public bool IsPalindrome(string s) {
        //Time: O(nLogn) | Space: O(n)
        var cleaned = CleanStr(s);
        var reversed = ReverseStr(cleaned);

        return cleaned == reversed;
    }
    private string ReverseStr(string str)
    {
        var cleaned = CleanStr(str);
        var chars = cleaned.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    private string CleanStr(string str)
    {
         var stringBuilder = new StringBuilder();

        foreach(var ch in str)
        {
            if(char.IsLetterOrDigit(ch))
            {
                stringBuilder.Append(char.ToLower(ch));
            }
        }
        return stringBuilder.ToString();
    }
}

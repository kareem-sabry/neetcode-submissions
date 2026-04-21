public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s == null || t == null || s.Length != t.Length)
            return false;

        return OrderStr(s) == OrderStr(t); 
    }
    private static string OrderStr(string str)
    {
        char[] chars = str.ToLower().ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}

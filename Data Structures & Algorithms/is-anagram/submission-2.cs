public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s == null || t == null || s.Length != t.Length)
            return false;

        int[] charCounts = new int[26];
        for(int i = 0; i < s.Length; i++)
        {
            charCounts[char.ToLower(s[i]) - 'a'] ++;
            charCounts[char.ToLower(t[i]) - 'a'] --;
            
        }
        foreach(int count in charCounts)
        {
            if(count != 0) return false;
        }
        return true;
    }
}

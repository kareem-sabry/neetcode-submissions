public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s == null || t == null || (s.Length != t.Length))
        {
            return false;
        }

        var map = new Dictionary<char, int>();

        foreach (char ch in s)
        {
            map[ch] = map.GetValueOrDefault(ch) + 1;
        }

        foreach (char ch in t)
        {
            map[ch] = map.GetValueOrDefault(ch) - 1;

            if (map[ch] < 0)
            {
                return false;
            }
        }
        return true;
    }
}
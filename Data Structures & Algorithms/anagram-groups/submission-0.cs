public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
    Dictionary<string, List<string>> map = new();
        List<List<string>> result = new List<List<string>>();
        foreach (var str in strs)
        {
            var sortedStr = SortStr(str);
            if (!map.ContainsKey(sortedStr))
            {
                map[sortedStr] = new List<string>();
            }
            map[sortedStr].Add(str);
        }

        foreach (var (key,value) in map)
        {
            result.Add(value);
        }

        return result;
    }

    private string SortStr(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}

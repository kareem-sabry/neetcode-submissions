public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //strs = ["act","pots","tops","cat","stop","hat"]
        
        var result = new List<List<string>>();
        var map = new Dictionary<string,List<string>>();
        foreach(string original in strs)
        {
            var sortedKey = OrderStr(original);

            if(!map.ContainsKey(sortedKey))
            {
                map[sortedKey] = new List<string>();
            }
            
            map[sortedKey].Add(original);
           
        }
        return map.Values.ToList();
    }
    private static string OrderStr(string s)
    {
        char[] chars = s.ToLower().ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}

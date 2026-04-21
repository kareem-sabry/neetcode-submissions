public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        var result = new int[k];
        foreach (var num in nums)
        {
            map[num] = map.GetValueOrDefault(num) + 1;
        }

        var list = new List<KeyValuePair<int,int>>(map);
        list.Sort((a,b)=>b.Value.CompareTo(a.Value));
        
        for (int i = 0; i < k; i++)
        {
            result[i] = list[i].Key;
        }

        return result;
    }
    
}

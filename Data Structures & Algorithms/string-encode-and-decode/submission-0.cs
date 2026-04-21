public class Solution {

    public string Encode(IList<string> strs) {
        if(strs == null || strs.Count == 0)
        {
            return "";
        }
        var strBuilder = new StringBuilder();
        foreach(var str in strs)
        {
            strBuilder.Append(str.Length+"#"+str);
        }
        
        return strBuilder.ToString();
       
    }

    public List<string> Decode(string s) {
        //     i
        //       j
        // s = 55#hello5#world
        int i = 0;
        var result = new List<string>();
        while(i < s.Length)
        {
            int j = i;
            while(s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j+1,length));
            i = j + 1 + length;
        }
        return result;

   }
}

public class Solution {
    public int[] ReplaceElements(int[] arr) {
        // Time: O(N ^ 2) : Space : O(1)
        int[] result = new int[arr.Length];

        for(int i = 0; i < arr.Length ; i++)
        {
            if(i == arr.Length - 1)
            {
                result[i] = -1;
            }
            else
            {
               int max = 0;
               for(int j = i + 1; j < arr.Length; j++)
               {
                    max = Math.Max(max,arr[j]);
               }
               result[i] = max;
            }
        }
        return result;
    }
}
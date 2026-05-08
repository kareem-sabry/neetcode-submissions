public class Solution {
    public int[] ReplaceElements(int[] arr) {
        //Time : O(N ^ 2) | Space : O(1) 
        
        int[] result = new int[arr.Length];
        
        int maxRight = -1;
        for(int i = arr.Length - 1; i >=0; i-- )
        {
           result[i] = maxRight;
           maxRight = Math.Max(maxRight,arr[i]);
        }


     return result;   
    }
}
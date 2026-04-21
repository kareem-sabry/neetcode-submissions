public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
       // Optimal | time : O(n log n)
        // space : O(n)
        int n = position.Length;
        if (n <= 1) return n;

        var cars = new (int pos, double time)[n];

        for(int i = 0; i < n; i++)
        {
            cars[i] = (position[i], (double)(target-position[i])/speed[i]);
        }
        
        Array.Sort(cars,(a,b)=>b.pos.CompareTo(a.pos));

        Stack<double> stack = new Stack<double>();
        foreach(var car in cars)
        {
            if(stack.Count == 0 || car.time > stack.Peek())
            {
                stack.Push(car.time);
            }
        }
        
        return stack.Count;
    }
}

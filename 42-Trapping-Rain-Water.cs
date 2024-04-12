public class Solution {
    public int Trap(int[] height) {
       var l = 0;
        var r = height.Length  - 1;
        var leftMax = 0;
        var rightMax = 0;
        var ans = 0;

        while(l < r)
        {
            if(height[l] < height[r])
            {
                leftMax = Math.Max(leftMax, height[l]);
                ans += (leftMax - height[l]);
                l++;
            }
            else
            {
                rightMax = Math.Max(rightMax, height[r]);
                ans += (rightMax - height[r]);
                r--;
            }
        }

        return ans;


    }
}
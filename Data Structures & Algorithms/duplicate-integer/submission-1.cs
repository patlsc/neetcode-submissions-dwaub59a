public class Solution {
    public bool hasDuplicate(int[] nums) {
        var s = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++ ){
if (s.Contains(nums[i])) {return true;}
s.Add(nums[i]);
        }
        return false;
    }
}
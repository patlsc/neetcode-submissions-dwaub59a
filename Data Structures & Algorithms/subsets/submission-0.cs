public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        /*
        for each element we either include it or exclude it
        so we make one copy of our current running list including x and one not including
        so in other words we append to the existing subsets all the current ones but including x
        */
        if (nums.Length == 0) {
            return new List<List<int>>();
        }
        List<List<int>> r = new List<List<int>>();
        r.Add(new List<int>()); //empty
        for (int i = 0; i < nums.Length; i++) {
            int existingSubsets = r.Count;
            for (int k = 0; k < existingSubsets; k++) {
                List<int> x = new List<int>(r[k]);
                x.Add(nums[i]);
                r.Add(x);
            }
        }
        return r;
    }
}

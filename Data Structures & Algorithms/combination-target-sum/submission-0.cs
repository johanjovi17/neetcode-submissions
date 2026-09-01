public class Solution {
    private void findCombinations(int ind, int[] arr, int target, List<List<int>> ans, List<int> ds){
        if(ind == arr.Length){
            if(target == 0){
                ans.Add(new List<int>(ds));
            }
            return;
        }

        if(arr[ind]<=target){
            ds.Add(arr[ind]);
            findCombinations(ind,arr,target-arr[ind],ans,ds);
            ds.RemoveAt(ds.Count-1);
        }
        findCombinations(ind+1,arr,target,ans,ds);
    }


    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> ans = new List<List<int>>();
        findCombinations(0,nums,target,ans,new List<int>());
        return ans;
    }
}

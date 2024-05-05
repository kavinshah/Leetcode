/*
                         [1,1,2]
                /           |                   \
            [0]             [1]                 [2]
           /   \           /    \             /     \
        [0,1]  [0,2]    [1,0]   [1,2]       [2,0]   [2,1]
          |       |       |       |          |          |
       [0,1,2]  [0,2,1] [1,0,2] [1,2,0]     [2,0,1]     [2,1,0]
       [1,1,2]  [1,2,1] [1,1,2] [1,2,1]     [2,1,1]     [2,1,1]


[0,3,3,3]

*/

public class Solution {
    IList<IList<int>> result = new List<IList<int>>();
    HashSet<int> includedIndexes = new HashSet<int>();
    List<int> includedElements = new List<int>();
    int[] nums;
    public IList<IList<int>> PermuteUnique(int[] nums) {
        this.nums = nums;
        Array.Sort(this.nums);
        FindPermutations();
        return result;
    }
    
    public void FindPermutations(){
        if(includedElements.Count == nums.Length){
            result.Add(new List<int>(includedElements));
            return;
        }
        
        for(int i=0; i<nums.Length; i++){
            if(!includedIndexes.Contains(i) && !CheckDuplicateOfPreviousNext(i)){
                includedIndexes.Add(i);
                includedElements.Add(nums[i]);
                FindPermutations();
                includedElements.RemoveAt(includedElements.Count-1);
                includedIndexes.Remove(i);
            }
        }
        return;
    }
    
    public bool CheckDuplicateOfPreviousNext(int index){
        foreach(int i in includedIndexes){
            if(i>index && nums[i] == nums[index])
                return true;
        }
        return false;
    }
}

//Time: O(2^k * N)
//Space: O(2^k)
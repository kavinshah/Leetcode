/*

[2,2,2,2]

[], 
2
2,2
2,2,2
2,2,2,2
2
2,2
2,2,2


                    1,2,3
                            0,[]
                       /           \
                   1,[]            1,[1]
               /        \
             2,[]      2,[2]
             /  \       /     \
        3, []   3, [3]  3,[2] 3, [2,3]
      
1,2,2,3
2
2 2
2 2 3
2
2 3



*/


public class Solution {
    int[] nums;
    IList<IList<int>> result = new List<IList<int>>();
    //HashSet<IList<int>> result = new HashSet<IList<int>>();
    
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        this.nums=nums;
        Array.Sort(nums);
        FindSubsets(0, new List<int>());
        
        return result.ToList();
    }
    
    public void FindSubsets(int index, List<int> currentList){
        if(index==nums.Length){
            List<int> newList = new List<int>();
            newList.AddRange(currentList);
            foreach(List<int> item in result){
                if(item.SequenceEqual(newList))
                    return;
            }
            result.Add(newList);
            return;
        }
        
        FindSubsets(index+1, currentList);
        currentList.Add(nums[index]);
        FindSubsets(index+1, currentList);
        currentList.RemoveAt(currentList.Count-1);
        return;
    }
}

//Time: O(2^N*2^N)
//space: O(2^N)
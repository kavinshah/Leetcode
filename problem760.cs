public class Solution {
    public int[] AnagramMappings(int[] nums1, int[] nums2) {
        Dictionary<int,int> mappings = new Dictionary<int,int>();
        int[] result=new int[nums2.Length];
        for(int i =0; i<nums2.Length; i++){
            mappings.TryAdd(nums2[i], i);
        }
        
        for(int i =0; i< nums1.Length; i++){
            result[i]=mappings[nums1[i]];
        }
        
        return result;
        
    }
}

//time: O(N)
//space: O(N)
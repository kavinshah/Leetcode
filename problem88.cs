public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int current=nums1.Length-1, position_m=m-1, position_n=n-1;
        
        while(current>=0 && position_n>=0 && position_m>=0)
        {
            //Console.WriteLine("1");
            if(nums1[position_m]>=nums2[position_n])
            {
                nums1[current--]=nums1[position_m];
                position_m--;
            }
            else
            {
                nums1[current--]=nums2[position_n];
                position_n--;
            }
        }
        
        while(position_m>=0)
        {
            //Console.WriteLine("2");
            nums1[current--]=nums1[position_m];
            position_m--;
        }
         
        while(position_n>=0)
        {
            //Console.WriteLine("3");
            nums1[current--]=nums2[position_n];
            position_n--;
        }
        
        return;
    }
}

//time: O(M+N)
//space: O(1)
/*

[5,2,3,4,1]
k=5 [1,4,3,2,5]
k=2 [4,1,3,2,5]
k=4 [2,3,1,4,5]
k=2 [3,2,1,4,5]
k=3 [1,2,3,4,5]

*/

public class Solution {
    int length;
    int[] arr;
    public IList<int> PancakeSort(int[] arr) {
        this.length=arr.Length;
        this.arr=arr;
        IList<int> result=new List<int>();
        
        for(int i=arr.Length; i>0; i--)
        {
            if(arr[i-1]==i)
                continue;
            
            int index = FindIndex(i);
            if(index!=0)
            {
                Flip(arr, index);
                result.Add(index+1);
            }
            Flip(arr, i-1);
            result.Add(i);
            
        }
        return result;
        
    }
    
    public int FindIndex(int item)
    {
        for(int i=0; i<length; i++)
            if(item==arr[i])
                return i;
        
        return -1;
    }
    
    public void Flip(int[] arr, int index)
    {
        int left=0, right=index;
        while(left<right)
        {
            int temp = arr[left];
            arr[left]=arr[right];
            arr[right]=temp;
            left++;
            right--;
        }
        //Console.WriteLine(String.Join(",", arr));
    }
    
}

//Time: O(N)
//space: O(N)
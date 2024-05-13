/*
 0 1  2 3  4 5 6
[2,4,12,17,9,8,7]
59

index = 1
val = 2



                                use segment trees

                                         0,7 - 59
                                    /           \
                                0,3-35              4,6-24
                            /       \           /           \
                        0,1-6        2,3-29    4,5-17        6,6-7
                    /       \        /\        /   \          |
                    0,0     1,1    2,2 3,3    4,4   5,5       7
                    |        |      |   |      |     |      
                    2        4      12  17     9     8      
                    
[1,4]
[1,4] = [0,6] - [0,0] - [4,6] + [4,4]
0





*/

public class NumArray {
    int[] nums;
    int[] seg;
    
    public NumArray(int[] nums) {
        this.nums = nums;
        this.seg = new int[nums.Length*4];
        Build(0, 0, nums.Length-1);
        //Console.WriteLine(String.Join(",", seg));
    }
    
    public void Update(int index, int val) {
        UpdateSegmentTree(index, val, 0, 0, nums.Length-1);
        return;
    }
    
    public int SumRange(int left, int right) {
        return FindSum(0, 0, nums.Length-1, left, right);
    }
    
    public void Build(int index, int low, int high){
        if(low==high){
            seg[index]=nums[low];
            return;
        }
        
        int mid = (int)((low+high)/2);
        Build(index*2+1, low, mid);
        Build(index*2+2, mid+1, high);
        seg[index] = seg[index*2+1] + seg[index*2+2];
        return;
    }
    
    public int FindSum(int index, int low, int high, int l, int r){
        if(low>=l && high<=r){
            return seg[index];
        }
        
        if(low>r || high<l){
            return 0;
        }
        
        int mid = (int)((low+high)/2);
        int left = FindSum(index*2+1, low, mid, l, r);
        int right = FindSum(index*2+2, mid+1, high, l, r);
        return left+right;   
    }
    
    public void UpdateSegmentTree(int index, int val, int current, int low, int high){
        
        if(low==high && low==index){
            seg[current] = val;
            return;
        }
        
        int mid=(int)((low+high)/2);
        if(index<=mid){
            UpdateSegmentTree(index, val, current*2+1, low, mid);
        } else {
            UpdateSegmentTree(index, val, current*2+2, mid+1, high);
        }
        
        seg[current] = seg[current*2+1] + seg[current*2+2];
        
        //Console.WriteLine("{0}, {1}, {2}, [{3}]", index, val, current, String.Join(",", seg));
        
        return;
    }
}

/*
Time:
Sum Operation: O(log N)
Update: O(log N)

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */
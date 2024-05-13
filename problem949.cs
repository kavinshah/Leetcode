/*

- brute force
- sort nums in descending
- for each permutation: check rules
- Rules:
	0<=h1<=2
	0<=h2<=9
	0<=m1<=5
	0<=m2<=9
	
	for h1 = 2, 0<=h2<=3
	for h1 < 2, 0<=h2<=9

*/

public class Solution {
    int[] arr;
    HashSet<int> visited = new HashSet<int>();
    public string LargestTimeFromDigits(int[] arr) {
        string result;
        this.arr = arr;
        Array.Sort(this.arr);
        
        if(!Permute())
            return "";
        
        int[] items = visited.ToArray();
        int h1=arr[items[0]];
        int h2=arr[items[1]];
        int m1=arr[items[2]];
        int m2=arr[items[3]];
        
        result = h1.ToString() + h2.ToString() + ":" + m1.ToString() + m2.ToString();
        
        return result;
    }
    
    public bool Permute(){
        
        if(visited.Count==arr.Length)
            return CheckRules();
        
        for(int i=arr.Length-1; i>=0; i--){
            if(!visited.Contains(i)){
                visited.Add(i);
                if(Permute())
                    return true;
                visited.Remove(i);
            }
        }
        return false;
    }
    
    public bool CheckRules(){
        int[] items = visited.ToArray();
        int h1=arr[items[0]];
        int h2=arr[items[1]];
        int m1=arr[items[2]];
        int m2=arr[items[3]];
        
        if(h1>2 || m1 > 5)
            return false;
        
        if(h1==2 && h2>=4)
            return false;
        
        return true;
        
    }
}

//Time: O(4.2^4)
//Space: O(4)
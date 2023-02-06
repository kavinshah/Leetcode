public class Solution {
    private int[] _consecutiveSatisfied;
    private int[] _satisfiedWhenNotGrumpy;
    int currentsum=0;
    int totalsum = 0;
    int maxCustomers = 0;
    
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        _consecutiveSatisfied = new int[customers.Length];
        _satisfiedWhenNotGrumpy = new int[customers.Length];
        
        for(int i=0;i<minutes;i++){
            currentsum+=customers[i];
        }
        _consecutiveSatisfied[0]=currentsum;
        for(int i=minutes; i<customers.Length; i++){
            currentsum-=customers[i-minutes];
            currentsum+=customers[i];
            _consecutiveSatisfied[i-minutes+1]=currentsum;
            if(grumpy[i]==0){
                totalsum+=customers[i];
            }
        }
        _satisfiedWhenNotGrumpy[0]=totalsum;
        for(int i=minutes;i<customers.Length; i++){
            if(grumpy[i-minutes]==0){
                totalsum+=customers[i-minutes];
            }
            if(grumpy[i]==0){
                totalsum-=customers[i];
            }
            _satisfiedWhenNotGrumpy[i-minutes+1]=totalsum;
        }
        
        // Console.WriteLine(String.Join(",", _consecutiveSatisfied));
        // Console.WriteLine(String.Join(",", _satisfiedWhenNotGrumpy));
        
        for(int i=0; i<=customers.Length-minutes;i++){
            maxCustomers=Math.Max(maxCustomers, _consecutiveSatisfied[i] + _satisfiedWhenNotGrumpy[i]);
        }
        
        return maxCustomers;
    }
}

//time: O(N)
//space: O(N)
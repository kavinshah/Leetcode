public class Solution {
    public int DietPlanPerformance(int[] calories, int k, int lower, int upper) {
        double totalSum=0;
        int points=0;
        for(int i=0; i<k; i++){
            totalSum+=calories[i];
        }
        
        if(totalSum < lower)
            points--;
        else if(totalSum > upper)
            points++;
        
        for(int i=k; i<calories.Length; i++){
            totalSum-=calories[i-k];
            totalSum+=calories[i];
            if(totalSum < lower)
                points--;
            else if(totalSum>upper)
                points++;
        }
        
        return points;
            
    }
}

// time: O(N)
// Space: O(1)
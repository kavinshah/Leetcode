class Solution:    
    #Function to get the maximum total value in the knapsack.
    def fractionalknapsack(self, w,arr,n):
        result=0
        
        def comparator(x):
            return x.value/x.weight
        
        arr.sort(reverse=True, key=comparator)
        
        for item in arr:
            currentWeight = min(w, item.weight)
            result += (item.value/item.weight) * currentWeight
            w-=currentWeight
            if(w==0):
                break
        
        return result
        
        # code here

#time: O(NlogN)
#space: O(1)
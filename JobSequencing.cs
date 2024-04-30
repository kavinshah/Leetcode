//User function Template for C#

/*

(1,2,100)
(2,1,19)
(3,1,27)
(4,1,25)
(5,1,15)

- if sort by profit, then you might miss jobs that have an early deadline and are more profitable
- if you sort by deadline, then you might miss jobs that have a later dealdine and are more profitable


class Job{
        public int id;
        public int dead;
        public int profit;
        public Job(int id,int dead,int profit) {
            this.id = id;
            this.dead = dead;
            this.profit = profit;
        }
    }
*/

class Solution
{
    //Complete this function
    int[] deadlines;
    public int[] JobScheduling(Job[] arr, int n)
    {
        //Your code here
        int profit=0;
        int jobs=0;
        int maxDeadline=0;
        
        for(int i=0; i<arr.Length; i++){
            maxDeadline=Math.Max(arr[i].dead, maxDeadline);
        }
        
        deadlines = Enumerable.Repeat(-1, maxDeadline+1).ToArray();
        
        Array.Sort(arr, delegate(Job X, Job Y){
            return X.profit.CompareTo(Y.profit);
        });
        
        
        for(int i=arr.Length-1; i>=0; i--){
             if(TryPerform(arr[i])){
                 profit += arr[i].profit;
                 jobs +=1;
             }
        }
        
        return new int[]{jobs, profit};
    }
    
    public bool TryPerform(Job job){
        for(int i=job.dead; i>0; i--){
            if(deadlines[i]==-1){
                deadlines[i]=job.id;
                return true;
            }
        }
        return false;
    }
}

//Time: O(NLogN)
//Space: O(M)
//https://www.geeksforgeeks.org/problems/n-meetings-in-one-room-1587115620/1

class Solution
{
    //Complete this function
    //Function to find the maximum number of meetings that can
    //be performed in a meeting room.
    public int maxMeetings(int[] start, int[] end, int n)
    {
        //Your code here
        //PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        List<(int startTime, int endTime)> startEndTimes = new List<(int,int)>();
        int result = 0;
        (int startTime, int endTime) prev;
        int i;
        
        for(i=0; i<start.Length; i++)
        {
            startEndTimes.Add((start[i], end[i]));
        }
        
        startEndTimes.Sort(delegate((int startTime, int endTime) x, (int startTime, int endTime) y){
            return x.endTime.CompareTo(y.endTime);
        });
        
        // foreach(var x in startEndTimes)
        //     Console.WriteLine(x);
        
        prev = startEndTimes[0];
        result=1;
        
        for(i=1; i<startEndTimes.Count; i++)
        {
            (int startTime, int endTime) current = startEndTimes[i];
            if(prev.endTime < current.startTime){
                result++;
                prev = current;
            }
        }
        
        return result;
    }

}

//Time: O(NLogN)
//Space: O(N)


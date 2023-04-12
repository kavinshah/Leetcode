public class Point
{
    public double distance;
    public int[] point;
}
public class Solution {
    int k;
    PriorityQueue<Point,double> pqueue;
    int[][] result;
    public int[][] KClosest(int[][] points, int k) {
        pqueue = new PriorityQueue<Point,double>();
        result=new int[k][];
        
        foreach(int[] p in points)
        {
            double d=CalculateDistanceFromOrigin(p);
            Point pObj = new Point(){point=p, distance=d};
            if(pqueue.Count<k)
            {
                pqueue.Enqueue(pObj,-d);
            }
            else if(d<pqueue.Peek().distance)
            {
                pqueue.Dequeue();
                pqueue.Enqueue(pObj,-d);
            }
        }
        
        while(pqueue.Count>0)
        {
            result[pqueue.Count-1]=new int[2];
            result[pqueue.Count-1]=pqueue.Dequeue().point;
        }
        return result;
    }
    
    public double CalculateDistanceFromOrigin(int[] point)
    {
        return Math.Sqrt((point[0]*point[0])+(point[1]*point[1]));
    }
}

//time: O(NlogK)
//space: O(k)
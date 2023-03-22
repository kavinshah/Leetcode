/*

10,20   => 1,1      => 1
30,200  => 2,4      => 3
400,50  => 4,3      => 3.5
30,20   => 2,1      => 1.5

DP

min((c[0] + cost1, cost2), (cost1, c[1]+cost2))

[[10,20],[400,50],[30,200],[30,20]]        

[[259,770],[448,54],[926,667],[184,139],[840,118],[577,469]]
259+54+667+184+118+577

[[515,563],[451,713],[537,709],[343,819],[855,779],[457,60],[650,359],[631,42]]
563+451+709+343+855+60+650+42

*/

public class Solution {
    
    public class MyComparer:IComparer{
        int IComparer.Compare(object a, object b)
        {
            int[] x=(int[])a;
            int[] y=(int[])b;
            if((x[0]-x[1]) == (y[0]-y[1]))
                return 0;
            if((x[0]-x[1]) > (y[0]-y[1]))
                return 1;
            return -1;
        }
    }
    
    public int TwoCitySchedCost(int[][] costs) {
        int result=0;
        int n = costs.Length/2;
        Array.Sort(costs, new MyComparer());
        for(int i=0; i<n; i++)
        {
            result+=costs[i][0];
        }
        for(int i=n; i<2*n;i++)
        {
            result+=costs[i][1];
        }
        return result;
    }    
}

//time: O(N)
//space: O(1)
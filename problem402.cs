/*

1432219, k=3
n=7
x=n-k=4
1432
1431
1439
1422
1421
1429
1419
1322
1321
1329
1319
1221
1229
1219
4322
4321
4329
4319
4221
4229
4219
3221
3229
3219
2219

10200, x=4
1020
1200
0200

10, x=0
0

6845132168, x=4
1168

6845132168, x=5
12168

6845132168, x=6
132168

6845132168, x=7
4132168

6845132168, x=8
45132168


*/


public class Solution {
    public string RemoveKdigits(string num, int k) {
        int counter=0;
        int x = num.Length-k;
        StringBuilder result=new StringBuilder();
        int start=0;
        int end=num.Length-x;
        
        while(x>0)
        {
            int current=start;
            while(current<=end)
            {
                if(num[current]<num[start])
                {
                    start=current;
                }
                else if(num[current]=='0')
                    break;
                    
                current++;
            }
            
            result.Append(num[start]);
            start=start+1;
            end++;
            x--;
        }
        
        while(result.Length>0 && result[0]=='0')
            result.Remove(0,1);
        
        if(result.Length==0)
            return "0";
        
        return result.ToString();
    }
}

//Time: O(K*N)
//Space: O(1)

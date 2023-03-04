public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int x1 = points[0][0];
        int y1 = points[0][1];
        int time=0; 
        for(int i=1; i<points.Length; i++)
        {
            int x2=points[i][0];
            int y2=points[i][1];
            int delta;
            if(x1==x2){
                time += Math.Abs(y1-y2);
            } else if(y1==y2){
                time += Math.Abs(x1-x2);
            } else if( Math.Abs(x1-x2) == Math.Abs(y1-y2)){
                time += Math.Abs(x1-x2);
            }
            else{
                delta = Math.Abs(Math.Abs(x1-x2) - Math.Abs(y1-y2));
                time += delta;
                
                if(Math.Abs(x1-x2) > Math.Abs(y1-y2)){
                    //then fix x1
                    if(x1>x2){
                        x1+=delta;
                    } else {
                        x1-=delta;
                    }
                    time += Math.Abs(y1-y2);
                } else {
                    //fix y1
                    if(y1<y2){
                        y1+=delta;
                    } else{
                        y1-=delta;
                    }
                    time += Math.Abs(x1-x2);
                }
            }
            x1=x2;
            y1=y2;
        }
        return time;
    }
}

// Time: O(N)
// Space: O(1)

/*

if x1==x2:
    time += abs(y1-y2)
else if y1==y2:
    time += abs(x1-x2)
else if x1-x2 == y1-y2:
    time += abs(x1-x2)
else:
    delta = abs(abs(x1-x2)-abs(y1-y2))
    time += del
    if abs(x1-x2) > abs(y1-y2):
        //then fix x1
        if x1<x2:
            x1+=del
        else:
            x1-=del
        time += abs(y1-y2)
    else:
        //then fix y1
        if y1<y2:
            y1+=del
        else:
            y1-=del
        time += abs(x1-x2)
    now the diff is same so just add time:
    
    //update x1,y1

--> assign x1=x2, y1=y2

*/
/*

    1-> 2-> 3 -> 4

n=4, time = 5

mod = time%(n-1)
div = time/ (n-1)

mod = 2
div = 1

if mod==0:
    if div%2==1:
        then n
    else:
        1
else:
    if div%2=1:
        return n-mod
    else:
        return mod+1



*/

public class Solution {
    public int PassThePillow(int n, int time) {
        int mod = time%(n-1);
        int div = (int)(time/(n-1)) %2;
        
        if(mod==0){
            if(div%2==1){
                return n;
            } else{
                return 1;
            }
        } else{
            if(div%2==1){
                
                return (n-mod);
            } else{
                return (mod+1);
            }
        }
        
    }
}

//time: O(1)
//space: O(1)
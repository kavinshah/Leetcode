/*

if current char=0: then go 1 position
if current char=1: then go 2 position 

*/

public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        int position=0;
        
        while(true)
        {
            if(position>=bits.Length)
                return false;
            else if(position == bits.Length-1)
                return true;
                
            if(bits[position]==0)
                position+=1;
            else
                position+=2;
        }
    }
    
    
}

//time: O(N)
//space: O(1)
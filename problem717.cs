/*

if current char=0: then go 1 position
if current char=1: then go 2 position 

*/

public class Solution {
    int[] bits;
    public bool IsOneBitCharacter(int[] bits) {
        this.bits=bits;
        return Traverse(0);
    }
    
    public bool Traverse(int position)   
    {
        //Console.WriteLine(position);   
        if(position>=bits.Length)
            return false;
        
        if(position==bits.Length-1)
            return true;
        
        if(bits[position]==1)
            return Traverse(position+2);
        else
            return Traverse(position+1);
            
    }
}


//time: O(N)
//space: O(N)
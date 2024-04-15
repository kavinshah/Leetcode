public class Solution {
    public int MinBitFlips(int start, int goal) {
        int xor=start^goal;
        int result=0;
        
        while(xor!=0){
            result += xor&1;
            xor=xor>>1;
        }
        return result;
    }
}

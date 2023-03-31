/*

                                    15,1
                            /       |       \
                            12,0      13      14
                        /   |   \
                        9,1   10  11
                    /   |   \
                    6,0   7   8
                /   |   \
                3,1   4   5
                |   /|\
                W  1 2 3
                  |  |  |
                  w  w  w
      
[1]=t
[2]=t
[3]=t
[4]=f
[5]=t
[6]=t
[7]=t
[8]=f
[9]=t
[10]=t
[11]=t
[12]=f
..
..



*/

public class Solution {
    public bool CanWinNim(int n) {
        return !(n%4==0);
        
    }
}

//time: O(1)
//space: O(1)
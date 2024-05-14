/*

a   b   c
0   1   2

brute force: O(N)

0 1 0
1,2,1
0,2,1

                                0,2- 1
                            /       \
                        0,1- -1       2,2- 1
                    /       \       |
                0,0        1,1- 1   c
                |           |
                a           b

1   -1  1   0   1   0

a   b   c
0   1   2
a   c   e

Segment Tree: O(Log N)

*/

public class Solution {
    int[] segment;
    int[] totalShifts;
    char[] result;
    public string ShiftingLetters(string s, int[][] shifts) {
        segment = new int[s.Length*4];
        totalShifts = Enumerable.Repeat(0, s.Length).ToArray();
        result = new char[s.Length];
        
        foreach(int[] sh in shifts){
            int val = sh[2]==0?-1:1;
            Query(0, 0, s.Length-1, sh[0], sh[1], val);
        }
        //traverse the entire segment tree to reach the individual node and get the final shift
        Traverse(0, 0, totalShifts.Length-1, 0);
        
        for(int i=0; i<totalShifts.Length; i++){
            //Console.WriteLine(totalShifts[i]);
            int newChar = 97 + ((int)s[i] - 97 + 26 + totalShifts[i])%26;
            result[i]=(char)newChar;
        }
        return String.Join("", result);
    }
    
    public void Query(int index, int low, int high, int l, int r, int val){
        if(low>=l && high<=r){
            segment[index] += val;
            return;
        }
        
        if(r<low || high<l){
            return;
        }
        
        int mid = (int)((low+high)/2);
        Query(index*2+1, low, mid, l, r, val);
        Query(index*2+2, mid+1, high, l, r, val);
        return;
    }
    
    public void Traverse(int index, int low, int high, int val){
        if(low==high){
            totalShifts[low] = (val + segment[index])%26;
            return;
        }
        
        int mid = (int)((low+high)/2);
        Traverse(index*2+1, low, mid, val+segment[index]);
        Traverse(index*2+2, mid+1, high, val+segment[index]);
        return;
    }
}

//time: O(Q.logN + N) -- Q=number of queries, N=length of input string
//Space: O(N)
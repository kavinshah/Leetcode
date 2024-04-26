/*



*/


public class Solution {
    public int CompareVersion(string version1, string version2) {
        string[] v1 = version1.Split(".");
        string[] v2 = version2.Split(".");
        int maxVersion = v1.Length>v2.Length? v1.Length : v2.Length;
        
        for(int i=0; i<maxVersion; i++) {
            int part1, part2;
            
            if(v1.Length<=i){
                part1 = 0;
            } else {
                part1 = Int32.Parse(v1[i]);
            }
            
            if(v2.Length<=i) {
                part2 = 0;
                
            } else {
                part2 = Int32.Parse(v2[i]);
            }
            
            //Console.WriteLine("{0}, {1}", part1, part2);
            
            if(part1>part2)
                return 1;
            else if(part1 < part2)
                return -1;
        }
        
        return 0;
        
    }
}

//time: O(N+M)
//space: O(N+M)

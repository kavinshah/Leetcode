/*

dir
\tsubdir1
\t\tfile1.ext
\t\tsubsubdir1
\tsubdir2
\t\tsubsubdir2
\t\t\tfile2.ext


[dir], currcount=0
[dir[subdir1]], currcount=1
[dir[subdir1[file1.ext]]], currcount=2
[dir[subdir1[file1.ext, subsubdir1]]], currcount=2
[dir[subdir1[file1.ext, subsubdir1],subdir2]], currcount=1
[dir[subdir1[file1.ext, subsubdir1],subdir2[subsubdir2]]], currcount=2
[dir[subdir1[file1.ext, subsubdir1],subdir2[subsubdir2[file2.ext]]]], currcount=3

*/

public class Solution {
    public int LengthLongestPath(string input) {
        int longestPath=0;
        Stack<string> stack=new Stack<string>();
        int tabOrder=0;
        int currentStackLength=0;
        
        foreach(string line in input.Split("\n"))
        {
            int currentIndex=0;
            int currentTab=0;
            string currentLine = new String(line);
            //find the tab order of the item
            while(currentIndex<currentLine.Length && currentLine[currentIndex]=='\t')
            {
                currentTab++;
                currentIndex++;
            }
            currentLine=currentLine.Substring(currentIndex);
            
            //update stack
            while(stack.Count>0 && stack.Count>currentTab)
            {
                string popped=stack.Pop();
                currentStackLength-=popped.Length;
            }
            
            //check if we have a file or a directory
            if(currentLine.Contains('.'))
            {
                longestPath=Math.Max(longestPath, currentStackLength+stack.Count+currentLine.Length);
                // Console.WriteLine($"{currentStackLength}, {stack.Count}, {currentLine.Length}, {longestPath},{currentLine},{currentTab}");
            }
            else
            {
                stack.Push(currentLine);
                currentStackLength+=currentLine.Length;
                //Console.WriteLine(currentLine);
            }
        }
        
        return longestPath;
    }
}

//time:O(N) -- N=length of input
//space: O(N)
// google sample coding test
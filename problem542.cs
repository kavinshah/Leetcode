/*

[
[1,0,1,1,0,0,1,0,0,1],
[0,1,1,0,1,0,1,0,1,1],
[0,0,1,0,1,0,0,1,0,0],
[1,0,1,0,1,1,1,1,1,1],
[0,1,0,1,1,0,0,0,0,1],
[0,0,1,0,1,1,1,0,1,0],
[0,1,0,1,0,1,0,0,1,1],
[1,0,0,0,1,1,1,1,0,1],
[1,1,1,1,1,1,1,0,1,0],
[1,1,1,1,0,1,0,0,1,1]
]


[
[1,0,1,1,0,0,1,0,0,1],
[0,1,1,0,1,0,1,0,1,1],
[0,0,1,0,1,0,0,1,0,0],
[1,0,1,0,1,1,1,1,1,1],
[0,1,0,1,1,0,0,0,0,1],
[0,0,1,0,1,1,1,0,1,0],
[0,1,0,1,0,1,0,0,1,1],
[1,0,0,0,1,2,1,1,0,1],
[2,1,1,1,1,2,1,0,1,0],
[2,2,2,1,0,1,0,0,1,1]
]

[
[1,0,1,1,0,0,1,0,0,1],
[0,1,1,0,1,0,1,0,1,1],
[0,0,1,0,1,0,0,1,0,0],
[1,0,1,0,1,1,1,1,1,1],
[0,1,0,1,1,0,0,0,0,1],
[0,0,1,0,1,1,1,0,1,0],
[0,1,0,1,0,1,0,0,1,1],
[1,0,0,0,1,2,1,1,0,1],
[2,1,1,1,1,2,1,0,1,0],
[3,2,2,1,0,1,0,0,1,1]
]

*/



public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        Queue<(int,int,int)> queue = new Queue<(int,int,int)>();
        int[][] result = new int[mat.Length][];
        int maxRow=mat.Length-1;
        int maxCol=mat[0].Length-1;
        
        for(int i=0; i<result.Length; i++)
            result[i]=Enumerable.Repeat(Int32.MaxValue, mat[0].Length).ToArray();
        
        for(int i=0; i<mat.Length; i++)
        {
            for(int j=0; j<mat[0].Length; j++)
            {
                if(mat[i][j]==0)
                {
                    result[i][j]=0;
                    if((i+1)<=maxRow)
                        queue.Enqueue((i+1,j,mat[i][j]+1));
                    if((i-1)>=0)
                        queue.Enqueue((i-1,j,mat[i][j]+1));
                    if((j+1)<=maxCol)
                        queue.Enqueue((i,j+1,mat[i][j]+1));
                    if((j-1)>=0)
                        queue.Enqueue((i,j-1,mat[i][j]+1));
                }
                // Console.WriteLine($"{i},{j}");
                // printQueue(queue);
            }
        }
        
        while(queue.Count>0)
        {
            int queueCount=queue.Count;
            // printQueue(queue);
            for(int i=0; i<queueCount; i++)
            {
                (int,int,int) current = queue.Dequeue();
                if(result[current.Item1][current.Item2] > current.Item3)
                {
                    result[current.Item1][current.Item2]=current.Item3;
                    if((current.Item1+1)<=maxRow)
                        queue.Enqueue((current.Item1+1,current.Item2,current.Item3+1));
                    if((current.Item1-1)>=0)
                        queue.Enqueue((current.Item1-1,current.Item2,current.Item3+1));
                    if((current.Item2+1)<=maxCol)
                        queue.Enqueue((current.Item1,current.Item2+1,current.Item3+1));
                    if((current.Item2-1)>=0)
                        queue.Enqueue((current.Item1,current.Item2-1,current.Item3+1));
                    
                    // if(current.Item1==9 && current.Item2==0)
                    //     Console.WriteLine(result[current.Item1][current.Item2]);
                    
                }
            }
        }
        return result;
    }
    
    public void printQueue(Queue<(int,int,int)> queue)
    {
        Console.WriteLine("Printing queue");
        foreach(var q in queue)
            Console.WriteLine(q);
    }
}

//BFS
//Time: O(M*N)
// Space: O(M*N)
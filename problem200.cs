public class Solution {
    HashSet<Tuple<int,int>> visited = new HashSet<Tuple<int,int>>();
    Stack<Tuple<int,int>> stack= new Stack<Tuple<int,int>>();
    int maxRow, maxCol;
    public int NumIslands(char[][] grid) {
        int count = 0;
        maxRow=grid.Length;
        maxCol=grid[0].Length;
        for(int i =0; i<maxRow;i++)
        {
            for(int j=0; j<maxCol; j++)
            {
                Tuple<int, int> cell=new Tuple<int, int>(i,j); 
                if(grid[i][j] == '1' && !visited.Contains(cell))
                {
                    stack.Push(cell);
                    visited.Add(cell);
                    count+=1;
                    Dfs(i,j, grid);
                }
            }
        }
        
        return count;
    }
    
    public void Dfs(int row, int col, char[][] grid)
    {
        while(stack.Count!=0)
        {
            Tuple<int,int> current=stack.Pop();
            //Console.WriteLine("{0},{1}, counter:{2}", current.Item1,current.Item2, count);
            if((current.Item1+1)<maxRow && !visited.Contains(new Tuple<int,int>(current.Item1+1,current.Item2)) && grid[current.Item1+1][current.Item2]=='1')
            {
                visited.Add(new Tuple<int,int>(current.Item1+1, current.Item2));
                stack.Push(new Tuple<int,int>(current.Item1+1, current.Item2));
            }
            if((current.Item1-1)>=0 && !visited.Contains(new Tuple<int,int>(current.Item1-1,current.Item2)) && grid[current.Item1-1][current.Item2]=='1')
            {
                visited.Add(new Tuple<int,int>(current.Item1-1, current.Item2));
                stack.Push(new Tuple<int,int>(current.Item1-1, current.Item2));
            }
            if((current.Item2+1)<maxCol && !visited.Contains(new Tuple<int,int>(current.Item1,current.Item2+1)) && grid[current.Item1][current.Item2+1]=='1')
            {
                visited.Add(new Tuple<int,int>(current.Item1, current.Item2+1));
                stack.Push(new Tuple<int,int>(current.Item1, current.Item2+1));
            }
            if((current.Item2-1)>=0 && !visited.Contains(new Tuple<int,int>(current.Item1,current.Item2-1)) && grid[current.Item1][current.Item2-1]=='1')
            {
                visited.Add(new Tuple<int,int>(current.Item1, current.Item2-1));
                stack.Push(new Tuple<int,int>(current.Item1, current.Item2-1));
            }   
        }
    }
}
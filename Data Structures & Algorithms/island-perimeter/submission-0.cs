public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;
        HashSet<(int ,int )> visited = new HashSet<(int,int)>();

        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                if(grid[i][j]==1) return Dfs(i,j,rows,cols,grid,visited);
            }
        }
        return 0;
    }
    private int Dfs(int i,int j,int rows,int cols,int[][] grid,HashSet<(int r, int c)> visited){
        if(i<0 || i>=rows || j<0 || j>=cols || grid[i][j]==0 ) return 1;
        if(visited.Contains((i,j))) return 0;

        visited.Add((i,j));

        int perimeter = Dfs(i,j+1,rows,cols,grid,visited)
         + Dfs(i+1,j,rows,cols,grid,visited)
         + Dfs(i,j-1,rows,cols,grid,visited)
         + Dfs(i-1,j,rows,cols,grid,visited);
        return perimeter;
    }
}
public class Solution {
    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;
        
        int n = grid.Length;
        int m = grid[0].Length;
        int islands = 0;

        // 4-Directional coordinate deltas: Up, Down, Left, Right
        int[] delRow = { -1, 1, 0, 0 };
        int[] delCol = { 0, 0, -1, 1 };

        for (int row = 0; row < n; row++) {
            for (int col = 0; col < m; col++) {
                // When we hit an unvisited land island piece
                if (grid[row][col] == '1') {
                    islands++;
                    
                    // Trigger standard BFS 
                    System.Collections.Generic.Queue<(int r, int c)> queue = new System.Collections.Generic.Queue<(int, int)>();
                    grid[row][col] = '0'; // Space optimization: Mutating grid directly skips visited matrix allocation!
                    queue.Enqueue((row, col));

                    while (queue.Count > 0) {
                        var curr = queue.Dequeue();

                        for (int i = 0; i < 4; i++) {
                            int nrow = curr.r + delRow[i];
                            int ncol = curr.c + delCol[i];

                            // Validate boundary constraints and match active land values
                            if (nrow >= 0 && nrow < n && ncol >= 0 && ncol < m && grid[nrow][ncol] == '1') {
                                grid[nrow][ncol] = '0'; // Sink the island land piece to track visit safely
                                queue.Enqueue((nrow, ncol));
                            }
                        }
                    }
                }
            }
        }
        return islands;
        //PS some code was changed from striver's code! do keep this in mind
    }
}

public class Solution {
    public int NumIslands(char[][] grid) {
        /*
        make a set of tuple coordinates
        while set is not empty:
            pick a remaining coordinate
            if that coordinate is water (0) remove it
            if that coordinate is land (1) remove it and recursively remove
                the entire island and add +1 to number of islands

        to recursively remove the entire island, remove this coord from remaining set, then
        pick all adjacent (up,down,left,right) cells and do it to them if they are also 1s
        */
        int rows = grid.Length;
        int cols = grid[0].Length;

        bool[,] visited = new bool[rows, cols];
        int numIslands = 0;

        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < cols; col++) {
                if (!visited[row, col] && grid[row][col] == '1') {
                    MarkIsland(row, col, grid, visited);
                    numIslands++;
                }
            }
        }

        return numIslands;
    }

    void MarkIsland(int row, int col, char[][] grid, bool[,] visited) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        if (row < 0 || col < 0 || row >= rows || col >= cols)
            return;

        if (visited[row, col] || grid[row][col] == '0')
            return;

        visited[row, col] = true;

        MarkIsland(row + 1, col, grid, visited);
        MarkIsland(row - 1, col, grid, visited);
        MarkIsland(row, col + 1, grid, visited);
        MarkIsland(row, col - 1, grid, visited);
    }
}

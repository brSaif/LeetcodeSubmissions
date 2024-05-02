public class Solution {
    Queue<int[]> queue = new Queue<int[]>();
    int counter = 0;
    public int NumIslands(char[][] grid) {
        bool[,] visited = new bool[grid.Length, grid[0].Length];
        
        for(int i = 0; i < grid.Length; i++){
            for(int j = 0; j < grid[0].Length; j++){
                if (!visited[i,j] && grid[i][j] == '1'){
                    queue.Enqueue(new int[2]{i, j});
                    ShowIsland(grid, visited);
                }
            }
        }
        
        return counter;
    }
    public void ShowIsland(char[][] grid, bool[,] visited) {
        while(queue.Count > 0) {
            int[] coords = queue.Dequeue();
            if(!visited[coords[0],coords[1]]) {
                visited[coords[0],coords[1]] = true;
                if (coords[1] + 1 < grid[0].Length && !visited[coords[0],coords[1] + 1] && grid[coords[0]][coords[1] + 1] == '1') {
                    queue.Enqueue(new int[2]{coords[0], coords[1] + 1});
                }
                if (coords[1] - 1 >= 0 && !visited[coords[0],coords[1] - 1] && grid[coords[0]][coords[1] - 1] == '1') {
                    queue.Enqueue(new int[2]{coords[0], coords[1] - 1});
                }
                if (coords[0] - 1 >= 0 && !visited[coords[0] - 1,coords[1]] && grid[coords[0] - 1][coords[1]] == '1') {
                    queue.Enqueue(new int[2]{coords[0] - 1, coords[1]});
                }
                if (coords[0] + 1 < grid.Length && !visited[coords[0] + 1,coords[1]] && grid[coords[0] + 1][coords[1]] == '1') {
                    queue.Enqueue(new int[2]{coords[0] + 1, coords[1]});
                }
            }
        }
        counter += 1;
    }
}
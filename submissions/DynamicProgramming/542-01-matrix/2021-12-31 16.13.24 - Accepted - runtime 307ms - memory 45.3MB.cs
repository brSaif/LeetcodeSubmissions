public class Solution {
    public int[][] UpdateMatrix(int[][] matrix) {
    // Create a bool array -- visited same as input  
    int rows = matrix.Length;
	int columns = matrix[0].Length;
	bool[][] visited = new bool[rows][];
    for(int i =0 ; i < visited.Length; i++){
        visited[i] = new bool[columns];
    }   
        
	Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>();
	
     int[][] dirs = new int[4][];
     dirs[0] = new int[]{1, 0};
     dirs[1] = new int[]{-1, 0};
     dirs[2] = new int[]{0, 1};
     dirs[3] = new int[]{0, -1};
	
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Storing Coordinates of all zero's in queue 
                // marking them visited in visited array
                if(matrix[i][j] == 0){
                    queue.Enqueue(new Tuple<int,int>(i,j));
                    visited[i][j] = true;
                }
            }
        }
        
        while (queue.Any())
        {
            var top = queue.Dequeue();
            foreach (int[] dir in dirs)
            {
                int xx = top.Item1 + dir[0];
                int yy = top.Item2 + dir[1];
                if (xx >= 0 && xx < rows && yy >= 0 && yy < columns && !visited[xx][yy])
                {
                    matrix[xx][yy] = matrix[top.Item1][top.Item2]+1;
                    visited[xx][yy] = true;
                    queue.Enqueue(new Tuple<int,int>(xx, yy));
                }

            }
        }

        return matrix;
    }
}
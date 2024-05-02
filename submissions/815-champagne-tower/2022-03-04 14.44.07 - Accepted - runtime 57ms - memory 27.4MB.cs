public class Solution {
    public double ChampagneTower(int poured, int query_row, int query_gslass) {
        double[,] stock = new double[102, 102]; 
        stock[0,0] = (double) poured;
        for (int r = 0; r <= query_row; r++){
            for (int c = 0; c <= r; ++c){
                double q = (stock[r, c] - 1.0) / 2.0;
                if (q > 0){
                    stock[r + 1, c] += q;
                    stock[r + 1, c + 1] += q;
                }
            }
        }
        return Math.Min(1, stock[query_row, query_gslass]);
    }
}
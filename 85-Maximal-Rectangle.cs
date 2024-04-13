public class Solution {
    public int MaximalRectangle(char[][] matrix) {
        int rows= matrix.Length;
        int cols= matrix[0].Length;
        if(matrix == null || matrix.Length ==0 || matrix[0].Length==0){
            return 0;
        }
        int res= 0;
        int [] h= new int[cols];
        for(int row=0; row<rows; row++){
            for(int col=0; col<cols; col++ ){
                if(matrix[row][col] == '1'){
                    h[col]+=1;
                }else{
                    h[col]=0;
                }
            }
            int area= RecArea(h);
            res= Math.Max(res, area);
        }
        return res;

    }
    private int RecArea(int[] height){
        Stack<int> st= new Stack<int>();
        int res=0;
        int n= height.Length;
        for(int i=0; i<= n; i++){
            while(st.Count>0 && (i==n || height[st.Peek()] >= height[i])){
                int h=height[st.Pop()];
                int w= st.Count ==0 ? i : i- st.Peek()-1;
                res= Math.Max(res, h*w);
            }
            st.Push(i);
        }
        return res;
    }
}
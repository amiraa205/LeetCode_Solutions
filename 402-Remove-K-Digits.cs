public class Solution {
    public string RemoveKdigits(string num, int k) {
        Stack<char> stack= new Stack<char>();
        foreach(char n in num){
            while( k>0 && stack.Count>0 && stack.Peek() > n){
                k-=1;
                stack.Pop();
            }
            stack.Push(n);

        } 
        while(k>0 && stack.Count >0){
            stack.Pop();
            k--;
        }
        StringBuilder sb= new ();
        while(stack.Count >0 ) sb.Insert(0, stack.Pop());
        
        string res= sb.ToString().TrimStart('0');
        return res.Length> 0 ? res : \0\;
    }
}
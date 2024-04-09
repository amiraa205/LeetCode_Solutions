public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int target= tickets[k];
        int front=0;
        int back=0;
        int self=tickets[k];
        for(int i=0; i<k; i++){
            front += Math.Min(target, tickets[i]);
        }
        for(int i= k+1; i<tickets.Length; i++){
            back+= Math.Min(target-1, tickets[i]);
        }
        return front+ back+ self;
    }
}
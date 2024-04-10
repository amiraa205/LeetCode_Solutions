public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
        Array.Sort(deck);
        var list= new List<int> {deck[deck.Length-1] };
        for(var i= deck.Length -2; i>= 0; i--){
            list.Insert(0, deck[i]);
            list.Insert(1, list[list.Count-1]);
            list.RemoveAt(list.Count-1);
        }
        return list.ToArray();
    } 
}
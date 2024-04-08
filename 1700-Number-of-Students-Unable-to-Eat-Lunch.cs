public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int [] count= new int [2];
        foreach( int stu in students){
            count[stu]++;
        }
        foreach(int san in sandwiches){
            if(count[san] > 0) count[san]--;
            else
             break;
        }
        return count[0] + count[1];
    }
}
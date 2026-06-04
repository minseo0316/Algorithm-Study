using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        for(int a=0; a<k; a++){
            answer += my_string;
        }
        return answer;
        
    }
}
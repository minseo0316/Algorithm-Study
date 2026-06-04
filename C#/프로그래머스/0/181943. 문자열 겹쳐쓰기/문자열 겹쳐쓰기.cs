using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s){
       string before = my_string.Substring(0,s);
       string after = my_string.Substring(s + overwrite_string.Length);
        return before + overwrite_string + after;
    }
    }
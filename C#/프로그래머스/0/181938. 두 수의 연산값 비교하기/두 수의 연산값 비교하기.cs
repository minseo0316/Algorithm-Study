using System;

public class Solution {
    public int solution(int a, int b) {
        int ab = int.Parse($"{a}{b}");
        int mathValue = 2 * a * b;
        
        return Math.Max(ab, mathValue);
    }
}
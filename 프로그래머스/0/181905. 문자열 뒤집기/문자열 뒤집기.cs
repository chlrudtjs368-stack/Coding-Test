using System;

public class Solution {
    public string solution(string my_string, int s, int e) {
        
        string left = my_string.Substring(0, s);
        string mid = my_string.Substring(s, e - s + 1);
        string right = my_string.Substring(e + 1);
        
        char[] arr = mid.ToCharArray();
        Array.Reverse(arr);
        string reverseMid = new string(arr);
        
        return left + reverseMid + right;
    }
}
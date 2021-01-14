/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0) return false;
        string s = x.ToString();
        int l = 0;
        int t = s.Length - 1;
        while (l<t){
            if (s[l++] != s[t--]){
                return false;
            }
            
        }
        return true;
        
    }
}
// @lc code=end


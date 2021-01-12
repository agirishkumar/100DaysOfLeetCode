public class Solution {
    public int Reverse(int x) {
        int ret = 0;
        while(x !=0){
            int digit = x % 10 ;
            int temp = ret * 10;
            if (temp / 10 != ret)
            {
                return 0;
            }
            
            temp += digit;
            ret = temp;
            x = x / 10;
        }
        return ret;        
    }
}
﻿namespace MyMath;

    ///<summary>
    /// class for max integer
    ///</summary>
public class Operations
{
    ///<summary>
    /// This Method returns max integer in a list of integers
    ///</summary>
    public static int Max(List<int> vals) {

        if(vals.Count ==0){
            return 0;
        }
    
        int max = vals[0];
        for(int i=0; i<vals.Count; i++ ){
            if(vals[i]>max){
                max = nums[i];
            }
        }
        return max;  

    }   
}

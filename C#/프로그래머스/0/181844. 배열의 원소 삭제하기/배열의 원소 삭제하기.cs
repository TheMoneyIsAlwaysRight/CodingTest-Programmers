using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list)
    {
        List<int> arrList = arr.ToList<int>();
        List<int> deleteList = delete_list.ToList<int>();
        
        for(int x=0;x<deleteList.Count;x++)
        {
            if(arrList.Contains(deleteList[x]))
            {
                arrList.Remove(deleteList[x]);
            }
        }
        
        return arrList.ToArray();
    }
}
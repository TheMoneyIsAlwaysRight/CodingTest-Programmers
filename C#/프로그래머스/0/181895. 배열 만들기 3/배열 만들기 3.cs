using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals)
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        List<int> result = null;
        //intervals은 arr의 구간들을 의미하며 각각 인덱스 값이다.
        for(int x=intervals[0,0];x < intervals[0,1] + 1;x++)
        {
            list1.Add(arr[x]);
        }
        for(int x=intervals[1,0];x < intervals[1,1] + 1;x++)
        {
            list2.Add(arr[x]);
        }
        list1.AddRange(list2);
        
        return list1.ToArray();
    }
}
using System;

public class Solution
{
    public int solution(string myString, string pat) 
    {
        //pat이 myString보다 크다면 제외.
        if(myString.Length < pat.Length) { return 0; }

        //대소문자 구분 안하므로, 모두 소문자화시켜 통일.
        string lowMy = myString.ToLower();
        string lowPat = pat.ToLower();

        bool isClear = false;
        
        for (int x = 0; x < lowMy.Length; x++)
        {
            //myString 순회중에 pat의 첫번째 문자를 찾았다면
            if (lowMy[x] == lowPat[0])
            {
                //인덱스 x에서 시작한 pat의자열 길이가, Mystring의 배열의 끝을 능가할 경우 제외.
                if((lowMy.Length- 1) - (x+lowPat.Length -1) < 0) { break; }

                for (int y = 0; y < lowPat.Length; y++)
                {
                    isClear = true;
                    if (lowMy[x + y] != lowPat[y])
                    {
                        isClear = false;
                        break;
                    } 
                }
                if (isClear){return 1;}
            }
        }
        return 0;
    }
}
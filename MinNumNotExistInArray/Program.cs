var data = new int[] { 1, 3, 6, 4, 1, 2 };
var s = new MinNumNotExistInArray.Solution().solution(data);
Console.WriteLine(s);

namespace MinNumNotExistInArray
{
    public class Solution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            var result = 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (A[i] > result)
                        return result;
                    else if (A[i] == result)
                        result++;
                }
            }
            return result;
        }
    }
}
namespace MinNumNotExistInArrayTests;

public class Test
{
    [Theory]
    [InlineData(new[] { 1, 3, 6, 4, 1, 2 }, 5)]
    [InlineData(new[] { 1, 3, 2 }, 4)]
    [InlineData(new[] { -1, -3 }, 1)]
    public void Test1(int[] data, int result)
    {
        Assert.Equal(result, new Solution().solution(data));
    }
}

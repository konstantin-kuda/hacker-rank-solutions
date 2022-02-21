namespace HackerRank.Solutions.InterviewPreparationKit;

public class Arrays
{
    //https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    public static int HourglassSum(List<List<int>> arr)
    {
        var columnCount = arr[0].Count;
        for (var i = 1; i < arr.Count; i++)
        {
            if (arr[i].Count != columnCount)
            {
                throw new Exception($"Invalid array: Row should have {columnCount} columns but has {arr[i].Count}");
            }
        }

        var max = 0;
        for (var rowIndex = 1; rowIndex < arr.Count - 1; rowIndex++)
        {
            for (var columnIndex = 1; columnIndex < columnCount - 1; columnIndex++)
            {
                var previousRow = arr[rowIndex - 1];
                var nextRow = arr[rowIndex + 1];
                
                var count = previousRow[columnIndex - 1] + previousRow[columnIndex] + previousRow[columnIndex + 1] +
                            arr[rowIndex][columnIndex] +
                            nextRow[columnIndex - 1] + nextRow[columnIndex] + nextRow[columnIndex + 1];

                if (count > max)
                {
                    max = count;
                }
                else if (rowIndex == 1 && columnIndex == 1)
                {
                    max = count;
                }
            }
        }
        return max;
    }
    
    //https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    public static List<int> RotateLeft(List<int> a, int d)
    {
        if (d == a.Count || d == 0)
        {
            return a;
        }

        var n = a.Count;
        var result = new List<int>();

        if (d > n)
        {
            d = n % d;
        }

        for (var i = 0; i < n; i++)
        {
            result.Add(
                i + d < n
                    ? a[i + d] 
                    : a[i + d - n]
            );
        }

        return result;
    }
    
    //https://www.hackerrank.com/challenges/new-year-chaos/problem
    public static int MinimumBribes(List<int> q)
    {
        var result = 0;
        for (var i = q.Count - 1; i >= 0; i--) 
        {
            var realValue = q[i];
            var expectedValue = i + 1;
            
            if (realValue - expectedValue > 2) 
            {
                return - 1;
            }

            var max = new[] { 0, realValue - 2 }.Max();
            for (var j = max; j < i; j++)
            {
                if (q[j] > realValue)
                {
                    result++;
                }
            }
        }
        return result;
    }
}
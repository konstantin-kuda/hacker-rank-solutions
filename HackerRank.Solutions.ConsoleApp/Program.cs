//var a = JumpingOnClouds(new List<int> { 0, 0, 1, 0, 0, 1, 0 });
//var a = JumpingOnClouds(new List<int> { 0, 0, 0, 1, 0, 0 });

/*
* The function is expected to return an INTEGER.
* The function accepts INTEGER_ARRAY c as parameter.
*/
static int JumpingOnClouds(List<int> c)
{
    var counter = 0;

    int toAdd;
    for (var i = 0; i < c.Count - 1; i += toAdd)
    {
        Console.Write(i);
        if (i + 2 <= c.Count - 1 && c[i + 2] == 0)
        {
            counter++;
            toAdd = 2;
        }
        else if (i + 1 <= c.Count - 1 && c[i + 1] == 0)
        {
            counter++;
            toAdd = 1;
        }
        else
        {
            throw new Exception("cannot be calculated");
        }
    }
    return counter;
}

//------------------------------------------------------------------------------------------------------------------------

//var a = RepeatedString("aba", 10);
//var a = RepeatedString("a", 1000000000000);

static long RepeatedString(string s, long n)
{
    var times = n / s.Length;
    var rest = n % s.Length;

    var numberInString = 0;
    var numberInRestString = 0;
    for (var i = 0; i < s.Length; i++)
    {
        if (s[i] == 'a')
        {
            numberInString++;
            if (i <= rest - 1)
            {
                numberInRestString++;
            }
        }
    }

    return times * numberInString + numberInRestString;
}

//------------------------------------------------------------------------------------------------------------------------

//var a = CountingValleys(8, "UDDDUDUU");
//var a = CountingValleys(8, "UDDDUDUU");

/*
* The function is expected to return an INTEGER.
* The function accepts following parameters:
*  1. INTEGER steps
*  2. STRING path
*/
static int CountingValleys(int steps, string path)
{
    var count = 0;
    
    int currentLevel = 0;
    int previousLevel;

    for (var i = 0; i < steps; i++)
    {
        previousLevel = currentLevel;
        
        if (path[i] == 'U')
        {
            currentLevel = previousLevel + 1;
        }
        else if (path[i] == 'D')
        {
            currentLevel = previousLevel - 1;
        }
        else
        {
            throw new Exception("Wrong argument: Position" + i);
        }

        if (currentLevel < 0 && previousLevel == 0)
        {
            count++;
        }
    }

    return count;
}

//------------------------------------------------------------------------------------------------------------------------

// var a = HourglassSum(
//     new List<List<int>>
//     {
//         new() {1, 1, 1, 0, 0, 0},
//         new() {0, 1, 0, 0, 0, 0},
//         new() {0, 1, 0, 0, 0, 0},
//         new() {0, 0, 2, 4, 4, 0},
//         new() {0, 0, 0, 2, 0, 0},
//         new() {0, 0, 1, 2, 4, 0}
//     }    
// );

// var a = HourglassSum(
//     new List<List<int>>
//     {
//         new() {-9, -9, -9,  1,  1,  1},
//         new() { 0, -9,  0,  4,  3,  2},
//         new() {-9, -9, -9,  1,  2,  3},
//         new() { 0,  0,  8,  6,  6,  0},
//         new() { 0,  0,  0, -2,  0,  0},
//         new() { 0,  0,  1,  2,  4,  0}
//     }    
// );

// var a = HourglassSum(
//     new List<List<int>>
//     {
//         new() { 0, -4, -6,  0, -7, -6},
//         new() {-1, -2, -6, -8, -3, -1},
//         new() {-8, -4, -2, -8, -8, -6},
//         new() {-3, -1, -2, -5, -7, -4},
//         new() {-3, -5, -3, -6, -6, -6},
//         new() {-3, -6,  0, -8, -6, -7}
//     }    
// );

/*
* The function is expected to return an INTEGER.
* The function accepts 2D_INTEGER_ARRAY arr as parameter.
*/
static int HourglassSum(List<List<int>> arr)
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

//------------------------------------------------------------------------------------------------------------------------

var a = GetMoneySpent(
    new []{3, 1}, new []{5, 2, 8}, 10
);

/*
 * Practice>Algorithms>Implementation>Electronics Shop 
*/
static int GetMoneySpent(int[] keyboards, int[] drives, int b)
{
    var keyboardsOrderedDesc = keyboards
        .OrderByDescending(x => x)
        .ToArray();
    
    var drivesOrderedAsc = drives
        .OrderBy(x => x)
        .ToArray();

    var res = -1;

    var j = 0;
    for (int i = 0; i < keyboardsOrderedDesc.Length; i++)
    {
        for (; j < drivesOrderedAsc.Length; j++)
        {
            var sum = keyboardsOrderedDesc[i] + drivesOrderedAsc[j];
            if (sum > b)
            {
                break;
            }

            if (sum > res)
            {
                res = sum;
            }
        }
    }

    return res;
}

//------------------------------------------------------------------------------------------------------------------------

Console.WriteLine(a);
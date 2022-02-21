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
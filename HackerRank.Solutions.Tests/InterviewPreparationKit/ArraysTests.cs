namespace HackerRank.Solutions.Tests.InterviewPreparationKit;

[TestFixture]
public class ArraysTests
{
    [Test]
    public void HourglassSum_Should_ReturnProperValue_1()
    {
        var input = new List<List<int>>
        {
            new() { 1, 1, 1, 0, 0, 0 },
            new() { 0, 1, 0, 0, 0, 0 },
            new() { 0, 1, 0, 0, 0, 0 },
            new() { 0, 0, 2, 4, 4, 0 },
            new() { 0, 0, 0, 2, 0, 0 },
            new() { 0, 0, 1, 2, 4, 0 }
        };
        var result = Arrays.HourglassSum(input);
        result.Should().Be(19);
    }
    
    [Test]
    public void HourglassSum_Should_ReturnProperValue_2()
    {
        var input = new List<List<int>>
        {
            new() {-9, -9, -9,  1,  1,  1},
            new() { 0, -9,  0,  4,  3,  2},
            new() {-9, -9, -9,  1,  2,  3},
            new() { 0,  0,  8,  6,  6,  0},
            new() { 0,  0,  0, -2,  0,  0},
            new() { 0,  0,  1,  2,  4,  0}
        };
        var result = Arrays.HourglassSum(input);
        result.Should().Be(28);
    }
    
    [Test]
    public void HourglassSum_Should_ReturnProperValue_3()
    {
        var input = new List<List<int>>
        {
            new() { 0, -4, -6, 0, -7, -6 },
            new() { -1, -2, -6, -8, -3, -1 },
            new() { -8, -4, -2, -8, -8, -6 },
            new() { -3, -1, -2, -5, -7, -4 },
            new() { -3, -5, -3, -6, -6, -6 },
            new() { -3, -6, 0, -8, -6, -7 }
        };
        var result = Arrays.HourglassSum(input);
        result.Should().Be(-19);
    }

    [Test]
    public void RotateLeft_Should_ReturnProperValue_1()
    {
        var inputArray = new List<int> { 1, 2, 3, 4, 5 };
        var outputArray = Arrays.RotateLeft(inputArray, 4);
        outputArray.Should().Equal(new List<int>{5, 1, 2, 3, 4});
    }

    [Test]
    public void RotateLeft_Should_ReturnProperValue_2()
    {
        var inputArray = new List<int> { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51};
        var outputArray = Arrays.RotateLeft(inputArray, 10);
        outputArray.Should().Equal(new List<int>{77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77});
    }
    
    [Test]
    public void RotateLeft_Should_ReturnProperValue_3()
    {
        var inputArray = new List<int> { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97};
        var outputArray = Arrays.RotateLeft(inputArray, 13);
        outputArray.Should().Equal(new List<int>{87, 97, 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60});
    }
    
    [Test]
    public void RotateLeft_Should_ReturnSameArray_WhenZeroPassed()
    {
        var inputArray = new List<int> { 1, 2, 3, 4, 5 };
        var outputArray = Arrays.RotateLeft(inputArray, 0);
        outputArray.Should().Equal(inputArray);
    }
    
    [Test]
    public void RotateLeft_Should_ReturnSameArray_WhenNumberOfEntriesInArrayPassed()
    {
        var inputArray = new List<int> { 1, 2, 3, 4, 5 };
        var outputArray = Arrays.RotateLeft(inputArray, inputArray.Count);
        outputArray.Should().Equal(inputArray);
    }
    
    [Test]
    public void MinimumBribes_Should_ReturnProperValue1()
    {
        var inputArray = new List<int> { 2, 1, 5, 3, 4};
        var result = Arrays.MinimumBribes(inputArray);
        result.Should().Be(3);
    }
    
    [Test]
    public void MinimumBribes_Should_ReturnProperValue2()
    {
        var inputArray = new List<int> { 2, 5, 1, 3, 4};
        var result = Arrays.MinimumBribes(inputArray);
        result.Should().Be(-1);
    }
    
    [Test]
    public void MinimumBribes_Should_ReturnProperValue3()
    {
        var inputArray = new List<int> { 1, 2, 5, 3, 7, 8, 6, 4};
        var result = Arrays.MinimumBribes(inputArray);
        result.Should().Be(7);
    }
    
    [Test]
    public void MinimumBribes_Should_ReturnProperValue4()
    {
        var inputArray = new List<int> { 1, 2, 5, 3, 4, 7, 8, 6};
        var result = Arrays.MinimumBribes(inputArray);
        result.Should().Be(4);
    }

    [Test]
    public void MinimumBribes_Should_ReturnProperValue5()
    {
        var inputArray = new List<int> { 1, 2, 5, 3, 7, 8, 6, 4};
        var result = Arrays.MinimumBribes(inputArray);
        result.Should().Be(7);
    }

    [Test]
    public void MinimumBribes_Should_ReturnWrongValue1()
    {
        var inputArray = new List<int> { 5, 1, 2, 3, 7, 8, 6, 4};
        var result = Arrays.MinimumBribes(inputArray);
        result.Should().Be(-1);
    }
}
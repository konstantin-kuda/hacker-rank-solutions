using System.Linq;

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
    
    [TestCase("2,1,5,3,4", 3)]
    [TestCase("2,5,1,3,4", -1)]
    [TestCase("1,2,5,3,7,8,6,4", 7)]
    [TestCase("1,2,5,3,4,7,8,6", 4)]
    [TestCase("1,2,5,3,7,8,6,4", 7)]
    [TestCase("5,1,2,3,7,8,6,4", -1)]
    public void MinimumBribes_ShouldMatch(string arrayString, int expectedResult)
    {
        var inputArray = arrayString.Split(new[] { ',' }).Select(int.Parse).ToList();
        var result = Arrays.MinimumBribes(inputArray);
        result.Should().Be(expectedResult);
    }

    [TestCase("4,3,1,2", 3)]
    [TestCase("2,3,4,1,5", 3)]
    [TestCase("1,3,5,2,4,6,7", 3)]
    public void MinimumSwaps_ShouldMatch(string arrayString, int expectedResult)
    {
        var result1 = Arrays.MinimumSwaps(
            arrayString.Split(new[] { ',' }).Select(int.Parse).ToArray()    
        );
        result1.Should().Be(expectedResult);
        
        var result2 = Arrays.MinimumSwaps2(
            arrayString.Split(new[] { ',' }).Select(int.Parse).ToArray()
        );
        result2.Should().Be(expectedResult);
    }
}
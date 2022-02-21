using System.Collections.Generic;
using FluentAssertions;
using HackerRank.Solutions.InterviewPreparationKit;
using NUnit.Framework;

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
}
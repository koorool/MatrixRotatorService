using System;
using FluentAssertions;
using Xunit;

namespace MatrixRotatorService.Tests
{
    public class MatrixServiceTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(10_000)]
        public void CanRotateMatrix(int n)
        {
            var testData = new int[n][];
            var mainDiag = new int[n];

            var rand = new Random();
            for (var i = 0; i < n; i++)
            {
                testData[i] = new int[n];
                for (var j = 0; j < n; j++)
                {
                    testData[i][j] = rand.Next(1, 99);
                    if (i == j)
                        mainDiag[i] = testData[i][j];
                }
            }

            testData.RotateRight();

            for (var i = 0; i < n; i++)
                testData[i][n - i - 1].Should().Be(mainDiag[i]);
        }
    }
}
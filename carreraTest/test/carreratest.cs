using System;
using System.Collections.Generic;
using Xunit;

public class CarreraTests
{
    [Fact]
    public void CalcularDistancies_ValidCorredors_ReturnsCorrectDistances()
    {
        // Arrange
        var corredors = new List<int[]>
        {
            new int[] {1, 5, 1, 9, 3},
            new int[] {2, 7, 5, 3, 4},
            new int[] {3, 2, 4, 6, 8},
            new int[] {1, 3, 2, 7, 4},
            new int[] {2, 2, 4, 6, 4},
            new int[] {3, 6, 1, 6, 8},
            new int[] {1, 6, 9, 5, 7},
            new int[] {2, 1, 4, 2, 5},
            new int[] {3, 3, 4, 8, 8}
        };

        // Expected result
        var expected = new Dictionary<int, int>
        {
            {1, 22},
            {2, 12},
            {3, 21}
        };

        // Act
        var result = Carrera.CalcularDistancies(corredors);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalcularDistancies_EmptyCorredors_ReturnsEmptyDictionary()
    {
        // Arrange
        var corredors = new List<int[]>();

        // Act
        var result = Carrera.CalcularDistancies(corredors);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void CalcularDistancies_SingleCorredor_ReturnsCorrectDistance()
    {
        // Arrange
        var corredors = new List<int[]>
        {
            new int[] {1, 10, 5, 15}
        };

        // Expected result
        var expected = new Dictionary<int, int>
        {
            {1, 10}
        };

        // Act
        var result = Carrera.CalcularDistancies(corredors);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalcularDistancies_NegativeValues_ReturnsCorrectDistance()
    {
        // Arrange
        var corredors = new List<int[]>
        {
            new int[] {1, -10, -20, -5, -15}
        };

        // Expected result
        var expected = new Dictionary<int, int>
        {
            {1, 15}
        };

        // Act
        var result = Carrera.CalcularDistancies(corredors);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalcularDistancies_DuplicateIds_AccumulatesDistances()
    {
        // Arrange
        var corredors = new List<int[]>
        {
            new int[] {1, 5, 10},
            new int[] {1, 15, 20}
        };

        // Expected result
        var expected = new Dictionary<int, int>
        {
            {1, 20}
        };

        // Act
        var result = Carrera.CalcularDistancies(corredors);

        // Assert
        Assert.Equal(expected, result);
    }
}

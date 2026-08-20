namespace JLib.Tools;

/// <summary>
/// Provides basic mathematical operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The sum of the two numbers.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Multiplies two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The product of the two numbers.</returns>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Calculates the total of a collection of numbers.
    /// </summary>
    /// <param name="numbers">The numbers to total.</param>
    /// <returns>The sum of all supplied numbers.</returns>
    public int Total(IEnumerable<int> numbers)
    {
        return numbers.Sum();
    }
}
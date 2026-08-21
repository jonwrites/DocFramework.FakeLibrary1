namespace JLib.Tools;

/// <summary>
/// Provides basic mathematical operations.
/// </summary>
public interface ICalculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The sum of the two numbers.</returns>
    int Add(int a, int b);

    /// <summary>
    /// Multiplies two numbers together.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The product of the two numbers.</returns>
    int Multiply(int a, int b);

    /// <summary>
    /// Calculates the total of a collection of numbers.
    /// </summary>
    /// <param name="numbers">The numbers to total.</param>
    /// <returns>The sum of all supplied numbers.</returns>
    int Total(IEnumerable<int> numbers);
}
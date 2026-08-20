namespace JLib.Tools;

/// <summary>
/// Provides operations for transforming text.
/// </summary>
public class TextTransformer
{
    /// <summary>
    /// Converts text to uppercase.
    /// </summary>
    /// <param name="text">The text to transform.</param>
    /// <returns>The supplied text converted to uppercase.</returns>
    public string ToUpper(string text)
    {
        return text.ToUpperInvariant();
    }


}
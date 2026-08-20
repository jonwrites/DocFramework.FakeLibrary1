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

    /// <summary>
    /// Emphasises text by placing an asterisk between each character.
    /// </summary>
    /// <param name="text">The text to transform.</param>
    /// <returns>The transformed text with asterisks between characters.</returns>
    public string Emphasise(string text)
    {
        return string.Join("*", text.ToCharArray());
    }
}
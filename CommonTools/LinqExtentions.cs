namespace CommonTools;

public static class LinqExtentions
{
    public static string ToDelimitedString<T>(this IEnumerable<T> source, string delimiter = "")
    {
        return string.Join(delimiter, source);
    }

    public static IEnumerable<IEnumerable<T>> Tails<T>(this IEnumerable<T> source)
    {
        for (var i = 0; i < source.Count(); i++)
        {
            yield return source.Skip(i);
        }
    }

    public static IEnumerable<string> Tails(this string source)
    {
        for (var i = 0; i < source.Count(); i++)
        {
            yield return source.Substring(i);
        }
    }

    public static IEnumerable<IEnumerable<T>> ReverseTails<T>(this IEnumerable<T> source)
    {
        for (var i = source.Count() - 1; 0 <= i  ; i--)
        {
            yield return source.Skip(i);
        }
    }

    public static IEnumerable<string> ReverseTails(this string source)
    {
        for (var i = source.Count() - 1; 0 <= i  ; i--)
        {
            yield return source.Substring(i);
        }
    }
}
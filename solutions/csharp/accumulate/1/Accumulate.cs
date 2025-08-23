public static class AccumulateExtensions
{
    public static IEnumerable<TResult> Accumulate<TSource, TResult>(
        this IEnumerable<TSource> source,
        Func<TSource, TResult> operation)
    {
        foreach (var item in source)
        {
            yield return operation(item);
        }
    }
}

namespace ExeciseOop.ExtentionMethod;
internal static class ExtMethod
{
    public static void ChangColor<T>(this T obj, params ConsoleColor[] items)
    {
        Console.BackgroundColor = items[0];
        Console.ForegroundColor = items[1];
    }

    public static bool In<T>(this T obj, params T[] items)
    {
        return items.Contains(obj);
    }
}

﻿namespace ExeciseOop.ExtentionMethod;
internal static class ExtMethod
{
    public static void ChangColor<T>(this T item, params ConsoleColor[] items)
    {
        Console.BackgroundColor = items[0];
        Console.ForegroundColor = items[1];
    }
}

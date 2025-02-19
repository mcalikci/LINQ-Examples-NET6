﻿namespace LINQ_Examples_NET6.Samples;
public class MinExample
{
    public int Sample1()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Min();
        //  result = 1
        return result;
    }

    public int Sample2()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Min(x => x + 1);
        //  result = 2
        return result;
    }

    public string Sample3()
    {
        var letters = new List<string>() { "A", "C", "d", "B", "a" };
        var result = letters.Min(x => x + 1);
        //  result = "a1"
        return result;
    }

    public string Sample4()
    {
        var letters = new List<string>() { "A", "C", "d", "B", "a" };
        var result = letters.Min(StringComparer.OrdinalIgnoreCase);
        //  result = "A"
        return result;
    }
}
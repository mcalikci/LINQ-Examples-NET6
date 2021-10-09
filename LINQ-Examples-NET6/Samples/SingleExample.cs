﻿namespace LINQ_Examples_NET6.Samples;
public class SingleExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Single();
        // throws InvalidOperationException: "Sequence contains more than one element"
    }

    public void Sample2()
    {
        var colors = new List<string>();
        var result = colors.Single();
        // throws InvalidOperationException: "Sequence contains no elements"
    }

    public string Sample3()
    {
        var colors = new List<string>() { "Blue" };
        var result = colors.Single();
        //  result = "Blue"
        return result;
    }

    public void Sample4()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Single(x => x.Length > 3);
        // throws InvalidOperationException: "Sequence contains more than one element"
    }

    public void Sample5()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Single(x => x.Length > 7);
        // throws InvalidOperationException: "Sequence contains no elements"
    }

    public string Sample6()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Single(x => x.Length == 3);
        //  result = "Red"
        return result;
    }
}
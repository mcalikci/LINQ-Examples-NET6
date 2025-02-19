﻿using LINQ_Examples_NET6.Comparer;
using LINQ_Examples_NET6.Models;

namespace LINQ_Examples_NET6.Samples;
public class OrderByExample
{
    public IOrderedEnumerable<Pet> Sample1()
    {
        var barley = new Pet("Barley", "Terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var pets = new List<Pet> { barley, boots, whiskers, daisy };
        var result = pets.OrderBy(x => x.Name);
        //  result = IEnumerable<Pet> { [
        //  { Name = "Barley", Owner = "Terry"},
        //  { Name = "Boots", Owner = "Terry"},
        //  { Name = "Daisy", Owner = "Magnus"},
        //  { Name = "Whiskers", Owner = "Charlotte"}
        //  ] },
        return result;
    }

    public IOrderedEnumerable<Pet> Sample2()
    {
        var barley = new Pet("Barley", "Terry");
        var boots = new Pet("Boots", "Terry");
        var whiskers = new Pet("Whiskers", "Charlotte");
        var daisy = new Pet("Daisy", "Magnus");

        var pets = new List<Pet> { barley, boots, whiskers, daisy };
        var result = pets.OrderBy(x => x.Name, new LengthComparer());
        //  result = IEnumerable<Pet> { [
        //  { Name = "Boots", Owner = "Terry"},
        //  { Name = "Daisy", Owner = "Magnus"},
        //  { Name = "Barley", Owner = "Terry"},
        //  { Name = "Whiskers", Owner = "Charlotte"}
        //  ] }
        return result;
    }
}
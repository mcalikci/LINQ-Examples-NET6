﻿using LINQ_Examples_NET6.Comparer;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class DistinctExample
    {
        public void Sample1()
        {
            var numbers = new List<int>() { 1, 2, 2, 4, 1, 5 };
            var result = numbers.Distinct();
            //  result = IEnumerable<int> { 1, 2, 4, 5 }
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "RED", "Blue", "Black", "BluE" };
            var result = colors.Distinct(new IgnoreCaseComparer());
            //  result = IEnumerable<string> { "Red", "Blue", "Black" }
        }
    }
}

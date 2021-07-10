﻿using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class FirstExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.First();
            //  result = "Red"
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.First(x => x.Length > 4);
            //  result = "Green"
        }
    }
}

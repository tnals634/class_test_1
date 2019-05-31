﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_test_1
{
    public static class ShapeMath
    {
        public static double GetArea(string shape = "", double length1 = 0, double length2 = 2)
        {
            if(string.Equals("Rectangle",shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if(string.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2 / 2;
            }
            else if(string.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return Math.PI * Math.Pow(length1, 2);
            }
            return 0;
        }
    }
}

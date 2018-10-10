using System;
using System.Collections.Generic;
using System.Text;

namespace WeightConverter
{
    public static class MyConverter
    {
        public static double GramsToOunces(double n) {return n * 0.035274; }
        public static double OuncesToGrams(double n) { return n / 0.035274; }
    }
}

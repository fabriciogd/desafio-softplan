using System;

namespace Application.Helpers
{
    public static class MathHelpers
    {
        public static double Truncate(double value, int precision)
        {
            return Math.Truncate(value * Math.Pow(10, precision)) / Math.Pow(10, precision);
        }
    }
}

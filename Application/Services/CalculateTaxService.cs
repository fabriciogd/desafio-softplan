using Application.Helpers;
using Application.Interfaces;
using System;

namespace Application.Services
{
    public class CalculateTaxService: ICalculateTaxService
    {
        public double CalculateTax(double value, int months, double tax)
        {
            value = value * Math.Pow((1 + tax), months);

            var finalValue = MathHelpers.Truncate(value, 2);

            return finalValue;
        }

    }
}

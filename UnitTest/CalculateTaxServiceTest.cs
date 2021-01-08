using Application.Services;
using System;
using Xunit;

namespace UnitTest
{
    public class CalculateTaxServiceTest
    {
        [Fact]
        public void Call_Calculate_Tax_ShouldReturn_CorrectValue()
        {
            var calculateTaxService = new CalculateTaxService();

            double initialValue = 100;
            int months = 5;
            double tax = 0.01;

            var finalValue = calculateTaxService.CalculateTax(initialValue, months, tax);
            double correctFinalValue = 105.1;

            Assert.Equal(correctFinalValue, finalValue);
        }
    }
}

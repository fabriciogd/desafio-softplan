using Application.Interfaces;

namespace Application.Services
{
    public class TaxService: ITaxService
    {
        private const double _tax = 0.01;

        public double GetTax()
        {
            return _tax;
        }
    }
}

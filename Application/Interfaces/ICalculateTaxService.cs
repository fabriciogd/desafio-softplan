namespace Application.Interfaces
{
    public interface ICalculateTaxService
    {
        double CalculateTax(double value, int months, double tax);
    }
}

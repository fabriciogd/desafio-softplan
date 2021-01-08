using Application.Interfaces;
using CrossCutting.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace SecondApi.Controllers
{
    [ApiController]
    [Route("calculajuros")]
    public class CalculateTaxController : ControllerBase
    {
        private readonly ICalculateTaxService _calculateTaxService;
        private readonly IExternalApiService _externalApiService;

        public CalculateTaxController(ICalculateTaxService calculateTaxService, IExternalApiService externalApiService)
        {
            _calculateTaxService = calculateTaxService;
            _externalApiService = externalApiService;
        }

        [HttpPost]
        public async Task<double> Post([FromQuery]double valorInicial, [FromQuery]int meses)
        {
            double tax = await _externalApiService.GetExternalResponseAsync<double>("taxajuros");

            double finalValue = _calculateTaxService.CalculateTax(valorInicial, meses, tax);

            return finalValue;
        }
    }
}

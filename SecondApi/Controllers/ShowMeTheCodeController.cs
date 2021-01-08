using Microsoft.AspNetCore.Mvc;

namespace SecondApi.Controllers
{
    [ApiController]
    [Route("showmethecode")]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string url = "https://github.com/fabriciogd/desafio-softplan";

            return url;
        }
    }
}
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JurosApi.Controllers
{
    [Route("showmethecode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        // GET: api/<ShowMeTheCodeController>
        [HttpGet]
        public string Get()
        {
            return "https://github.com/robson-jsouza/juros-api";
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace webapiCalculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {

        }

        [Route("Add")]
        [HttpPost]
        public int Add([FromHeader]int a, [FromHeader] int b, int c)
        {
            return a + b;
        }

        [Route("Add")]
        [HttpGet]
        public int Add(int a, int b)
        {
            return a + b;
        }

        [Route("Multiply")]
        [HttpPost]
        public int Multiply([FromHeader]int a, [FromHeader] int b, int c)
        {
            return a * b;
        }

        [Route("Multiply")]
        [HttpGet]
        public int Multiply(int a, int b)
        {
            return a * b;
        }


    }
}
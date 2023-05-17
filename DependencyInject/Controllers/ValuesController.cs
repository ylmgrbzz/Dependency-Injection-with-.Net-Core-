using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInject.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly NumGenerator _numGenerator;

        public ValuesController(NumGenerator numGenerator)
        {
            _numGenerator = numGenerator;
        }

        [HttpGet]
        public string Get()
        {
            int number = _numGenerator.GetNumber();
            return $"Number: {number}";
        }
    }
}

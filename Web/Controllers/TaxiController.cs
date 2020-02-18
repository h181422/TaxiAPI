using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TaxiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxiController : ControllerBase
    {
        // GET
        [HttpGet]
        public async Task<ActionResult> Read()
        {
            throw new NotImplementedException();
        }

    }
}

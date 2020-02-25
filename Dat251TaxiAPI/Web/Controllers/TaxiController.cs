using System;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace TaxiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxiController : ControllerBase
    {

        private readonly IMaps _maps;
        public TaxiController(IMaps maps)
        {
            _maps = maps;
        }
        
        
        [HttpGet("fagOgGruppenummer")]
        public async Task<string> GetFagOgGruppenummer()
        {
            return await _maps.GetFagOgGruppeNummer();
        }

    }
}

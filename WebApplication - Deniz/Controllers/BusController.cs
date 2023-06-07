using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication___Deniz.Model.Arac;
using WebApplication___Deniz.Model.Insan;
using WebApplication___Deniz.Services;

namespace WebApplication___Deniz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {

        private readonly IBusGenerator _busGenerator;
        private readonly IMoneyGenerator _moneyGenerator;
        public BusController(IBusGenerator busGenerator,IMoneyGenerator moneyGenerator)
        {
            _busGenerator = busGenerator;
            _moneyGenerator = moneyGenerator;
        }

        [Route("utubus/{value}/{gok}")]
        [HttpGet]
        public IActionResult Utubus(int value,string gok)
        {
            Bus otobus = _busGenerator.SetBus(BusType.metrobus);
            Hoca hocam = new Hoca();
            hocam.ucret = value;
            _moneyGenerator.Calculate(otobus, hocam);
            return Ok(otobus.GetTarife());
        }
    }
}

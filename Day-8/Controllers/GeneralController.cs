using Day_8.Services.DatabaseConn;
using Day_8.Services.HttpDurums;
using Day_8.Services.Logger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly ILoggerCustom _logger;
        private readonly IDbConn _dbConn;
        private readonly IHttpDurums _httpDurums;
        public GeneralController(ILoggerCustom logger,IDbConn dbConn,IHttpDurums httpDurums)
        {
            _logger = logger;
            _dbConn = dbConn;
            _httpDurums = httpDurums;
        }
        [HttpGet]
        public IActionResult GetGeneralDurum()
        {
            _logger.Log("calist");
            return Ok(_dbConn.Open());
        }
    }
}

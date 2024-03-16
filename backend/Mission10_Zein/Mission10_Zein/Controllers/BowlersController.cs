using Microsoft.AspNetCore.Mvc;
using Mission10_Zein.Data;
using Mission10_Zein.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Mission10_Zein.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlerRepository _bowlingRepository;

        public BowlersController(IBowlerRepository temp)
        {
            _bowlingRepository = temp;
        }

        //Endpoint that is called by the front end
        [HttpGet(Name = "Bowling")]
        public IEnumerable<Bowler> Get()
        {
            //retrieving bowler data, filtering by TeamId
            var bowlerData = _bowlingRepository.Bowlers.Where(x => x.TeamId is 1 or 2).ToArray();

            return bowlerData;
        }
       
    }
}

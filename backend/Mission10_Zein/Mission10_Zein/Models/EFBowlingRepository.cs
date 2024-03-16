using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mission10_Zein.Data;
using Mission10_Zein.Models;

namespace Mission10_Zein.Models
{
    public class EFBowlingRepository : IBowlerRepository
    {
        private BowlingLeagueContext _bowlingcontext;
        public EFBowlingRepository(BowlingLeagueContext temp)
        {
            _bowlingcontext = temp;
        }

        //get all bowlers from the database
        public IEnumerable<Bowler> Bowlers => _bowlingcontext.Bowlers;
        public IEnumerable<Team> Teams => _bowlingcontext.Teams;

    }
}
using Mission10_Zein.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission10_Zein.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }


    }
}

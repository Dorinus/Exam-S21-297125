using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public interface ITeamManager
    {
        Task<bool> CreateTeam(Team team);
        Task<IList<Team>> GetTeams(int ranking, String teamName);
    }
}
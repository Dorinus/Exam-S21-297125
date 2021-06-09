using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication.DataAcces;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamController : ControllerBase
    {
        private FootballDBContext FootballDbContext;

        public TeamController()
        {
            FootballDbContext = new FootballDBContext();
        }

        [HttpPost]
        [Route("/team")]
        public async Task<bool> AddTeam([FromBody] Team team)
        {
            Console.WriteLine("Got a new team to add " + team.TeamName);

            try
            {
                await FootballDbContext.Teams.AddAsync(team);
                await FootballDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        [HttpGet]
        [Route("/team/")]
        public async Task<IList<Team>> GetTeams([FromQuery] int? ranking, [FromQuery] String? teamName)
        {
            try
            {
                // if ((ranking != null || !(ranking < 1)) && !String.IsNullOrEmpty(teamName))
                // {
                //     IList<Team> authors = await FootballDbContext.Teams.Include(t => t.Players)
                //         .Where(team => team.TeamName.Equals(teamName) && team.Ranking <= ranking).ToListAsync();
                //     return authors;
                // }
                // else if ((ranking == null || ranking < 1 )&& !String.IsNullOrEmpty(teamName))
                // {
                //     //when we have only teamName
                //     IList<Team> authors = await FootballDbContext.Teams.Include(t => t.Players)
                //         .Where(team => team.TeamName.Equals(teamName)).ToListAsync();
                //     return authors;
                // }
                // else if(String.IsNullOrEmpty(teamName) &&(ranking != null || ranking > 0 ) )
                // {
                //     //when we have only ranking
                //     IList<Team> authors = await FootballDbContext.Teams.Include(t => t.Players)
                //         .Where(team => team.Ranking <= ranking).ToListAsync();
                //     return authors;
                // }
                // else
                // {
                    IList<Team> authors = await FootballDbContext.Teams.Include(t => t.Players)
                        .ToListAsync();
                    return authors;
                // }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
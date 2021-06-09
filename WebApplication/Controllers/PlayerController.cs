using System;
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
    public class PlayerController : ControllerBase
    {
        private FootballDBContext FootballDbContext;

        public PlayerController()
        {
            FootballDbContext = new FootballDBContext();
        }

        [HttpPost]
        [Route("/player/{teamName:String}")]
        public async Task<bool> AddPlayer([FromBody] Player player, [FromRoute] String teamName)
        {
            Console.WriteLine("Got a new player to add " + player.ShirtNumber);

            try
            {
                var team = await FootballDbContext.Teams.FirstOrDefaultAsync(t => t.Equals(teamName));
                team.Players.Add(player);
                FootballDbContext.Update(team);
                FootballDbContext.Teams.Update(team);
                await FootballDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        [HttpDelete]
        [Route("/player/{shirtNumber:int}/{teamName:String}")]
        public async Task<ActionResult<bool>> removePlayer([FromRoute] int shirtNumber, [FromRoute] String teamName)
        {
            //just showing I remmeber about ActionResult, it just another layer where i can make a mistake at the exam
            try
            {
                var team = await FootballDbContext.Teams.Include(t => t.Players)
                    .FirstOrDefaultAsync(t1 => t1.TeamName.Equals(teamName));
                var player = team.Players.FirstOrDefault(player => player.ShirtNumber == shirtNumber);
                team.Players.Remove(player);
                FootballDbContext.Teams.Update(team);
                FootballDbContext.Update(team);
                await FootballDbContext.SaveChangesAsync();
                return Ok(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}
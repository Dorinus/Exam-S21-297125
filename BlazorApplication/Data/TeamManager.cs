using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class TeamManager : ITeamManager
    {
        private HttpClient Client;
        private String Uri;

        public TeamManager()
        {
            Client = new HttpClient();
            Uri = "https://localhost:5004";
        }
        
        public async Task<bool> CreateTeam(Team team)
        {
            
            String productAsJson = JsonSerializer.Serialize(team);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/team",  content);
            if (responseMessage.IsSuccessStatusCode)
            {
                
                string result = await responseMessage.Content.ReadAsStringAsync();
                bool response = JsonSerializer.Deserialize<bool>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return response;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }

        public async Task<IList<Team>> GetTeams(int ranking, string teamName)
        {
            
            //For now not using the arguments
            HttpResponseMessage responseMessage = await Client.GetAsync(Uri + "/team" );
            if (responseMessage.IsSuccessStatusCode)
            {
                string result = await responseMessage.Content.ReadAsStringAsync();
                IList<Team> teams =  JsonSerializer.Deserialize<IList<Team>>(result,
                    new JsonSerializerOptions {PropertyNamingPolicy = JsonNamingPolicy.CamelCase});
                return teams;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return null;
            }
        }
    }
}
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Models
{
    public class PlayerManager : IPlayerManager
    {
        private HttpClient Client;
        private String Uri;

        public PlayerManager()
        {
            Client = new HttpClient();
            Uri = "https://localhost:5004";
        }

        public async Task<bool> AddPlayer(Player player, String teamName)
        {
            String productAsJson = JsonSerializer.Serialize(player);
            StringContent content = new StringContent(productAsJson, Encoding.UTF8, "application/json");
            HttpResponseMessage responseMessage = await Client.PostAsync(Uri + "/player/" + teamName,  content);
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

        public async Task<bool> RemovePlayer(int shirtNumber, string teamName)
        {
            HttpResponseMessage responseMessage = await Client.DeleteAsync( Uri + "/player/" + shirtNumber + "/" + teamName);
            if (responseMessage.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                Console.WriteLine($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
                return false;
            }
        }
    }
}
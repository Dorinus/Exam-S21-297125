using System;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public interface IPlayerManager
    {
        Task<bool> AddPlayer(Player player, String teamName);
        Task<bool> RemovePlayer(int shirtNumber, string teamName);
    }
}
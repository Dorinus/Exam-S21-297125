using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Team
    {
        [Key]
        public String TeamName { get; set; }
        [Required, MaxLength(50)]
        public String NameOfCoach { get; set; }
        public int Ranking { get; set; }
        public List<Player> Players { get; set; }
        
    }
}
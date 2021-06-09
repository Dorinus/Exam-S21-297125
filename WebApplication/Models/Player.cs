using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Player
    {
        [Required, MaxLength(50)]
        public String Name { get; set; }
        [Key]
        [Range(0, 99, ErrorMessage = "Please enter valid integer number between 0 and 99 incusive")]
        public int ShirtNumber { get; set; }
        public decimal Salary { get; set; }
        public int GoalsThisSeason { get; set; }
        [Required]
        public String Position { get; set; }
    }
}
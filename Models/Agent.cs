using MossadAgentsMVC.Enums;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MossadAgentsMVC.Models;

namespace MossadAgentsMVC.Models
{
    public class Agent
    {
        [Key]
        public int id { get; set; }
        public string photoUrl { get; set; }
        public string nickname { get; set; }
        public Coordinates coordinates { get; set; }
        public AgentStatus Status { get; set; }
    }
}

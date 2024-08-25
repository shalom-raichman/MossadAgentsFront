using MossadAgentsMVC.Enums;
using MossadAgentsMVC.Models;
using System.ComponentModel.DataAnnotations;

namespace MossadAgentsMVC.Models
{
    public class Target
    {
        [Key]
        public Guid? Id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string? photo_url { get; set; }
        public Coordinates coordinates { get; set; }
        public TargetStatus? Status { get; set; } = TargetStatus.Alive;
    }
}

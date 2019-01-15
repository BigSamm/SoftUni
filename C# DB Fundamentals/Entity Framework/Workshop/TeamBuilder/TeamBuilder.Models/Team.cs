namespace TeamBuilder.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        public Team()
        {
            this.Invitations = new List<Invitation>();
            this.UserTeams = new List<UserTeam>();
            this.EventTeams = new List<EventTeam>();
        }

        [Key]
        public int TeamId { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [MinLength(3)]
        public string Acronym { get; set; }

        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public ICollection<Invitation> Invitations { get; set; }
        public ICollection<UserTeam> UserTeams { get; set; }
        public ICollection<EventTeam> EventTeams { get; set; }
    }
}

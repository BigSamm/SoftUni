namespace TeamBuilder.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Invitation
    {
        public Invitation()
        {
            this.IsActive = true;
        }

        [Key]
        public int InvitationId { get; set; }

        public int InvitedUserId { get; set; }
        public User InvitedUser { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public bool IsActive { get; set; }
    }
}

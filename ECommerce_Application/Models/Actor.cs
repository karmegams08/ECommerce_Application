using System.ComponentModel.DataAnnotations;

namespace ECommerce_Application.Models
{
    public class Actor

    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
    }
}

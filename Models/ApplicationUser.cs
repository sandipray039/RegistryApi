using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components.Routing;


namespace RegistryApi.Models
{
    public class ApplicationUser 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Role { get; set; } = "Employee";

        public string LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Attendence> Attendences { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Break> Breaks { get; set; }
        public ICollection<Report> Reports { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace RegistryApi.Models
{
    public class Location
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public double GeofenceRadius { get; set; } // In meters

        public ICollection<ApplicationUser> Users { get; set; }
        public ICollection<Attendence> Attendances { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RegistryApi.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public double GeofenceRadius { get; set; } // In meters

        public ICollection<User> Users { get; set; }
        public ICollection<Attendence> Attendances { get; set; }
    }
}

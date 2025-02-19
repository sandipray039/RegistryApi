using System.ComponentModel.DataAnnotations;

namespace RegistryApi.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } // Admin, Employee, Manager, etc.

        public string Description { get; set; }
    }
}

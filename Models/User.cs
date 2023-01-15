using System.ComponentModel.DataAnnotations;

namespace dotnet_rpg.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = Array.Empty<byte>();
        public byte[] PasswordSalt { get; set; } = Array.Empty<byte>();
        public List<Character>? Characters { get; set; }
        [Required]
        public string Role { get; set; }
    }
}

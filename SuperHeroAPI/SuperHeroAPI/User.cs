using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SuperHeroAPI
{
    public class User
    {
        public int Id { get; set; }
        [Key]
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SmsSender.Client.Models
{
    public class User
    {
        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
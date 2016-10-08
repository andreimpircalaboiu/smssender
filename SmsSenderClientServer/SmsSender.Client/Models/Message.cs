using System.ComponentModel.DataAnnotations;

namespace SmsSender.Client.Models
{
    public class Message
    {
        [Required]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string MessageContent { get; set; }
        public Enums.Priority Priority { get; set; }
        public string Username { get; set; }
        public string SuccessMessage { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryManagementSystem.Models
{
    public class ContactUs
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Subject { get; set; } = string.Empty;
        [Required]
        public string Message { get; set; } = string.Empty;
    }
}

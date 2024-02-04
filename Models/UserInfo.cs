using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon alanı zorunludur.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Hatalı email girdiniz.")]
        public string? Email { get; set; }
        
        public bool? WillAttend { get; set; }
    }
}
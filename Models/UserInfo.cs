namespace MeetingApp.Models
{
    public class UserInfo
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool? WillAttend { get; set; }
    }
}
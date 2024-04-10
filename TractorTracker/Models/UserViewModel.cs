namespace TractorTracker.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string TimeZoneId { get; set; }
        public List<string> TimeZones { get; set; } = new List<string>(TimeZoneInfo.GetSystemTimeZones().Select(t => t.DisplayName));
    }
}

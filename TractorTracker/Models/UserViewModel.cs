namespace TractorTracker.Web.Models
{
    public class UserViewModel
    {
        public int Id { get; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public TimeZoneInfo TimeZoneInfo { get; set; }
    }
}

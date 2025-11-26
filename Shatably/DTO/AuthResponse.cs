namespace Shatably.DTO
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
    }
}

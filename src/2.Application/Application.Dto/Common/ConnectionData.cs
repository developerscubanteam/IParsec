
namespace Application.Dto.Common
{
    public class ConnectionData
    {
        public required string Url { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Context { get; set; }
    }
}

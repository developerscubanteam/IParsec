namespace Infrastructure.Connectivity.Queries.Base
{
    public class ConnectionData
    {
        public required string Context { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Url { get; set; }
    }
}

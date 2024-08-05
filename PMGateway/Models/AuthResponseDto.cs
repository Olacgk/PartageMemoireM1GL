namespace PMGateway.Models
{
    public class AuthResponseDto
    {
        public bool IsAuthSuccessful { get; set; }
        public string? ErrorMessage { get; set; }
        public string? Token { get; set; }
        public ServiceExpert.Expert User { get; set; }
    }
}

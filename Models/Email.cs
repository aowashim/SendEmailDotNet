namespace SendEmailTest.Models
{
    public class Email
    {
        public string To { get; set; } = string.Empty;
        public string Body { get; set; } = "Test Mail";
        public string Subject { get; set; } = string.Empty;
    }
}

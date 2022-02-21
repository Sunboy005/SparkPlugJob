using System;

namespace Models
{
    public class Message
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; init; }
        public string Email { get; init; }
        public string MessageText { get; init; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString();
    }
}

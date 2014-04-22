using System;

namespace MVChat.Model
{
    public class Message
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public User Writer { get; set; }
    }
}

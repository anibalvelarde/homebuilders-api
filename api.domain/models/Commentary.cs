using System;

namespace api.domain.models
{
    public class Commentary
    {
        public Commentary() { }

        public Enums.CommentType Type { get; set; }
        public DateTime CommentedOn { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
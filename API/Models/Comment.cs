using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int Likes { get; set; }
        public int UserId { get; set; }
        public int ThreadId { get; set; }
        public int PostId { get; set; }
        public int StoryLineId { get; set; }
        public DateTimeOffset CreatedAt { get; init; }
    }
}
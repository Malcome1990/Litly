using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public int ThreadId { get; set; }
        public DateTimeOffset CreatedAt { get; init; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos.Forks
{
    public class PostForkDto
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public int Likes { get; set; }
        public int UserId { get; set; }
        public int StoryLineId { get; set; }
    }
}
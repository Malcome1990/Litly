using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Dtos.StoryLine
{
    public class PostStoryLineDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }

    }
}